using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;



//* Added new DATATYPE: 'marketorder' (ie, "Market Order") with the following MEMBERS
//  1.  Price                                             (double type)
//  2.  InitialQuantity                                   (int type) 
//  3.  QuantityRemaining                                 (double type)
//  4.  MinQuantityToBuy                                  (int type)
//  5.  ID                                                (int64 type)
//  6.  TimeStampWhenIssued                               (uint64 type)
//  7.  DateWhenIssued                                    (string type)
//  8.  TimeWhenIssued                                    (string type)
//  9.  Duration                                          (int type)     [The max length of the order, in days]
//  10. StationID                                         (int type)     [Station where the order is located]
//  11. Station                                           (string type)
//  12. RegionID                                          (int type)     [Region where the order is located]
//  13. Region                                            (string type)
//  14. SolarSystemID                                     (int type)     [Solar System where the order is located]
//  15. SolarSystem                                       (string type)
//  16. Range                                             (int type)     [In Jumps, the range from which the item can be bought/sold]
//  17. Jumps                                             (int type)     [Jumps to the station where the order is located]
//  18. IsSellOrder                                       (bool type)
//  19. IsBuyOrder                                        (bool type)
//  20. TypeID                                            (int type)
//  21. Name                                              (string type)
//  (NOTE: The order's "Jumps" must be <= to the "Range" in order to buy/sell.)

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the marketorder type.
	/// </summary>
	public class MarketOrder : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// MarketOrder copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public MarketOrder(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members

		/// <summary>
		/// 1.  Price                                             (double type)
		/// </summary>
		public double Price
		{
			get { return this.GetDouble("Price"); }
		}
		/// <summary>
		///  2.  InitialQuantity                                   (int type) 
		/// </summary>
		public int InitialQuantity
		{
			get { return this.GetInt("InitialQuantity"); }
		}
		/// <summary>
		///  3.  QuantityRemaining                                 (double type)
		/// </summary>
		public double QuantityRemaining
		{
			get { return this.GetDouble("QuantityRemaining"); }
		}
		/// <summary>
		///  4.  MinQuantityToBuy                                  (int type)
		/// </summary>
		public int MinQuantityToBuy
		{
			get { return this.GetInt("MinQuantityToBuy"); }
		}
		/// <summary>
		///  5.  ID                                                (int type)
		/// </summary>
		public Int64 ID
		{
			get { return this.GetInt64("ID"); }
		}
		/// <summary>
		///  6.  TimeStampWhenIssued                               (uint64 type)
		/// </summary>
		public UInt64 TimeStampWhenIssued
		{
			get { return this.GetUInt64("TimeStampWhenIssued"); }
		}
		/// <summary>
		///  7.  DateWhenIssued                                    (string type)
		/// </summary>
		public string DateWhenIssued
		{
			get { return this.GetString("DateWhenIssued"); }
		}
		/// <summary>
		///  8.  TimeWhenIssued                                    (string type)
		/// </summary>
		public string TimeWhenIssued
		{
			get { return this.GetString("TimeWhenIssued"); }
		}
		/// <summary>
		///  9.  Duration                                          (int type)     [The max length of the order, in days]
		/// </summary>
		public Int64 Duration
		{
			get { return this.GetInt64("Duration"); }
		}
		/// <summary>
		///  10. StationID                                         (int type)     [Station where the order is located]
		/// </summary>
		public Int64 StationID
		{
			get { return this.GetInt64("StationID"); }
		}
		/// <summary>
		///  11. Station                                           (string type)
		/// </summary>
		public string Station
		{
			get { return this.GetString("Station"); }
		}
		/// <summary>
		///  12. RegionID                                          (int type)     [Region where the order is located]
		/// </summary>
		public Int64 RegionID
		{
			get { return this.GetInt64("RegionID"); }
		}
		/// <summary>
		///  13. Region                                            (string type)
		/// </summary>
		public string Region
		{
			get { return this.GetString("Region"); }
		}
		/// <summary>
		///  14. SolarSystemID                                     (int type)     [Solar System where the order is located]
		/// </summary>
		public Int64 SolarSystemID
		{
			get { return this.GetInt64("SolarSystemID"); }
		}
		/// <summary>
		///  15. SolarSystem                                       (string type)
		/// </summary>
		public string SolarSystem
		{
			get { return this.GetString("SolarSystem"); }
		}
		/// <summary>
		///  16. Range                                             (int type)    
		/// </summary>
		public Int64 Range
		{
			get { return this.GetInt64("Range"); }
		}
		/// <summary>
		///  17. Jumps                                             (int type)     [Jumps to the station where the order is located]
		///  (NOTE: The order's "Jumps" must be less than or equal to the "Range" in order to buy/sell.)
		/// </summary>
		public int Jumps
		{
			get { return this.GetInt("Jumps"); }
		}
		/// <summary>
		///  18. IsSellOrder                                       (bool type)
		/// </summary>
		public bool IsSellOrder
		{
			get { return this.GetBool("IsSellOrder"); }
		}
		/// <summary>
		///  19. IsBuyOrder                                        (bool type)  
		/// </summary>
		public bool IsBuyOrder
		{
			get { return this.GetBool("IsBuyOrder"); }
		}
		/// <summary>
		///  20. TypeID                                            (int type)
		/// </summary>
		public Int64 TypeID
		{
			get { return this.GetInt64("TypeID"); }
		}
		/// <summary>
		///  21. Name                                              (string type)
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

        public bool IsContraband
        {
            get { return this.GetBool("IsContraband"); }
        }

        public bool IsContrabandForFaction(int FactionID)
        {
            return this.GetBool("IsContraband", FactionID.ToString(CultureInfo.CurrentCulture));
        }
		#endregion

		#region Methods
		// there are no methods at the moment
		#endregion
	}
}
