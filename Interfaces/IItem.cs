using System;
using System.Collections.Generic;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    /// <summary>
    /// Wrapper for the Item datatype.
    /// </summary>
    public interface IItem : ILSObject, IItemInfo
    {
        /// <summary>
        /// Wrapper for the CargoCapacity member of the item type.
        /// </summary>
        double CargoCapacity { get; }

        /// <summary>
        /// Wrapper for the UsedCargoCapacity member of the item type.
        /// </summary>
        double UsedCargoCapacity { get; }

        /// <summary>
        /// Wrapper for the CategoryType member of the item type.
        /// </summary>
        CategoryType CategoryType { get; }

        /// <summary>
        /// Basic, STandard, Bronze, Platinum, etc. When opening the insurance window, call IsInsured != null to verify
        /// it has loaded the insurance records before attempting to validate insurance.
        /// </summary>
        string InsuranceLevel { get; }

        /// <summary>
        /// Ships only, CAN return NULL if insurance window has not fully loaded yet
        /// </summary>
        bool? IsInsured { get; }

        /// <summary>
        /// This returns TRUE if the item is a 'repackable' type AND if it's currently 
        /// in a state to be repackaged. However, it does not make sure that the item 
        /// is in a location where it CAN be repackaged (ie, your hangar).
        /// </summary>
        bool IsRepackable { get; }

        /// <summary>
        /// Example: "DroneBay"
        /// </summary>
        string Location { get; }

        /// <summary>
        /// Wrapper for the LocationID member of the item type.
        /// </summary>
        long LocationID { get; }

        /// <summary>
        /// Example: "Amadeus' Harbinger"
        /// </summary>
        string MacroLocation { get; }

        /// <summary>
        /// Wrapper for the MacroLocationID member of the item type.
        /// </summary>
        int MacroLocationID { get; }

        /// <summary>
        /// Wrapper for the MaxFlightTime member of the item type.
        /// </summary>
        double MaxFlightTime { get; }

        /// <summary>
        /// Wrapper for the MaxVelocity member of the item type.
        /// </summary>
        double MaxVelocity { get; }

        /// <summary>
        /// Wrapper for the Name member of the item type.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Wrapper for the OwnerID member of the item type.
        /// </summary>
        int OwnerID { get; }

        /// <summary>
        /// Wrapper for the Quantity member of the item type.
        /// </summary>
        int Quantity { get; }

        /// <summary>
        /// Wrapper for the Slot member of the item type.
        /// </summary>
        string Slot { get; }

        /// <summary>
        /// Wrapper for the SlotID member of the item type.
        /// </summary>
        int SlotID { get; }

        /// <summary>
        /// Wrapper for the GivenName member of the item type.
        /// </summary>
        string GivenName { get; }

        /// <summary>
        /// Gets the EM damage.
        /// </summary>
        double EMDamage { get; }

        /// <summary>
        /// Gets the explosive damage.
        /// </summary>
        double ExplosiveDamage { get; }

        /// <summary>
        /// Gets the kinetic damage.
        /// </summary>
        double KineticDamage { get; }

        /// <summary>
        /// Gets the thermal damage.
        /// </summary>
        double ThermalDamage { get; }

        double ExplosionVelocity { get; }
        double ExplosionRadius { get; }

        /// <summary>
        /// Wrapper for the GetCargo method of the item type.
        /// </summary>
        /// <returns></returns>
        List<Item> GetCargo();

        bool IsContrabandForFaction(int FactionID);
        void ApplyPilotLicense();
        void AssembleShip();
        void AssembleContainer();
        void ConsumeBooster();
        void InjectSkill();

        /// <summary>
        /// Wrapper for the Jettison method of the item type.
        /// </summary>
        /// <returns></returns>
        bool Jettison();

        /// <summary>
        /// Drones only.
        /// </summary>
        /// <returns></returns>
        bool Launch();

        /// <summary>
        /// Select this ship to be your active ship.  The ship
        /// must be in your hanger (ie. from Station.GetHangerShips())
        /// </summary>
        bool MakeActive();

        void PluginImplant();

        /// <summary>
        /// The "Repackage" METHOD of the 'item' datatype is now fully 
        /// automated.  Please be sure that if you're doing multiple 
        /// repackagings, that you place at least a 'wait 20' or 'wait 30' 
        /// between repackages in order to allow isxeve to properly accept 
        /// the dialog boxes before moving on.
        /// </summary>
        bool Repackage();

        /// <summary>
        /// Wrapper for the FitToActiveShip method of the item type.
        /// </summary>
        /// <returns></returns>
        bool FitToActiveShip();

        /// <summary>
        /// Wrapper for the TrainSkill method of the item type.
        /// </summary>
        /// <returns></returns>
        bool TrainSkill();

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
        bool PlaceSellOrder(double price, int quantity, int duration);

        /// <summary>
        /// Wrapper for the Open method of the item type.
        /// </summary>
        /// <returns></returns>
        bool Open();

        /// <summary>
        /// Wrapper for the Close method of the item type.
        /// </summary>
        /// <returns></returns>
        bool Close();

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="destinationEntityID"></param>
        /// <param name="destinationName"></param>
        /// <returns></returns>
        bool MoveTo(Int64 ToLocationID, string destinationName);

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="ToLocationEntityID"></param>
        /// <param name="destinationName"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        bool MoveTo(Int64 ToLocationID, string destinationName, int quantity);

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="ToLocationEntityID"></param>
        /// <param name="destinationName"></param>
        /// <param name="quantity"></param>
        /// <param name="corporateFolderNumber"></param>
        /// <returns></returns>
        bool MoveTo(Int64 ToLocationID, string destinationName, int quantity, int corporateFolderNumber);

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
        /// <param name="ToDestinationName"></param>
        /// <returns></returns>
        bool MoveTo(string ToLocationName, string ToDestinationName);

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
        /// <param name="destinationName"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        bool MoveTo(string ToLocationName, string destinationName, int quantity);

        /// <summary>
        /// Wrapper for the MoveTo method of the item type.
        /// </summary>
        /// <param name="ToLocationName">'MyShip', 'MyStationHangar', or 'MyStationCorporateHangar'</param>
        /// <param name="destinationName"></param>
        /// <param name="quantity"></param>
        /// <param name="corporateFolderNumber"></param>
        /// <returns></returns>
        bool MoveTo(string ToLocationName, string destinationName, int quantity, int corporateFolderNumber);

        List<int> GetContrabandFactions();
    }
}