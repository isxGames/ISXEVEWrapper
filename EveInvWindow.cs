using System;
using System.Collections.Generic;
using LavishScriptAPI;
using Extensions;

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

		/// <summary>
		/// Determine if a child inventory window exists
		/// </summary>
		/// <param name="name">Name of the child inventory window to be checked for</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public bool ChildWindowExists(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetBoolFromLSO("ChildWindowExists", name);
			return this.GetBoolFromLSO("ChildWindowExists", name, specificLocation);
		}

		/// <summary>
		/// Determine if a child inventory window exists
		/// </summary>
		/// <param name="itemId">ID of the item or entity whose window is to be checked for</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public bool ChildWindowExists(Int64 itemId, string specificLocation  = null)
		{
			if (specificLocation == null)
				return this.GetBoolFromLSO("ChildWindowExists", itemId.ToString());
			return this.GetBoolFromLSO("ChildWindowExists", itemId.ToString(), specificLocation);
		}

		/// <summary>
		/// Get the capacity of a child inventory window
		/// </summary>
		/// <param name="name">Naem of the child inventory window to get the capacity of</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public double ChildCapacity(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetDoubleFromLSO("ChildCapacity", name);
			return this.GetDoubleFromLSO("ChildCapacity", name, specificLocation);
		}

		/// <summary>
		/// Get the capacity of a child inventory window
		/// </summary>
		/// <param name="itemId">ID of the item or entity to get the capacity of</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public double ChildCapacity(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetDoubleFromLSO("ChildCapacity", itemId.ToString());
			return this.GetDoubleFromLSO("ChildCapacity", itemId.ToString(), specificLocation);
		}

		/// <summary>
		/// Get the used capacity of a child inventory window
		/// </summary>
		/// <param name="name">Name of the child inventory window to get the used capacity of</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public double ChildUsedCapacity(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetDoubleFromLSO("ChildUsedCapacity", name);
			return this.GetDoubleFromLSO("ChildUsedCapacity", name, specificLocation);
		}

		/// <summary>
		/// Get the used capacity of a child inventory window
		/// </summary>
		/// <param name="itemId">ID of the item or entity to get the used capacity of</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public double ChildUsedCapacity(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetDoubleFromLSO("ChildUsedCapacity", itemId.ToString());
			return this.GetDoubleFromLSO("ChildUsedCapacity", itemId.ToString(), specificLocation);
		}

		/// <summary>
		/// Get the location flag of a child inventory window
		/// </summary>
		/// <param name="name">Name of the child inventory window to get the location flag for</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public string ChildWindowLocationFlag(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetStringFromLSO("ChildWindowLocationFlag", name);
			return this.GetStringFromLSO("ChildWindowLocationFlag", name, specificLocation);
		}

		/// <summary>
		/// Get the location flag of a child inventory window
		/// </summary>
		/// <param name="itemId">ID of the item's or entity's location to get the location flag for</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public string ChildWindowLocationFlag(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetStringFromLSO("ChildWindowLocationFlag", itemId.ToString());
			return this.GetStringFromLSO("ChildWindowLocationFlag", itemId.ToString(), specificLocation);
		}

		/// <summary>
		/// Get the location flag ID of a child inventory window
		/// </summary>
		/// <param name="name">Name of the child inventory window to get the location flag ID of</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public int ChildWindowLocationFlagId(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetIntFromLSO("ChildWindowLocationFlagID", name);
			return this.GetIntFromLSO("ChildWindowLocationFlagID", name, specificLocation);
		}

		/// <summary>
		/// Get the location flag ID of a child inventory window
		/// </summary>
		/// <param name="itemId">ID of the item or entity to grab the location flag ID for</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public int ChildWindowLocationFlagId(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return this.GetIntFromLSO("ChildWindowLocationFlagID", itemId.ToString());
			return this.GetIntFromLSO("ChildWindowLocationFlagID", itemId.ToString(), specificLocation);
		}

		/// <summary>
		/// Make a child window active
		/// </summary>
		/// <param name="name">Name of the child inventory window to be made active</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public bool MakeChildActive(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return ExecuteMethod("MakeChildActive", name);
			return ExecuteMethod("MakeChildActive", name, specificLocation);
		}

		/// <summary>
		/// Make a child window active
		/// </summary>
		/// <param name="itemId">Id of the entity or item whose window will be made active</param>
		/// <param name="specificLocation">Specific location of the child inventory window</param>
		/// <returns></returns>
		public bool MakeChildActive(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return ExecuteMethod("MakeChildActive", itemId.ToString());
			return ExecuteMethod("MakeChildActive", itemId.ToString(), specificLocation);
		}

		///<summary>
		/// Open a child window as a new EveInvWindow
		///</summary>
		///<param name="name">Name of the inventory window to be opened</param>
		///<param name="specificLocation">Specific location of the child inventory window</param>
		///<returns></returns>
		public bool OpenChildAsNewWindow(string name, string specificLocation = null)
		{
			if (specificLocation == null)
				return ExecuteMethod("OpenChildAsNewWindow", name);
			return ExecuteMethod("OpenChildAsNewWindow", name, specificLocation);
		}

		///<summary>
		/// Open a child window as a new EveInvWindow
		///</summary>
		///<param name="itemId">Id of the item or entity whose inventory window will be opened</param>
		///<param name="specificLocation">Specific location of the inventory</param>
		///<returns></returns>
		public bool OpenChildAsNewWindow(Int64 itemId, string specificLocation = null)
		{
			if (specificLocation == null)
				return ExecuteMethod("OpenChildAsNewWindow", itemId.ToString());
			return ExecuteMethod("OpenChildAsNewWindow", itemId.ToString(), specificLocation);
		}

		///<summary>
		/// Get the child windows of this EveInvWindow
		///</summary>
		///<param name="childNames">Names of any child windows with a name</param>
		///<param name="childItemIds">IDs of any child windows with an ID</param>
		///<returns></returns>
		public bool GetChildren(out List<string> childNames, out List<Int64> childItemIds)
		{
			using (var idxChildNames = LavishScript.Objects.NewObject("index:string"))
			using (var idxChildItemIds = LavishScript.Objects.NewObject("index:int64"))
			{
				var succeeded = ExecuteMethod("GetChildren", idxChildNames.GetLSReference(), idxChildItemIds.GetLSReference());

				if (!succeeded)
				{
					childNames = null;
					childItemIds = null;
					return false;
				}

				childNames = Util.IndexToList<string>(idxChildNames, "string");
				childItemIds = Util.IndexToList<Int64>(idxChildItemIds, "int64");
				return true;
			}
		}
	}
}
