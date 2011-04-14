using System;
using System.Collections.Generic;
using System.Text;

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
			get
			{
				return GetMember<double>("BasePrice");
			}
		}

		/// <summary>
		/// Wrapper for the Capacity member of the item type.
		/// </summary>
		public double Capacity
		{
			get
			{
				return GetMember<double>("Capacity");
			}
		}

		/// <summary>
		/// Wrapper for the CargoCapacity member of the item type.
		/// </summary>
		public double CargoCapacity
		{
			get
			{
				return GetMember<double>("CargoCapacity");
			}
		}

		/// <summary>
		/// Wrapper for the GetCargo member of the item type.
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
			get
			{
				return GetMember<double>("UsedCargoCapacity");
			}
		}

		/// <summary>
		/// Wrapper for the Category member of the item type.
		/// </summary>
		public string Category
		{
			get
			{
				return GetMember<string>("Category");
			}
		}

		/// <summary>
		/// Wrapper for the CategoryID member of the item type.
		/// </summary>
		public int CategoryID
		{
			get
			{
				return GetMember<int>("CategoryID");
			}
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
			get
			{
				return GetMember<string>("Description");
			}
		}

		/// <summary>
		/// Wrapper for the GraphicID member of the item type.
		/// </summary>
		public int GraphicID
		{
			get
			{
				return GetMember<int>("GraphicID");
			}
		}

		/// <summary>
		/// Wrapper for the Group member of the item type.
		/// </summary>
		public string Group
		{
			get
			{
				return GetMember<string>("Group");
			}
		}

		/// <summary>
		/// Wrapper for the GroupID member of the item type.
		/// </summary>
		public int GroupID
		{
			get
			{
				return GetMember<int>("GroupID");
			}
		}

		/// <summary>
		/// Wrapper for the ID member of the item type.
		/// </summary>
		public Int64 ID
		{
			get
			{
				Tracing.SendCallback("Item.ID");
				return GetMember<Int64>("ID");
			}
		}

		/// <summary>
		/// This returns TRUE if the item is a 'repackable' type AND if it's currently 
		/// in a state to be repackaged. However, it does not make sure that the item 
		/// is in a location where it CAN be repackaged (ie, your hangar).
		/// </summary>
		public bool IsRepackable
		{
			get
			{
				return GetMember<bool>("IsRepackable");
			}
		}

		/// <summary>
		/// Example: "DroneBay"
		/// </summary>
		public string Location
		{
			get
			{
				return GetMember<string>("Location");
			}
		}

		/// <summary>
		/// Wrapper for the LocationID member of the item type.
		/// </summary>
		public int LocationID
		{
			get
			{
				return GetMember<int>("LocationID");
			}
		}

		/// <summary>
		/// Example: "Amadeus' Harbinger"
		/// </summary>
		public string MacroLocation
		{
			get
			{
				return GetMember<string>("MacroLocation");
			}
		}

		/// <summary>
		/// Wrapper for the MacroLocationID member of the item type.
		/// </summary>
		public int MacroLocationID
		{
			get
			{
				return GetMember<int>("MacroLocationID");
			}
		}

		/// <summary>
		/// Wrapper for the MarketGroupID member of the item type.
		/// </summary>
		public int MarketGroupID
		{
			get
			{
				return GetMember<int>("MarketGroupID");
			}
		}

		/// <summary>
		/// Wrapper for the MaxFlightTime member of the item type.
		/// </summary>
		public double MaxFlightTime
		{
			get
			{
				return GetMember<double>("MaxFlightTime");
			}
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the item type.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				return GetMember<double>("MaxVelocity");
			}
		}

		/// <summary>
		/// Wrapper for the Name member of the item type.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for the OwnerID member of the item type.
		/// </summary>
		public int OwnerID
		{
			get
			{
				return GetMember<int>("OwnerID");
			}
		}

		/// <summary>
		/// ie, "Units to Refine"
		/// </summary>
		public int PortionSize
		{
			get
			{
				return GetMember<int>("PortionSize");
			}
		}

		/// <summary>
		/// Wrapper for the Quantity member of the item type.
		/// </summary>
		public int Quantity
		{
			get
			{
				return GetMember<int>("Quantity");
			}
		}

		/// <summary>
		/// Wrapper for the RaceID member of the item type.
		/// </summary>
		public int RaceID
		{
			get
			{
				return GetMember<int>("RaceID");
			}
		}

		/// <summary>
		/// Wrapper for the Radius member of the item type.
		/// </summary>
		public double Radius
		{
			get
			{
				return GetMember<double>("Radius");
			}
		}

		/// <summary>
		/// Wrapper for the Slot member of the item type.
		/// </summary>
		public string Slot
		{
			get
			{
				return GetMember<string>("Slot");
			}
		}

		/// <summary>
		/// Wrapper for the SlotID member of the item type.
		/// </summary>
		public int SlotID
		{
			get
			{
				return GetMember<int>("SlotID");
			}
		}

		/// <summary>
		/// Wrapper for the Type member of the item type.
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

		/// <summary>
		/// Wrapper for the TypeID member of the item type.
		/// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

		/// <summary>
		/// Wrapper for the Volume member of the item type.
		/// </summary>
		public double Volume
		{
			get
			{
				return GetMember<double>("Volume");
			}
		}

		/// <summary>
		/// Wrapper for the GivenName member of the item type.
		/// </summary>
		public string GivenName
		{
			get
			{
				return GetMember<string>("GivenName");
			}
		}

		#endregion

		#region Methods
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
