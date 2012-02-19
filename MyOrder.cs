using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;



//* Added new DATATYPE: 'myorder' (ie, "My Orders" tab) with the following MEMBERS:
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
//  16. Range                                             (int type)    
//  17. TypeID                                            (int type)
//  18. Name                                              (string type)
//  19. IsContraband                                      (bool type)
//  20. IsCorp                                            (bool type)
//  21. IsSellOrder                                       (bool type)
//  22. IsBuyOrder                                        (bool type)  
//* Added the following METHODS to the 'myorder' datatype:
//  1. Cancel 
//  2. Modify[#]                   {# = new price of the item in isk}

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the myorder type.
	/// </summary>
	public class MyOrder : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// MyOrder copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public MyOrder(LavishScriptObject Obj)
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
			get { return this.GetDoubleFromLSO("Price"); }
		}
		/// <summary>
		///  2.  InitialQuantity                                   (int type) 
		/// </summary>
		public int InitialQuantity
		{
			get { return this.GetIntFromLSO("InitialQuantity"); }
		}
		/// <summary>
		///  3.  QuantityRemaining                                 (double type)
		/// </summary>
		public double QuantityRemaining
		{
			get { return this.GetDoubleFromLSO("QuantityRemaining"); }
		}
		/// <summary>
		///  4.  MinQuantityToBuy                                  (int type)
		/// </summary>
		public int MinQuantityToBuy
		{
			get { return this.GetIntFromLSO("MinQuantityToBuy"); }
		}
		/// <summary>
		///  5.  ID                                                (int type)
		/// </summary>
		public Int64 ID
		{
			get { return this.GetInt64FromLSO("ID"); }
		}
		/// <summary>
		///  6.  TimeStampWhenIssued                               (int64 type)
		/// </summary>
		public Int64 TimeStampWhenIssued
		{
			get { return this.GetInt64FromLSO("TimeStampWhenIssued"); }
		}
		/// <summary>
		///  7.  DateWhenIssued                                    (string type)
		/// </summary>
		public string DateWhenIssued
		{
			get { return this.GetStringFromLSO("DateWhenIssued"); }
		}
		/// <summary>
		///  8.  TimeWhenIssued                                    (string type)
		/// </summary>
		public string TimeWhenIssued
		{
			get { return this.GetStringFromLSO("TimeWhenIssued"); }
		}
		/// <summary>
		///  9.  Duration                                          (int type)     [The max length of the order, in days]
		/// </summary>
		public int Duration
		{
			get { return this.GetIntFromLSO("Duration"); }
		}
		/// <summary>
		///  10. StationID                                         (int type)     [Station where the order is located]
		/// </summary>
		public int StationID
		{
			get { return this.GetIntFromLSO("StationID"); }
		}
		/// <summary>
		///  11. Station                                           (string type)
		/// </summary>
		public string Station
		{
			get { return this.GetStringFromLSO("Station"); }
		}
		/// <summary>
		///  12. RegionID                                          (int type)     [Region where the order is located]
		/// </summary>
		public int RegionID
		{
			get { return this.GetIntFromLSO("RegionID"); }
		}
		/// <summary>
		///  13. Region                                            (string type)
		/// </summary>
		public string Region
		{
			get { return this.GetStringFromLSO("Region"); }
		}
		/// <summary>
		///  14. SolarSystemID                                     (int type)     [Solar System where the order is located]
		/// </summary>
		public int SolarSystemID
		{
			get { return this.GetIntFromLSO("SolarSystemID"); }
		}
		/// <summary>
		///  15. SolarSystem                                       (string type)
		/// </summary>
		public string SolarSystem
		{
			get { return this.GetStringFromLSO("SolarSystemID"); }
		}
		/// <summary>
		///  16. Range                                             (int type)    
		/// </summary>
		public int Range
		{
			get { return this.GetIntFromLSO("Range"); }
		}
		/// <summary>
		///  17. TypeID                                            (int type)
		/// </summary>
		public int TypeID
		{
			get { return this.GetIntFromLSO("TypeID"); }
		}
		/// <summary>
		///  18. Name                                              (string type)
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}
		/// <summary>
		///  19. IsContraband                                      (bool type)
		/// </summary>
		public bool IsContraband
		{
			get { return this.GetBoolFromLSO("IsContraband"); }
		}
		/// <summary>
		///  20. IsCorp                                            (bool type)
		/// </summary>
		public bool IsCorp
		{
			get { return this.GetBoolFromLSO("IsCorp"); }
		}
		/// <summary>
		///  21. IsSellOrder                                       (bool type)
		/// </summary>
		public bool IsSellOrder
		{
			get { return this.GetBoolFromLSO("IsSellOrder"); }
		}
		/// <summary>
		///  22. IsBuyOrder                                        (bool type)  
		/// </summary>
		public bool IsBuyOrder
		{
			get { return this.GetBoolFromLSO("IsBuyOrder"); }
		}
		#endregion

		#region Methods
		/// <summary>
		///  1. Cancel 
		/// </summary>
		public bool Cancel()
		{
			Tracing.SendCallback("MyOrder.Cancel");
			return ExecuteMethod("Cancel");
		}
		/// <summary>
		///  2. Modify[#]                   {# = new price of the item in isk}
		/// </summary>
		public bool Modify(double newPrice)
		{
			Tracing.SendCallback("MyOrder.Modify", newPrice);
			return ExecuteMethod("Modify", newPrice.ToString());
		}
		#endregion
	}
}
