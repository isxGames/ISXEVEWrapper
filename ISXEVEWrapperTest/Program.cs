using System;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;
using EVE.ISXEVE;

namespace ISXEVEWrapperTest
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			/* This doesn't do anything useful except give me a place to test wrapper functions -- CyberTech */

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			InnerSpace.Echo("ISXEVEWrapperTest: Begin");

			using (new FrameLock(true))
			{
				LavishScriptObject _Me = LavishScript.Objects.GetObject("Me");
				InnerSpace.Echo("Name: " + _Me.GetMember("Name"));

				//Extension Ext = new Extension();
				//InnerSpace.Echo("Name: " + Ext.Me.Name);
				//    InnerSpace.Echo("Nearest Stargate (fails in station): " + Ext.Entity("Stargate").Name);

				//    InnerSpace.Echo("Undocking Method 1...");
				//    //Ext.EVE().Execute(ExecuteCommand.CmdExitStation);

				//    InnerSpace.Echo("Undocking Method 2...");
				//    //Ext.EVE().Execute("CmdExitStation");

				//    InnerSpace.Echo(Ext.ISXEVE().SecsToString(500));

				//Extension Ext = new Extension();
				//InnerSpace.Echo(Ext.Me.Name.ToString(CultureInfo.CurrentCulture));
				//InnerSpace.Echo(Me.Ship.ToString(CultureInfo.CurrentCulture));


			}
			InnerSpace.Echo("ISXEVEWrapperTest: End");
		}
	}
}