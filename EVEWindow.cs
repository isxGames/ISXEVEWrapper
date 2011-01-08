using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Retrieves information about an Eve Window.
	/// </summary>
	public class EVEWindow : LavishScriptObject
	{
		#region Constructors
    /// <summary>
    /// EVEWindow copy constructor.
    /// </summary>
    /// <param name="Obj"></param>
		public EVEWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Possible "Names" include: "MyShipCargo", "MyDroneBay", "Market", "hangarFloor", 
		/// "shipHangar", "Local", "Corporation Hangar" (more added as needed/requested).
		/// </summary>
		public EVEWindow(string name)
			: base(LavishScript.Objects.GetObject("EVEWindow", name))
		{
		}
		#endregion

		#region Statics
		/// <summary>
		/// should only be used for windows not available otherwise (ie, cargo containers).
		/// </summary>
		public static EVEWindow GetWindowByCaption(string caption)
		{
			return new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByCaption", caption));
		}

    /// <summary>
    /// Returns an evewindow type based on a window name.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
		public static EVEWindow GetWindowByName(string name)
		{
			return new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", name));
		}
		#endregion

		#region Members
    /// <summary>
    /// Wrapper for the Caption member of the evewindow type.
    /// </summary>
		public string Caption
		{
			get
			{
				return GetMember<string>("Caption");
			}
		}

    /// <summary>
    /// Wrapper for the Minimized member of the evewindow type.
    /// </summary>
		public bool Minimized
		{
			get
			{
				return GetMember<bool>("Minimized");
			}
		}

    /// <summary>
    /// Wrapper for the HTML member of the evewindow type.
    /// </summary>
		public string HTML
		{
			get
			{
				return GetMember<string>("HTML");
			}
		}
		#endregion

		#region Methods
    /// <summary>
    /// Wrapper for the Close method of the evewindow type.
    /// </summary>
    /// <returns></returns>
		public bool Close()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("EVEWindow.Close", string.Empty);
			return ExecuteMethod("Close");
		}

    /// <summary>
    /// Wrapper for the Maximize method of the evewindow type.
    /// </summary>
    /// <returns></returns>
		public bool Maximize()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("EVEWindow.Maximise", string.Empty);
			return ExecuteMethod("Maximize");
		}

    /// <summary>
    /// Wrapper for the Minimize method of the evewindow type.
    /// </summary>
    /// <returns></returns>
		public bool Minimize()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("EVEWindow.Minimize", string.Empty);
			return ExecuteMethod("Minimize");
		}
		#endregion
	}
}
