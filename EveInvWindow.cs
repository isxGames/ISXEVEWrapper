using System;
using System.Collections.Generic;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrap an eveinvwindow object
	/// </summary>
	public class EveInvWindow : EVEWindow
	{
		/// <summary>
		/// Create a new EveInvWindow from an existing LSO
		/// </summary>
		/// <param name="copy"></param>
		public EveInvWindow(LavishScriptObject copy) : base(copy)
		{
			
		}

		private EveInvChildWindow _activeChild;
		/// <summary>
		/// Get the active child window.
		/// </summary>
		public EveInvChildWindow ActiveChild
		{
			get { return _activeChild ?? (_activeChild = new EveInvChildWindow(GetMember("ActiveChild"))); }
		}

		/// <summary>
		/// Get a child window by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public EveInvChildWindow GetChildWindow(Int64 id)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", id.ToString()));
		}

		/// <summary>
		/// Get a child window by name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public EveInvChildWindow GetChildWindow(string name)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", name));
		}

		/// <summary>
		/// Get a child window by name and location.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="location"></param>
		/// <returns></returns>
		public EveInvChildWindow GetChildWindow(string name, string location)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", name, location));
		}

		/// <summary>
		/// Get a child window by ID and Name.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public EveInvChildWindow GetChildWindow(Int64 id, string name)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", id.ToString(), name));
		}

		/// <summary>
		/// Get a child window by ID, Name, and Location.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="location"></param>
		/// <returns></returns>
		public EveInvChildWindow GetChildWindow(Int64 id, string name, string location)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", id.ToString(), name, location));
		}

		private List<EveInvChildWindow> _children;
		///<summary>
		/// Get the child windows of this EveInvWindow
		///</summary>
		///<returns></returns>
		public List<EveInvChildWindow> GetChildren()
		{
			return _children ?? (_children = Util.GetListFromMethod<EveInvChildWindow>(this, "GetChildren", "eveinvchildwindow"));
		}
	}
}
