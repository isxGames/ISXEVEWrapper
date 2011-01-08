using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;



//* Added new DATATYPE: 'myorder' (ie, "My Orders" tab) with the following MEMBERS:
//  1.  Price                                             (double type)
//  2.  InitialQuantity                                   (int type) 
//  3.  QuantityRemaining                                 (double type)
//  4.  MinQuantityToBuy                                  (int type)
//  5.  ID                                                (int type)
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
			get
			{
				return GetMember<double>("Price");
			}
		}
		/// <summary>
		///  2.  InitialQuantity                                   (int type) 
		/// </summary>
		public int InitialQuantity
		{
			get
			{
				return GetMember<int>("InitialQuantity");
			}
		}
		/// <summary>
		///  3.  QuantityRemaining                                 (double type)
		/// </summary>
		public double QuantityRemaining
		{
			get
			{
				return GetMember<double>("QuantityRemaining");
			}
		}
		/// <summary>
		///  4.  MinQuantityToBuy                                  (int type)
		/// </summary>
		public int MinQuantityToBuy
		{
			get
			{
				return GetMember<int>("MinQuantityToBuy");
			}
		}
		/// <summary>
		///  5.  ID                                                (int type)
		/// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}
		/// <summary>
		///  6.  TimeStampWhenIssued                               (uint64 type)
		/// </summary>
		public UInt64 TimeStampWhenIssued
		{
			get
			{
				return GetMember<UInt64>("TimeStampWhenIssued");
			}
		}
		/// <summary>
		///  7.  DateWhenIssued                                    (string type)
		/// </summary>
		public string DateWhenIssued
		{
			get
			{
				return GetMember<string>("DateWhenIssued");
			}
		}
		/// <summary>
		///  8.  TimeWhenIssued                                    (string type)
		/// </summary>
		public string TimeWhenIssued
		{
			get
			{
				return GetMember<string>("TimeWhenIssued");
			}
		}
		/// <summary>
		///  9.  Duration                                          (int type)     [The max length of the order, in days]
		/// </summary>
		public int Duration
		{
			get
			{
				return GetMember<int>("Duration");
			}
		}
		/// <summary>
		///  10. StationID                                         (int type)     [Station where the order is located]
		/// </summary>
		public int StationID
		{
			get
			{
				return GetMember<int>("StationID");
			}
		}
		/// <summary>
		///  11. Station                                           (string type)
		/// </summary>
		public string Station
		{
			get
			{
				return GetMember<string>("Station");
			}
		}
		/// <summary>
		///  12. RegionID                                          (int type)     [Region where the order is located]
		/// </summary>
		public int RegionID
		{
			get
			{
				return GetMember<int>("RegionID");
			}
		}
		/// <summary>
		///  13. Region                                            (string type)
		/// </summary>
		public string Region
		{
			get
			{
				return GetMember<string>("Region");
			}
		}
		/// <summary>
		///  14. SolarSystemID                                     (int type)     [Solar System where the order is located]
		/// </summary>
		public int SolarSystemID
		{
			get
			{
				return GetMember<int>("SolarSystemID");
			}
		}
		/// <summary>
		///  15. SolarSystem                                       (string type)
		/// </summary>
		public string SolarSystem
		{
			get
			{
				return GetMember<string>("SolarSystem");
			}
		}
		/// <summary>
		///  16. Range                                             (int type)    
		/// </summary>
		public int Range
		{
			get
			{
				return GetMember<int>("Range");
			}
		}
		/// <summary>
		///  17. TypeID                                            (int type)
		/// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}
		/// <summary>
		///  18. Name                                              (string type)
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}
		/// <summary>
		///  19. IsContraband                                      (bool type)
		/// </summary>
		public bool IsContraband
		{
			get
			{
				return GetMember<bool>("IsContraband");
			}
		}
		/// <summary>
		///  20. IsCorp                                            (bool type)
		/// </summary>
		public bool IsCorp
		{
			get
			{
				return GetMember<bool>("IsCorp");
			}
		}
		/// <summary>
		///  21. IsSellOrder                                       (bool type)
		/// </summary>
		public bool IsSellOrder
		{
			get
			{
				return GetMember<bool>("IsSellOrder");
			}
		}
		/// <summary>
		///  22. IsBuyOrder                                        (bool type)  
		/// </summary>
		public bool IsBuyOrder
		{
			get
			{
				return GetMember<bool>("IsBuyOrder");
			}
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
