using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// CallbackDelegate used in trace logging.
    /// </summary>
    /// <param name="method"></param>
    /// <param name="args"></param>
    public delegate void CallbackDelegate(string method, string args);
    /// <summary>
    /// Class used for trace logging.
    /// </summary>
    public class Tracing
    {
		/// <summary>
		/// Callback to use for logging.
		/// </summary>
		public static CallbackDelegate Callback;

        /// <summary>
        /// Add a callback delegate for trace logging.
        /// </summary>
        /// <param name="callbackDelegate"></param>
        public static void AddCallback(CallbackDelegate callbackDelegate)
        {
            Callback = callbackDelegate;
        }

        /// <summary>
        /// Clear the callback delegate.
        /// </summary>
        public static void RemoveCallback()
        {
            Callback = null;
        }

        /// <summary>
        /// Use the callback delegate to send a log message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void SendCallback(string message, params object[] args)
        {
            if (Callback != null)
            {
				StringBuilder argString = new StringBuilder();
				if (args.Length > 0)
				{
					argString.Append(args[0].ToString());
				}
				for (int idx = 1; idx < args.Length; idx++)
				{
					argString.Append(String.Format(", {0}", args[idx].ToString()));
				}

                Callback(message, argString.ToString());
            }
        }
    }

	internal class Util
	{
		private static T[] PrefixArray<T>(T First, T[] Rest)
		{
			T[] NewArray = new T[Rest.Length + 1];

			NewArray[0] = First;

			for (int i = 0; i < Rest.Length; i++)
				NewArray[i + 1] = Rest[i];

			return NewArray;
		}

		private static List<T> IndexToLavishScriptObjectList<T>(LavishScriptObject Index, string LSTypeName)
		{
			string methodName = "IndexToLSOList";
			//Tracing.SendCallback(methodName, LSTypeName);

			//Tracing.SendCallback(methodName, "getmember Used");
			List<T> List = new List<T>();
			int Count = Index.GetMember<int>("Used");

			if (Count == 0)
			{	
				return List;
			}

			//Tracing.SendCallback(methodName, "get constructor info");
			ConstructorInfo constructor = typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) });

			//Tracing.SendCallback(methodName, "loop add items");
			for (int i = 1; i <= Count; i++)
			{
				LavishScriptObject objectLso = Index.GetIndex(i.ToString());

				if (LavishScriptObject.IsNullOrInvalid(objectLso))
				{
					if (LavishScriptObject.IsNullOrInvalid(objectLso))
					{
						Tracing.SendCallback(String.Format("Error: Index contains invalid LSO. NewObject will fail; aborting."));
						return List;
					}
				}

				LavishScriptObject objectIdLso = objectLso.GetMember("ID");

				if (LavishScriptObject.IsNullOrInvalid(objectIdLso))
				{
					Tracing.SendCallback(String.Format("Error: LStype \"{0}\" has no ID member. NewObject will fail; aborting.", LSTypeName));
					return List;
				}

				string objectId = objectIdLso.GetValue<string>();

				if (objectId == string.Empty)
				{
					Tracing.SendCallback(String.Format("Error: LStype \"{0}\" has an ID member but it is returning an empty string. NewObject will fail; aborting.", LSTypeName));
					return List;
				}

				LavishScriptObject lsObject = LavishScript.Objects.NewObject(LSTypeName, objectId);
				T item = (T)constructor.Invoke(new object[] { lsObject });
				List.Add(item);
                // Do not invalidate this object :)
				//lsObject.Invalidate();
			}

			//Tracing.SendCallback(methodName, "return");
			return List;
		}

		private static List<T> IndexToStructList<T>(LavishScriptObject Index)
		{
			List<T> List = new List<T>();
			int Count = Index.GetMember<int>("Used");

			for (int i = 1; i <= Count; i++)
				List.Add(Index.GetIndex<T>(i.ToString()));

			return List;
		}

		private static List<T> IndexToList<T>(LavishScriptObject Index, string LSTypeName)
		{
			//Tracing.SendCallback("IndextoList", LSTypeName);
			if (typeof(T).IsSubclassOf(typeof(LavishScriptObject)))
			{
				//Tracing.SendCallback("IndexToList", "call IndexToLSOList");
				return IndexToLavishScriptObjectList<T>(Index, LSTypeName);
			}
			else
				return IndexToStructList<T>(Index);
		}

		private static T IndexToLavishScriptObject<T>(LavishScriptObject Index, int number)
		{
			ConstructorInfo constructor = typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) });

			return (T)constructor.Invoke(new object[] { Index.GetIndex(number.ToString()) });
		}

		public static T GetIndexMember<T>(LavishScriptObject Index, int number)
		{
			if (typeof(T).IsSubclassOf(typeof(LavishScriptObject)))
				return (T)typeof(T).GetConstructor(new Type[] { typeof(LavishScriptObject) }).Invoke(new object[] { Index.GetIndex(number.ToString()) });
			else
				return Index.GetIndex<T>(number.ToString());
		}

		internal static List<T> GetListFromMethod<T>(ILSObject Obj, string MethodName, string LSTypeName, params string[] Args)
		{
			string methodName = "GetListFromMethod";
			//Tracing.SendCallback(methodName, MethodName, LSTypeName);

			if (Obj == null || !Obj.IsValid)
				return null;

			//Tracing.SendCallback(methodName, "Create new LSO of index. Type: ", LSTypeName);
			using (var Index = LavishScript.Objects.NewObject("index:" + LSTypeName))
			{
				//Tracing.SendCallback(methodName, "Collapsing Args[]");

				string[] allargs;
				if (Args.Length > 0)
				{
					allargs = PrefixArray<string>(Index.LSReference, Args);
				}
				else
				{
					allargs = new string[1];
					allargs[0] = Index.LSReference;
				}

				//Tracing.SendCallback(methodName, "Execute method, name: ", MethodName);
				if (!Obj.ExecuteMethod(MethodName, allargs))
					return null;

				//Tracing.SendCallback(methodName, "Get member Used");
				using (var used = Index.GetMember("Used"))
				{
					//Tracing.SendCallback(methodName, "LSO.IsNullOrInvalid (used)");
					if (LavishScriptObject.IsNullOrInvalid(used))
						return null;
				}

				//Tracing.SendCallback(methodName, "IndexToList");
				var list = IndexToList<T>(Index, LSTypeName);

				//Tracing.SendCallback(methodName, "Returning");
				return list;
			}
		}

		internal static T GetFromIndexMethod<T>(ILSObject Obj, string MethodName, string LSTypeName, int number, params string[] Args)
		{
			// argument is 0-based
			number += 1;

			if (Obj == null || !Obj.IsValid || number <= 0)
				return default(T);

			using (var Index = LavishScript.Objects.NewObject("index:" + LSTypeName))
			{
				var allargs = PrefixArray(Index.LSReference, Args);

				if (!Obj.ExecuteMethod(MethodName, allargs))
					return default(T);

				using (var used = Index.GetMember("Used"))
				{
					// if it failed or we want one off the end, return
					if (LavishScriptObject.IsNullOrInvalid(used) || used.GetValue<int>() < number)
						return default(T);
				}

				T member = GetIndexMember<T>(Index, number);
				return member;
			}
		}

		internal static List<T> GetListFromMember<T>(ILSObject Obj, string MemberName, string LSTypeName, params string[] Args)
		{
			var methodName = "GetListFromMember";
			//Tracing.SendCallback(methodName, MemberName, LSTypeName);
			
			if (Obj == null || !Obj.IsValid)
				return null;

			//Tracing.SendCallback(methodName, "new index");
			using (var Index = LavishScript.Objects.NewObject("index:" + LSTypeName))
			{
				//Tracing.SendCallback(methodName, "arg condensing");
				var allargs = PrefixArray<string>(Index.LSReference, Args);

				//Tracing.SendCallback(methodName, "getmember retval");
				using (var retval = Obj.GetMember(MemberName, allargs))
				{
					if (LavishScriptObject.IsNullOrInvalid(retval))
						return null;
				}

				//Tracing.SendCallback(methodName, "index to list");
				var list = IndexToList<T>(Index, LSTypeName);

				//Tracing.SendCallback(methodName, "invalidate");

				//Tracing.SendCallback(methodName, "return");
				return list;
			}
		}



		internal static List<T> GetListFromPersistentMember<T>(ILSObject Obj, string MemberName, string LSTypeName, params string[] Args)
		{
			if (Obj == null || !Obj.IsValid)
				return null;

			LavishScriptObject Index = LavishScript.Objects.NewObject("index:" + LSTypeName);

			string[] allargs = PrefixArray<string>(Index.LSReference, Args);

			LavishScriptPersistentObject retval = Obj.GetPersistentMember(MemberName, allargs);

			if (LavishScriptPersistentObject.IsNullOrInvalid(retval))
				return null;

			List<T> list = IndexToList<T>(Index, LSTypeName);
			Index.Invalidate();

			return list;
		}

		internal static T GetFromIndexMember<T>(ILSObject Obj, string MemberName, string LSTypeName, int number, params string[] Args)
		{
			// argument is 0-based
			number += 1;

			if (Obj == null || !Obj.IsValid)
				return default(T);

			using (var Index = LavishScript.Objects.NewObject("index:" + LSTypeName))
			{
				var allargs = PrefixArray(Index.LSReference, Args);

				using (var retval = Obj.GetMember(MemberName, allargs))
				{
					if (LavishScriptObject.IsNullOrInvalid(retval) || retval.GetValue<int>() < number)
						return default(T);
				}

				T member = GetIndexMember<T>(Index, number);
				return member;
			}
		}
	}
}
