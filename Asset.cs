using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;


//November 4, 2007 -- By Amadeus
//[ISXEVE-20070911.0505]
//*** 
//*** NOTES ABOUT ASSETS:
//***
//*** 1. "GetAssets" will NOT include items that are in the same station you are currently residing (if applicable).  However,
//***    "GetStationsWithAssets" and "NumAssetsAtStation" WILL contain information about your current station.
//*** 2. ISXEVE cannot override the 5 minute updating delay present in EVE.  In other words, the information given by ISXEVE
//***    will match what you see in your UI.
//*** 3. StationID#s match the "LocationID" member of the 'asset' datatype as well as the "ID" member of the 'entity' datatype.
//*** 4. You will need to open the assets window and have all stations expanded to have access to the items at that station.
//*** 5. I have placed an example script at http://www.isxgames.com/forums/showthread.php?p=11830&posted=1#post11830
//***
//* Added new DATATYPE: "asset", with the following MEMBERS:
//  1.  ID                                                (int type)
//  2.  OwnerID                                           (int type)
//  3.  Group                                             (string type)
//  4.  GroupID                                           (int type)
//  5.  Category                                          (string type)
//  6.  CategoryID                                        (int type)
//  7.  Type                                              (string type)
//  8.  TypeID                                            (int type)
//  9.  MacroLocation                                     (string type)
//  10. MacroLocationID                                   (int type)
//  11. Location                                          (string type)
//  12. LocationID                                        (int type)
//  13. Location                                          (string type)
//  14. Quantity                                          (int type)
//  15. Description                                       (string type)
//  16. GraphicID                                         (int type)
//  17. Volume                                            (double type)
//  18. MarketGroupID                                     (int type)
//  19. BasePrice                                         (double type)
//  20. Capacity                                          (double type)
//  21. Radius                                            (dobule type)
//* Added new MEMBERS to the 'character' datatype:
//  1. GetAssets[<index:asset>]                            (int type)   [Retrieves all items that are in your assets window]
//     GetAssets[<index:asset>,#]                          (int type)   [Retrieves all items that match the StationID# given]
//  2. GetStationsWithAssets[<index:int>]                  (int type)   [Retrieves a list of StationID#s where you currently have assets.]
//* Added new METHODS to the 'character' datatype:
//  1. DoGetAssets[<index:asset>]                                       [Retrieves all items that are in your assets window]
//     DoGetAssets[<index:asset>,#]                                     [Retrieves all items that match the StationID# given]
//  2. DoGetStationsWithAssets[<index:int>]                             [Retrieves a list of StationID#s where you currently have assets.]  
//* Added new MEMBER to the 'eve' datatype:
//  1.  NumAssetsAtStation[#]                             (int type)    [Returns the number of items currently housed at the StationID# given.]
//  2.  GetLocationNameByID[#]                            (string type) [Useful for changing a StationID# to an actual name.]

namespace EVE.ISXEVE
{
  /// <summary>
  /// Wrapper for the asset type.
  /// </summary>
	public class Asset : LavishScriptObject
	{
		#region Constructors
    /// <summary>
    /// Asset copy constructor.
    /// </summary>
    /// <param name="Obj"></param>
		public Asset(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members

		/// <summary>
		///  1.  ID                                                (int type)
		/// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}

		/// <summary>
		///  2.  OwnerID                                           (int type)
		/// </summary>
		public int OwnerID
		{
			get
			{
				return GetMember<int>("OwnerID");
			}
		}

		/// <summary>
		///  3.  Group                                             (string type)
		/// </summary>
		public string Group
		{
			get
			{
				return GetMember<string>("Group");
			}
		}

		/// <summary>
		///  4.  GroupID                                           (int type)
		/// </summary>
		public int GroupID
		{
			get
			{
				return GetMember<int>("GroupID");
			}
		}

		/// <summary>
		///  5.  Category                                          (string type)
		/// </summary>
		public string Category
		{
			get
			{
				return GetMember<string>("Category");
			}
		}

		/// <summary>
		///  6.  CategoryID                                        (int type)
		/// </summary>
		public int CategoryID
		{
			get
			{
				return GetMember<int>("CategoryID");
			}
		}

		/// <summary>
		///  7.  Type                                              (string type)
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

		/// <summary>
		///  8.  TypeID                                            (int type)
		/// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

		/// <summary>
		///  9.  MacroLocation                                     (string type)
		/// </summary>
		public string MacroLocation
		{
			get
			{
				return GetMember<string>("MacroLocation");
			}
		}

		/// <summary>
		///  10. MacroLocationID                                   (int type)
		/// </summary>
		public int MacroLocationID
		{
			get
			{
				return GetMember<int>("MacroLocationID");
			}
		}

		/// <summary>
		///  11. Location                                          (string type)
		/// </summary>
		public string Location
		{
			get
			{
				return GetMember<string>("Location");
			}
		}

		/// <summary>
		///  12. LocationID                                        (int type)
		/// </summary>
		public int LocationID
		{
			get
			{
				return GetMember<int>("LocationID");
			}
		}


		/// <summary>
		///  13. Location                                          (string type)
		///  ASSUME THIS IS AN ERROR AND A DUPLICATE OF #11
		/// </summary>
		/// <summary>
		///  14. Quantity                                          (int type)
		/// </summary>
		public int Quantity
		{
			get
			{
				return GetMember<int>("Quantity");
			}
		}

		/// <summary>
		///  15. Description                                       (string type)
		/// </summary>
		public string Description
		{
			get
			{
				return GetMember<string>("Description");
			}
		}

		/// <summary>
		///  16. GraphicID                                         (int type)
		/// </summary>
		public int GraphicID
		{
			get
			{
				return GetMember<int>("GraphicID");
			}
		}

		/// <summary>
		///  17. Volume                                            (double type)
		/// </summary>
		public double Volume
		{
			get
			{
				return GetMember<double>("Volume");
			}
		}

		/// <summary>
		///  18. MarketGroupID                                     (int type)
		/// </summary>
		public int MarketGroupID
		{
			get
			{
				return GetMember<int>("MarketGroupID");
			}
		}

		/// <summary>
		///  19. BasePrice                                         (double type)
		/// </summary>
		public double BasePrice
		{
			get
			{
				return GetMember<double>("BasePrice");
			}
		}

		/// <summary>
		///  20. Capacity                                          (double type)
		/// </summary>
		public double Capacity
		{
			get
			{
				return GetMember<double>("Capacity");
			}
		}

		/// <summary>
		///  21. Radius                                            (dobule type)
		/// </summary>
		public double Radius
		{
			get
			{
				return GetMember<double>("Radius");
			}
		}
		#endregion

		#region Methods
		// no methods at the moment
		#endregion
	}
}
