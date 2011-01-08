using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using LavishScriptAPI;
using EVE.ISXEVE;

namespace isxProfiler
{
	class Program
	{
		enum RunModes
		{
			Timing = 1,
			Testing = 2
		}
		static EventHandler<LSEventArgs> Pulse;
		static DateTime timeOfNextPulse = DateTime.Now;
		static bool CompletedAllObjects = false;
		static Stopwatch timerStopwatch = new Stopwatch();
		static int TimesToCallMember = 1;
		static double NanoSecsPerTick = 0;

		static List<string> messagesToSave = new List<string>();

		static string WrapperName = String.Empty;
		static string ClassName = String.Empty;
		static bool ProcessessAllClasses = false;
		static RunModes RunMode = RunModes.Testing;

		static int MemberIndex = 0;
		static List<MemberInfo> ObjMembers = new List<MemberInfo>();
		static int ObjectIndex = 0;
		static List<string> ObjectList = new List<string>();
		static Assembly GameWrapper;
		static string[] Params;


		static void Main(string[] args)
		{
			Log("----------------------------------------------");
			Log("v1.02 Beta by Cybertech & Stealthy");

			if (args.Length < 2)
			{
				Log("Options:");
				Log("  --wrapper     Wrapper name to test");
				Log("  --allclasses  Test all classes in wrapper");
				Log("  --class       Test specific class in wrapper");
				Log("  --params      Space-delimted parameters to use in the constructor of the specified class (must be the final option)");
				Log("Run Mode:");
				Log("  --timing      Call each member 100 times and average the call time results");
				Log("  --test        Call each member 1 time and report the timing and value (Default)");
				Log("Examples:");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --allclasses");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --class Character --test");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --class Character --timing");
				Log("  dotnet isxprofiler isxprofiler --wrapper ISXEVEWrapper --class Entity --test --params ${Me.Name}");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --class Entity --test --params ${Me.ToEntity.ID}");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --class Module --test --params HiSlot0");
				Log("  dotnet isxProfiler isxProfiler --wrapper ISXEVEWrapper --class LocalPilots --timing --params ${Me.Name}");
				Log("Notes:");
				Log("  Inherited members are ignored");
				Log("  Timings are in milliseconds");
				return;
			}
			else
			{
				int argindex = 0;
				while (argindex < args.Count())
				{
					//Log("Param #" +argindex.ToString() + " " + args[argindex].ToString());
					if (args[argindex].ToString().StartsWith("--"))
					{
						if (args[argindex].ToString().ToLower() == "--allclasses")
						{
							argindex++;
							ProcessessAllClasses = true;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--iterations")
						{
							argindex++;
							TimesToCallMember = Convert.ToInt32(args[argindex]);
							argindex++;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--wrapper")
						{
							argindex++;
							WrapperName = args[argindex].ToString();
							argindex++;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--class")
						{
							argindex++;
							ClassName = args[argindex].ToString();
							argindex++;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--timing")
						{
							argindex++;
							TimesToCallMember = 100;
							RunMode = RunModes.Timing;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--test")
						{
							argindex++;
							TimesToCallMember = 1;
							RunMode = RunModes.Testing;
							continue;
						}
						else if (args[argindex].ToString().ToLower() == "--params")
						{
							//--params should be the last flag, so anything from here to Count is a parameter
							argindex++;
							int test = args.Count() - argindex ;
							Params = new string[test];
							for (int idx = argindex; idx < args.Count(); idx++)
							{
								Params[idx - argindex] = args[idx];
							}
							argindex += test - 1;
						}
						argindex++;
					}
					else
					{
						Log("Bad parameters specified: " + args[argindex].ToString());
						return;
					}
				}
			}

			try
			{
				GameWrapper = Assembly.Load(WrapperName);
			}
			catch (FileNotFoundException)
			{
				Log(String.Format("Bad parameters specified: {0}", WrapperName));
				return;
			}
			List<Type> alltypes = new List<Type>(GameWrapper.GetTypes());
			foreach (Type temp in alltypes)
				if (ProcessessAllClasses || temp.Name == ClassName)
				{
					ObjectList.Add(temp.Namespace + "." + temp.Name);
				}

			ObjectList.Sort();
			string TestClasses = String.Empty;
			ObjectList.ForEach(delegate(String name)
			{
				if (TestClasses.Length == 0)
					TestClasses = name;
				else
					TestClasses += ", " + name.Substring(name.LastIndexOf(".")+1);

			});
			if (ObjectList.Count() == 1)
				Log("Profiling 1 class: " + TestClasses.ToString());
			else
				Log("Profiling " + ObjectList.Count() + " classes: " + TestClasses.ToString());

			if (RunMode == RunModes.Timing)
			{
				Log("Timing each member " + TimesToCallMember.ToString().ToLower() + " times and averaging the results");
			}

			long frequency = Stopwatch.Frequency;
			Log(" Timer frequency in ticks per second = " + frequency.ToString());
			NanoSecsPerTick = 1000000000.0 / frequency;
			Log(" Timer is accurate within " + NanoSecsPerTick.ToString() + " ns (" + NanoSecsPerTick * 0.000001 + "ms) HighRes: " + Stopwatch.IsHighResolution.ToString());

			timerStopwatch.Reset();
			timerStopwatch.Start();
			Thread.Sleep(10);
			timerStopwatch.Stop();
			Log(" Test: Thread.Sleep(10) timed at " + timerStopwatch.ElapsedMilliseconds.ToString() + "ms");
			timerStopwatch.Reset();
			timerStopwatch.Start();
			Thread.Sleep(1);
			timerStopwatch.Stop();
			Log(" Test: Thread.Sleep(1) timed at " + timerStopwatch.ElapsedMilliseconds.ToString() + "ms");
			timerStopwatch.Reset();

			Pulse = new EventHandler<LSEventArgs>(HandleFrame);
			string eventName = string.Empty;
			if (WrapperName.ToLower() == "isxevewrapper")
			{
				eventName = "ISXEVE_onFrame";
			}
			else
			{
				eventName = "OnFrame";
			}
			LavishScript.Events.AttachEventTarget(eventName, Pulse);

			while (!CompletedAllObjects)
			{
				Thread.Sleep(1);
			}

			LavishScript.Events.DetachEventTarget(eventName, Pulse);

			// Dump the buffered log to the logfile. 
			string profilingDirectory = String.Format("{0}\\Profiling", Path.GetDirectoryName(Application.ExecutablePath));
			string wrapperDirectory = string.Format("{0}\\{1}", profilingDirectory, WrapperName);
			string dateDirectory = string.Format("{0}\\{1}.{2}.{3}", wrapperDirectory, DateTime.Now.Month,
				DateTime.Now.Day, DateTime.Now.Year);
			string filePath = String.Format("{0}\\{1}_{2}.txt", dateDirectory, ClassName, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
			Log(filePath);
			if (!Directory.Exists(profilingDirectory))
			{
				Directory.CreateDirectory(profilingDirectory);
			}
			if (!Directory.Exists(wrapperDirectory))
			{
				Directory.CreateDirectory(wrapperDirectory);
			}
			if (!Directory.Exists(dateDirectory))
			{
				Directory.CreateDirectory(dateDirectory);
			}
			using (StreamWriter logfile = new StreamWriter(File.Open(filePath, FileMode.Create)))
			{
				foreach (string s in messagesToSave)
				{
					logfile.WriteLine(s);
				}
			}
		}

		public static int SortByObjectName(MemberInfo obj1, MemberInfo obj2)
		{
			return obj1.Name.CompareTo(obj2.Name);
		}

		public static void HandleFrame(object sender, LSEventArgs e)
		{
			if (DateTime.Now.CompareTo(timeOfNextPulse) >= 0 && !CompletedAllObjects)
			{
				timeOfNextPulse = timeOfNextPulse.AddMilliseconds(TimesToCallMember);

				if (ObjectIndex < ObjectList.Count)
				{
					Assembly assembly = Assembly.GetExecutingAssembly();
					AssemblyName assemblyName = assembly.GetName();
					Type t = GameWrapper.GetType(ObjectList[ObjectIndex], true);

					timerStopwatch.Start();
					Object TestObject;
					if (Params != null)
						TestObject = Activator.CreateInstance(t, Params[0]);
					else
						TestObject = Activator.CreateInstance(t);
					timerStopwatch.Stop();

					if (ObjMembers.Count() == 0)
					{
						// Rebuild the members list for the (presumably) new class
						Log("Acquiring members list for next class...");
						ObjMembers = TestObject.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).ToList();
						ObjMembers.Sort(new Comparison<MemberInfo>(SortByObjectName));
					}

					while ((MemberIndex < ObjMembers.Count) && (ObjMembers[MemberIndex].MemberType != MemberTypes.Property))
					{
						MemberIndex++;
					}
					if (MemberIndex < ObjMembers.Count)
					{
						CallObjectMember(TestObject, ObjMembers[MemberIndex].Name, timerStopwatch.ElapsedMilliseconds);
						MemberIndex++;
					}
					else
					{
						ObjectIndex++;
						ObjMembers.Clear();
					}
				}
				else
				{
					MemberIndex = 0;
					CompletedAllObjects = true;
				}
				return;
			}
		}

		public static void CallObjectMember(object Obj, string TestMember, long InstantiationTimeMS)
		{
			List<long> TimingList = new List<long>();
			string value = String.Empty;

			for (int idx = 0; idx < TimesToCallMember; idx++)
			{
				try
				{
					Object Result;
					timerStopwatch.Reset();
					timerStopwatch.Start();
					Result = Obj.GetType().InvokeMember(TestMember, BindingFlags.GetField | BindingFlags.GetProperty, null, Obj, null);
					timerStopwatch.Stop();
					if (Result == null)
					{
						value = "NULL";
					}
					else
					{
						value = Result.ToString();
					}
					if (timerStopwatch.ElapsedMilliseconds < 0)
					{
						Log("Negative value from Stopwatch");
					}
					TimingList.Add(timerStopwatch.ElapsedTicks);
				}
				catch (Exception ex)
				{
					value = "Exception: " + ex.Message;
					break;
				}
			}
			try
			{
				if (TimingList.Count() == 0)
				{
					TimingList.Add(0);
				}
				string Result = string.Format("{0} x {1}.{2} Avg: {3} Min: {4:} Max: {5} TLO: {5} Value: {7}",
									TimesToCallMember.ToString(),
									Obj.GetType().ToString(),
									TestMember.PadRight(25),
									(TimingList.Average() * NanoSecsPerTick * 0.000001).ToString("###0.00000000").PadLeft(13),
									(TimingList.Min() * NanoSecsPerTick * 0.000001).ToString("##0.000000").PadLeft(10),
									(TimingList.Max() * NanoSecsPerTick * 0.000001).ToString("##0.000000").PadLeft(10),
									(InstantiationTimeMS * NanoSecsPerTick * 0.000001).ToString("##0.000000").PadLeft(10),
									value
									);
				Log(Result);
			}
			catch (Exception ex)
			{
				Log(Obj.GetType().ToString()  + "." + TestMember + ": Exception During Logging: " + ex.Message);
				return;
			}
			TimingList.Clear();
		}

		public static void Log(string LogMsg)
		{
			InnerSpaceAPI.InnerSpace.Echo("isxProfiler: " + LogMsg);
			messagesToSave.Add(LogMsg);
		}
	}
}