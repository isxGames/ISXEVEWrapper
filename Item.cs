using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the item data type.
	/// </summary>
	public class Item : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Item copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Item(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the BasePrice member of the item type.
		/// </summary>
		public double BasePrice
		{
			get { return this.GetDoubleFromLSO("BasePrice"); }
		}

		/// <summary>
		/// Wrapper for the Capacity member of the item type.
		/// </summary>
		public double Capacity
		{
			get { return this.GetDoubleFromLSO("Capacity"); }
		}

		/// <summary>
		/// Wrapper for the CargoCapacity member of the item type.
		/// </summary>
		public double CargoCapacity
		{
			get { return this.GetDoubleFromLSO("CargoCapacity"); }
		}

		/// <summary>
		/// Wrapper for the GetCargo method of the item type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCargo()
		{
			return Util.GetListFromMethod<Item>(this, "GetCargo", "item");
		}

		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the item type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get { return this.GetDoubleFromLSO("UsedCargoCapacity"); }
		}

		/// <summary>
		/// Wrapper for the Category member of the item type.
		/// </summary>
		public string Category
		{
			get { return this.GetStringFromLSO("Category"); }
		}

		/// <summary>
		/// Wrapper for the CategoryID member of the item type.
		/// </summary>
		public int CategoryID
		{
			get { return this.GetIntFromLSO("CategoryID"); }
		}

		/// <summary>
		/// Wrapper for the CategoryType member of the item type.
		/// </summary>
		public CategoryType CategoryType
		{
			get
			{
				return (CategoryType)CategoryID;
			}
		}

		/// <summary>
		/// Wrapper for the Description member of the item type.
		/// </summary>
		public string Description
		{
			get { return this.GetStringFromLSO("Description"); }
		}

		/// <summary>
		/// Wrapper for the GraphicID member of the item type.
		/// </summary>
		public int GraphicID
		{
			get { return this.GetIntFromLSO("GraphicID"); }
		}

		/// <summary>
		/// Wrapper for the Group member of the item type.
		/// </summary>
		public string Group
		{
			get { return this.GetStringFromLSO("Group"); }
		}

		/// <summary>
		/// Wrapper for the GroupID member of the item type.
		/// </summary>
		public int GroupID
		{
			get { return this.GetIntFromLSO("GroupID"); }
		}

		/// <summary>
		/// Wrapper for the ID member of the item type.
		/// </summary>
		public Int64 ID
		{
			get
			{
				Tracing.SendCallback("Item.ID");
				return this.GetInt64FromLSO("ID");
			}
		}

        /// <summary>
        /// Basic, STandard, Bronze, Platinum, etc. When opening the insurance window, call IsInsured != null to verify
        /// it has loaded the insurance records before attempting to validate insurance.
        /// </summary>
	    public string InsuranceLevel
	    {
	        get { return this.GetStringFromLSO("InsuranceLevel"); }
	    }

        /// <summary>
        /// Ships only, CAN return NULL if insurance window has not fully loaded yet
        /// </summary>
	    public bool? IsInsured
	    {
            get 
            {
            	return this.GetNullableBoolFromLSO("IsInsured");
            }
	    }

		/// <summary>
		/// This returns TRUE if the item is a 'repackable' type AND if it's currently 
		/// in a state to be repackaged. However, it does not make sure that the item 
		/// is in a location where it CAN be repackaged (ie, your hangar).
		/// </summary>
		public bool IsRepackable
		{
			get { return this.GetBoolFromLSO("IsRepackable"); }
		}

		/// <summary>
		/// Example: "DroneBay"
		/// </summary>
		public string Location
		{
			get { return this.GetStringFromLSO("Location"); }
		}

		/// <summary>
		/// Wrapper for the LocationID member of the item type.
		/// </summary>
		public int LocationID
		{
			get { return this.GetIntFromLSO("LocationID"); }
		}

		/// <summary>
		/// Example: "Amadeus' Harbinger"
		/// </summary>
		public string MacroLocation
		{
			get { return this.GetStringFromLSO("MacroLocation"); }
		}

		/// <summary>
		/// Wrapper for the MacroLocationID member of the item type.
		/// </summary>
		public int MacroLocationID
		{
			get { return this.GetIntFromLSO("MacroLocationID"); }
		}

		/// <summary>
		/// Wrapper for the MarketGroupID member of the item type.
		/// </summary>
		public int MarketGroupID
		{
			get { return this.GetIntFromLSO("MarketGroupID"); }
		}

		/// <summary>
		/// Wrapper for the MaxFlightTime member of the item type.
		/// </summary>
		public double MaxFlightTime
		{
			get { return this.GetDoubleFromLSO("MaxFlightTime"); }
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the item type.
		/// </summary>
		public double MaxVelocity
		{
			get { return this.GetDoubleFromLSO("MaxVelocity"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the item type.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// Wrapper for the OwnerID member of the item type.
		/// </summary>
		public int OwnerID
		{
			get { return this.GetIntFromLSO("OwnerID"); }
		}

		/// <summary>
		/// ie, "Units to Refine"
		/// </summary>
		public int PortionSize
		{
			get { return this.GetIntFromLSO("PortionSize"); }
		}

		/// <summary>
		/// Wrapper for the Quantity member of the item type.
		/// </summary>
		public int Quantity
		{
			get { return this.GetIntFromLSO("Quantity"); }
		}

		/// <summary>
		/// Wrapper for the RaceID member of the item type.
		/// </summary>
		public int RaceID
		{
			get { return this.GetIntFromLSO("RaceID"); }
		}

		/// <summary>
		/// Wrapper for the Radius member of the item type.
		/// </summary>
		public double Radius
		{
			get { return this.GetDoubleFromLSO("Radius"); }
		}

		/// <summary>
		/// Wrapper for the Slot member of the item type.
		/// </summary>
		public string Slot
		{
			get { return this.GetStringFromLSO("Slot"); }
		}

		/// <summary>
		/// Wrapper for the SlotID member of the item type.
		/// </summary>
		public int SlotID
		{
			get { return this.GetIntFromLSO("SlotID"); }
		}

		/// <summary>
		/// Wrapper for the Type member of the item type.
		/// </summary>
		public string Type
		{
			get { return this.GetStringFromLSO("Type"); }
		}

		/// <summary>
		/// Wrapper for the TypeID member of the item type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetIntFromLSO("TypeID"); }
		}

		/// <summary>
		/// Wrapper for the Volume member of the item type.
		/// </summary>
		public double Volume
		{
			get { return this.GetDoubleFromLSO("Volume"); }
		}

		/// <summary>
		/// Wrapper for the GivenName member of the item type.
		/// </summary>
		public string GivenName
		{
			get { return this.GetStringFromLSO("GivenName"); }
		}

		#endregion

		#region Methods
        public void ApplyPilotLicense()
        {
            Tracing.SendCallback("Item.ApplyPilotLicense");
            ExecuteMethod("ApplyPilotLicense");
        }

        public void AssembleShip()
        {
            Tracing.SendCallback("Item.AssembleShip");
            ExecuteMethod("AssembleShip");
        }

        public void AssembleContainer()
        {
            Tracing.SendCallback("Item.AssembleContainer");
            ExecuteMethod("AssembleContainer");
        }

        public void ConsumeBooster()
        {
            Tracing.SendCallback("Item.ConsumeBooster");
            ExecuteMethod("ConsumeBooster");
        }

        public void InjectSkill()
        {
            Tracing.SendCallback("Item.InjectSkill");
            ExecuteMethod("InjectSkill");
        }

		/// <summary>
		/// Wrapper for the Jettison method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool Jettison()
		{
			Tracing.SendCallback("Item.Jettison");
			return ExecuteMethod("Jettison");
		}

		/// <summary>
		/// Move the entire stack into your ship
		/// </summary>
		public bool MoveToMyShip()
		{
			Tracing.SendCallback("Item.MoveToMyShip");
			return ExecuteMethod("MoveTo", "MyShip");
		}

		/// <summary>
		/// Wrapper for the MoveToMyShip method of the item type.
		/// </summary>
		/// <param name="Quantity"></param>
		/// <returns></returns>
		public bool MoveToMyShip(int Quantity)
		{
			Tracing.SendCallback("Item.MoveToMyShip", Quantity.ToString());
			return ExecuteMethod("MoveTo", "MyShip", Quantity.ToString());
		}

		/// <summary>
		/// Move the entire stack into your hanger
		/// </summary>
		public bool MoveToHangar()
		{
			Tracing.SendCallback("Item.MoveToHangar");
			return ExecuteMethod("MoveTo", "Hangar");
		}

		/// <summary>
		/// Wrapper for the MoveToHangar method of the item type.
		/// </summary>
		/// <param name="Quantity"></param>
		/// <returns></returns>
		public bool MoveToHangar(int Quantity)
		{
			Tracing.SendCallback("Item.MoveToHangar", Quantity.ToString());
			return ExecuteMethod("MoveTo", "Hangar", Quantity.ToString());
		}

		/// <summary>
		/// Move the entire stack into your Drone Bay
		/// </summary>
		public bool MoveToDroneBay()
		{
			Tracing.SendCallback("Item.MoveToDroneBay");
			return ExecuteMethod("MoveTo", "DroneBay");
		}

		/// <summary>
		/// Wrapper for the MoveToDroneBay method of the item type.
		/// </summary>
		/// <param name="Quantity"></param>
		/// <returns></returns>
		public bool MoveToDroneBay(int Quantity)
		{
			Tracing.SendCallback("Item.MoveToDroneBay", Quantity.ToString());
			return ExecuteMethod("MoveTo", "DroneBay", Quantity.ToString());
		}

		/// <summary>
		/// Moves the whole stack into Corporate Folder 1
		/// </summary>
		public bool MoveToCorporationHanger()
		{
			Tracing.SendCallback("Item.MoveToCorpHangar");
			return ExecuteMethod("MoveTo", "Corporation Hangar");
		}

		/// <summary>
		/// Moves the specified quantity into Corporate Folder 1
		/// </summary>
		public bool MoveToCorporationHanger(int Quantity)
		{
			Tracing.SendCallback("Item.MoveToCorpHangar", Quantity.ToString());
			return ExecuteMethod("MoveTo", "Corporation Hangar", Quantity.ToString());
		}

		/// <summary>
		/// Moves the specified quantity into the specified corporate folder.
		/// </summary>
		/// <param name="Quantity"></param>
		/// <param name="FolderID"></param>
		/// <returns></returns>
		public bool MoveToCorporationHanger(int Quantity, int FolderID)
		{
			Tracing.SendCallback("Item.MoveToCorpHangar", Quantity, FolderID);
			return ExecuteMethod("MoveTo", "Corporation Hangar", Quantity.ToString(),
				"Corporate Folder " + FolderID.ToString());
		}

		/// <summary>
		/// Move the entire stack into whatever has the ID you specify
		/// </summary>
		public bool MoveTo(Int64 ID)
		{
			Tracing.SendCallback("Item.MoveTo", ID.ToString());
			return ExecuteMethod("MoveTo", ID.ToString());
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ID"></param>
		/// <param name="Quantity"></param>
		/// <returns></returns>
		public bool MoveTo(Int64 ID, int Quantity)
		{
			Tracing.SendCallback("Item.MoveTo", ID, Quantity);
			return ExecuteMethod("MoveTo", ID.ToString(), Quantity.ToString());
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ID"></param>
		/// <param name="Quantity"></param>
		/// <param name="CorporateHangarFolder"></param>
		/// <returns></returns>
		public bool MoveTo(Int64 ID, int Quantity, int CorporateHangarFolder)
		{
			Tracing.SendCallback("Item.MoveTo", ID, Quantity, CorporateHangarFolder);
			return ExecuteMethod("MoveTo", ID.ToString(), Quantity.ToString(),
				String.Format("Corporation Folder {0}", CorporateHangarFolder));
		}

		/// <summary>
		/// Drones only.
		/// </summary>
		/// <returns></returns>
		public bool Launch()
		{
			Tracing.SendCallback("Item.Launch");
			return ExecuteMethod("Launch");
		}

		/// <summary>
		/// Select this ship to be your active ship.  The ship
		/// must be in your hanger (ie. from Station.GetHangerShips())
		/// </summary>
		public bool MakeActive()
		{
			Tracing.SendCallback("Item.MakeActive");
			return ExecuteMethod("MakeActive");
		}

        public void PluginImplant()
        {
            Tracing.SendCallback("Item.PluginImplant");
            ExecuteMethod("PluginImplant");
        }

		/// <summary>
		/// The "Repackage" METHOD of the 'item' datatype is now fully 
		/// automated.  Please be sure that if you're doing multiple 
		/// repackagings, that you place at least a 'wait 20' or 'wait 30' 
		/// between repackages in order to allow isxeve to properly accept 
		/// the dialog boxes before moving on.
		/// </summary>
		public bool Repackage()
		{
			Tracing.SendCallback("Item.Repackage");
			return ExecuteMethod("Repackage");
		}

		/// <summary>
		/// Wrapper for the FitToActiveShip method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool FitToActiveShip()
		{
			Tracing.SendCallback("Item.FitToActiveShip");
			return ExecuteMethod("FitToActiveShip");
		}

		/// <summary>
		/// Wrapper for the TrainSkill method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool TrainSkill()
		{
			Tracing.SendCallback("Item.TrainSkill", string.Empty);
			return ExecuteMethod("TrainSkill");
		}

		/// <summary>
		///  1. PlaceSellOrder[Price#, Quantity#, Duration]
		///     ~ Duration is in DAYS
		///     ~ NOTE: If you place a sell order that already matches a buy order that's on the market, it will act as an 'instant' sell order'
		///     ~ NOTE: As of now, you may only sell items within a station (and they will sell from THAT station) with ISXEVE.
		///     ~ NOTE: As of now, ISXEVE does not take into account your current/maximum number of sell orders.  Your script must handle that.
		/// </summary>
		/// <param name="price">The sell price</param>
		/// <param name="quantity">The ammount to sell</param>
		/// <param name="duration">The duration in days</param>
		/// <returns></returns>
		public bool PlaceSellOrder(double price, int quantity, int duration)
		{
			Tracing.SendCallback("Item.PlaceSellOrder", price, quantity, duration);
			return ExecuteMethod("PlaceSellOrder",
				price.ToString(),
				quantity.ToString(),
				duration.ToString());
		}

		/// <summary>
		/// Wrapper for the Open method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool Open()
		{
			Tracing.SendCallback("Item.Open");
			return ExecuteMethod("Open");
		}

		/// <summary>
		/// Wrapper for the Close method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool Close()
		{
			Tracing.SendCallback("Item.Close");
			return ExecuteMethod("Close");
		}
		#endregion
	}
}
