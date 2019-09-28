using System;
using System.Collections.Generic;
using EVE.ISXEVE.Extensions;
using EVE.ISXEVE.Interfaces;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the EveInvWindow datatype
	/// </summary>
	public class EveInvWindow : EVEWindow, IEveInvWindow
	{
		/// <summary>
		/// Create a new EveInvWindow from an existing LSO
		/// </summary>
		/// <param name="copy"></param>
		public EveInvWindow(LavishScriptObject copy) : base(copy)
		{
			
		}

		private IEveInvChildWindow _activeChild;
		/// <summary>
		/// Get the active child window.
		/// </summary>
		public IEveInvChildWindow ActiveChild
		{
			get { return _activeChild ?? (_activeChild = new EveInvChildWindow(GetMember("ActiveChild"))); }
		}

	    /// <summary>
	    /// Get a child window by ID.
	    /// </summary>
	    /// <param name="id"></param>
	    /// <returns></returns>
	    public IEveInvChildWindow GetChildWindow(long id)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", id.ToString()));
		}

	    /// <summary>
	    /// Get a child window by name.
	    /// </summary>
	    /// <param name="name"></param>
	    /// <returns></returns>
	    public IEveInvChildWindow GetChildWindow(string name)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", name));
		}

	    /// <summary>
	    /// Get a child window by name and location.
	    /// </summary>
	    /// <param name="name"></param>
	    /// <param name="location"></param>
	    /// <returns></returns>
	    public IEveInvChildWindow GetChildWindow(string name, string location)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", name, location));
		}

	    /// <summary>
	    /// Get a child window by ID and Name.
	    /// </summary>
	    /// <param name="id"></param>
	    /// <param name="name"></param>
	    /// <returns></returns>
	    public IEveInvChildWindow GetChildWindow(long id, string name)
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
	    public IEveInvChildWindow GetChildWindow(long id, string name, string location)
		{
			return new EveInvChildWindow(GetMember("ChildWindow", id.ToString(), name, location));
		}

		private List<IEveInvChildWindow> _children;

	    /// <summary>
	    ///  Get the child windows of this EveInvWindow
	    /// </summary>
	    /// <returns></returns>
	    public List<IEveInvChildWindow> GetChildren()
		{
			return _children ?? (_children = Util.GetListFromMethod<IEveInvChildWindow>(this, "GetChildren", "eveinvchildwindow"));
		}

        #region Members
	    /// <summary>
	    /// The ID of the ship or other object that this window belongs to, i.e. EVEWindow[MyShipCargo].ItemID will be your ship ID
	    /// </summary>
	    public Int64 ItemID
	    {
	        get { return this.GetInt64("ItemID"); }
	    }

	    /// <summary>
	    /// The capacity of the container represented by this EVEWindow.
	    /// </summary>
	    public double Capacity
	    {
	        get { return this.GetDouble("Capacity"); }
	    }

	    /// <summary>
	    /// The used capacity of the container represented by this EVEWindow.
	    /// </summary>
	    public double UsedCapacity
	    {
	        get { return this.GetDouble("UsedCapacity"); }
	    }

        /// <summary>
        /// The used LocationFlag of the container represented by this EVEWindow.
        /// </summary>
        public string LocationFlag
        {
	        get { return this.GetString("LocationFlag"); }
	    }

        /// <summary>
        /// The used LocationFlagID of the container represented by this EVEWindow.
        /// </summary>
        public int LocationFlagID
        {
	        get { return this.GetInt("LocationFlagID"); }
	    }

        /// <summary>
        /// The used IsInRange of the container represented by this EVEWindow.
        /// </summary>
        public bool IsInRange
        {
	        get { return this.GetBool("IsInRange"); }
	    }

        /// <summary>
        /// The used HasCapacity of the container represented by this EVEWindow.
        /// </summary>
        public bool HasCapacity
        {
	        get { return this.GetBool("HasCapacity"); }
	    }
        #endregion



    }
}
