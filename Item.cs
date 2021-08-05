using EVE.ISXEVE.Extensions;
using EVE.ISXEVE.Interfaces;
using LavishScriptAPI;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the item data type.
    /// </summary>
    public class Item : ItemInfo, IItem
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
		/// Wrapper for the CargoCapacity member of the item type.
		/// </summary>
		public double CargoCapacity
		{
			get { return this.GetDouble("CargoCapacity"); }
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
			get { return this.GetDouble("UsedCargoCapacity"); }
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
		/// Basic, STandard, Bronze, Platinum, etc. When opening the insurance window, call IsInsured != null to verify
		/// it has loaded the insurance records before attempting to validate insurance.
		/// </summary>
		public string InsuranceLevel
		{
			get { return this.GetString("InsuranceLevel"); }
		}

		/// <summary>
		/// Ships only, CAN return NULL if insurance window has not fully loaded yet
		/// </summary>
		public bool? IsInsured
		{
			get 
			{
				return this.GetNullableBool("IsInsured");
			}
		}

		/// <summary>
		/// This returns TRUE if the item is a 'repackable' type AND if it's currently 
		/// in a state to be repackaged. However, it does not make sure that the item 
		/// is in a location where it CAN be repackaged (ie, your hangar).
		/// </summary>
		public bool IsRepackable
		{
			get { return this.GetBool("IsRepackable"); }
		}

		/// <summary>
		/// Example: "DroneBay"
		/// </summary>
		public string Location
		{
			get { return this.GetString("Location"); }
		}

		/// <summary>
		/// Wrapper for the LocationID member of the item type.
		/// </summary>
		public long LocationID
		{
			get { return this.GetInt64("LocationID"); }
		}

		/// <summary>
		/// Example: "Amadeus' Harbinger"
		/// </summary>
		public string MacroLocation
		{
			get { return this.GetString("MacroLocation"); }
		}

		/// <summary>
		/// Wrapper for the MacroLocationID member of the item type.
		/// </summary>
		public int MacroLocationID
		{
			get { return this.GetInt("MacroLocationID"); }
		}

		/// <summary>
		/// Wrapper for the MaxFlightTime member of the item type.
		/// </summary>
		public double MaxFlightTime
		{
			get { return this.GetDouble("MaxFlightTime"); }
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the item type.
		/// </summary>
		public double MaxVelocity
		{
			get { return this.GetDouble("MaxVelocity"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the item type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// Wrapper for the OwnerID member of the item type.
		/// </summary>
		public int OwnerID
		{
			get { return this.GetInt("OwnerID"); }
		}

		/// <summary>
		/// Wrapper for the Quantity member of the item type.
		/// </summary>
		public int Quantity
		{
			get { return this.GetInt("Quantity"); }
		}

		/// <summary>
		/// Wrapper for the Slot member of the item type.
		/// For corporate hangar divisions 2-7, this is 'CorpSAG#', where # is 2-7.
		/// For corporate hangar division 1, this is 'Hangar'.
		/// </summary>
		public string Slot
		{
			get { return this.GetString("Slot"); }
		}

		/// <summary>
		/// Wrapper for the SlotID member of the item type.
		/// For corporate hangar divisions 2-7, this is 116-121, respectively.
		/// For corporate hangar division 1, this is 4.
		/// </summary>
		public int SlotID
		{
			get { return this.GetInt("SlotID"); }
		}

		/// <summary>
		/// Wrapper for the GivenName member of the item type.
		/// </summary>
		public string GivenName
		{
			get { return this.GetString("GivenName"); }
		}

		public bool IsContrabandForFaction(int FactionID)
		{
			return this.GetBool("IsContraband", FactionID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Gets the EM damage.
		/// </summary>
		public double EMDamage
		{
			get { return this.GetDouble("EMDamage"); }
		}

		/// <summary>
		/// Gets the explosive damage.
		/// </summary>
		public double ExplosiveDamage
		{
			get { return this.GetDouble("ExplosiveDamage"); }
		}

		/// <summary>
		/// Gets the kinetic damage.
		/// </summary>
		public double KineticDamage
		{
			get { return this.GetDouble("KineticDamage"); }
		}

		/// <summary>
		/// Gets the thermal damage.
		/// </summary>
		public double ThermalDamage
		{
			get { return this.GetDouble("ThermalDamage"); }
		}

		public double ExplosionVelocity
		{
			get { return this.GetDouble("ExplosionVelocity"); }
		}

		public double ExplosionRadius
		{
			get { return this.GetDouble("ExplosionRadius"); }
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
		/// Drones only.
		/// </summary>
		/// <returns></returns>
		[Obsolete("The 'Launch' method of the item datatype is deprecated.   The 'LaunchDrones' method should now be used instead.")]
		public bool Launch()
		{
			Tracing.SendCallback("Item.Launch");
			return ExecuteMethod("Launch");
		}

		/// <summary>
		/// For things such as MTUs.
		/// </summary>
		/// <returns></returns>
		public bool LaunchForSelf()
		{
			Tracing.SendCallback("Item.LaunchForSelf");
			return ExecuteMethod("LaunchForSelf");
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
		/// Wrapper for the Refine method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool Refine()
		{
			Tracing.SendCallback("Item.Refine");
			return ExecuteMethod("Refine");
		}

		/// <summary>
		/// Wrapper for the Reprocess method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool Reprocess()
		{
			Tracing.SendCallback("Item.Reprocess");
			return ExecuteMethod("Reprocess");
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
		/// Wrapper for the AddToSellOrder method of the item type.
		/// </summary>
		/// <returns></returns>
		public bool AddToSellOrder()
		{
			Tracing.SendCallback("Item.AddToSellOrder", string.Empty);
			return ExecuteMethod("AddToSellOrder");
		}

		///// <summary>
		/////  *** REMOVED  on January 22, 2015
		/////  1. PlaceSellOrder[Price#, Quantity#, Duration]
		/////     ~ Duration is in DAYS
		/////     ~ NOTE: If you place a sell order that already matches a buy order that's on the market, it will act as an 'instant' sell order'
		/////     ~ NOTE: As of now, you may only sell items within a station (and they will sell from THAT station) with ISXEVE.
		/////     ~ NOTE: As of now, ISXEVE does not take into account your current/maximum number of sell orders.  Your script must handle that.
		///// </summary>
		///// <param name="price">The sell price</param>
		///// <param name="quantity">The ammount to sell</param>
		///// <param name="duration">The duration in days</param>
		///// <returns></returns>
		//public bool AddToSellOrder(double price, int quantity, int duration)
		//{
		//	Tracing.SendCallback("Item.PlaceSellOrder", price, quantity, duration);
		//	return ExecuteMethod("PlaceSellOrder",
		//		price.ToString(CultureInfo.CurrentCulture),
		//		quantity.ToString(CultureInfo.CurrentCulture),
		//		duration.ToString(CultureInfo.CurrentCulture));
		//}

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

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationID"></param>
		/// <param name="destinationName"></param>
		/// <returns></returns>
		public bool MoveTo(Int64 ToLocationID, string destinationName)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationID, destinationName);

			return ExecuteMethod("MoveTo", ToLocationID.ToString(CultureInfo.CurrentCulture), destinationName);
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationID"></param>
		/// <param name="destinationName"></param>
		/// <param name="quantity"></param>
		/// <returns></returns>
		public bool MoveTo(Int64 ToLocationID, string destinationName, int quantity)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationID, destinationName, quantity);

			return ExecuteMethod("MoveTo", ToLocationID.ToString(CultureInfo.CurrentCulture), destinationName, quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationID"></param>
		/// <param name="destinationName"></param>
		/// <param name="quantity"></param>
		/// <param name="corporateFolderNumber"></param>
		/// <returns></returns>
		public bool MoveTo(Int64 ToLocationID, string destinationName, int quantity, int corporateFolderNumber)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationID, destinationName, quantity, corporateFolderNumber);

			return ExecuteMethod("MoveTo", ToLocationID.ToString(CultureInfo.CurrentCulture), destinationName,
				quantity.ToString(CultureInfo.CurrentCulture), string.Format(CultureInfo.CurrentCulture, "Corporation Folder {0}", corporateFolderNumber));
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
		/// <param name="ToDestinationName"></param>
		/// <returns></returns>
		public bool MoveTo(string ToLocationName, string ToDestinationName)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationName, ToDestinationName);

			return ExecuteMethod("MoveTo", ToLocationName, ToDestinationName);
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
		/// <param name="destinationName"></param>
		/// <param name="quantity"></param>
		/// <returns></returns>
		public bool MoveTo(string ToLocationName, string destinationName, int quantity)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationName, destinationName, quantity);

			return ExecuteMethod("MoveTo", ToLocationName, destinationName, quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the MoveTo method of the item type.
		/// </summary>
		/// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
		/// <param name="destinationName"></param>
		/// <param name="quantity"></param>
		/// <param name="corporateFolderNumber"></param>
		/// <returns></returns>
		public bool MoveTo(string ToLocationName, string destinationName, int quantity, int corporateFolderNumber)
		{
			Tracing.SendCallback("Item.MoveTo", ToLocationName, destinationName, quantity, corporateFolderNumber);

			return ExecuteMethod("MoveTo", ToLocationName, destinationName,
				quantity.ToString(CultureInfo.CurrentCulture), string.Format(CultureInfo.CurrentCulture, "Corporation Folder {0}", corporateFolderNumber));
		}

		public List<int> GetContrabandFactions()
		{
			return Util.GetListFromMethod<int>(this, "GetContrabandFactions", "int");
		}

		//Opens the repair window 
		public bool GetRepairQuote()
		{
			return ExecuteMethod("GetRepairQuote");
		}

		#endregion
	}

	public enum ToDestinationNames
	{
		/// <summary>
		/// The traditional cargo hold
		/// </summary>
		CargoHold,
		DroneBay,
		/// <summary>
		/// Will work on your ship as well as the coproration hangars of a capital ship or POS
		/// </summary>
		CorpHangars,
		/// <summary>
		/// Will work on your ship as well as the maintenance bay of a capital ship
		/// </summary>
		MaintenanceBay,
		OreHold,
		FuelBay,
		GasHold,
		MineralHold,
		SalvageHold,
		IndustrialShipHold,
		AmmoHold,
		StationCorporateHangar,
		Hangar
	}

	public enum ToLocationNames
	{
		MyShip,
		MyStationHangar,
		MyStationCorporateHangar
	}
}
