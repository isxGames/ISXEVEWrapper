using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;
using EVE.ISXEVE;

namespace ISXEVEWrapperTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AssetTest_Click(object sender, EventArgs e)
        {
            //function main()
            //{
            //        variable int i = 1
            //        variable index:int StationsWithAssets
            //        variable index:asset Assets
            //        variable int StationsWithAssetsCount
            //        variable int AssetsCount
            //        StationsWithAssetsCount:Set[${Me.GetStationsWithAssets[StationsWithAssets]}]
            //        echo Populating StationsWithAssets List:: ${StationsWithAssetsCount} Stations total
             
            //        do
            //        { 
            //          echo Station Number ${i} ${EVE.NumAssetsAtStation[${StationsWithAssets.Get[${i}]}]} items at Station#: ${StationsWithAssets.Get[${i}]} (${EVE.GetLocationNameByID[${StationsWithAssets.Get[${i}]}]})
            //        }
            //        while ${i:Inc} <= ${StationsWithAssetsCount}
             
            //        i:Set[1]
            //        echo Now Listing Assets:
            //        echo ** Please note that items in the current station (if you're currently docked) will not be on this list **
            //        AssetsCount:Set[${Me.GetAssets[Assets]}]
            //        echo Populating Assets List:: ${AssetsCount} Assets total
             
            //        do
            //        { 
            //          echo Asset Number ${i}: ${Assets.Get[${i}].Name}
            //        }
            //        while ${i:Inc} <= ${AssetsCount}        
            //}

            //        *** NOTES ABOUT ASSETS:
            //***
            //*** 1. "GetAssets" will NOT include items that are in the same station you are currently residing (if applicable). However,
            //*** "GetStationsWithAssets" and "NumAssetsAtStation" WILL contain information about your current station.
            //*** 2. ISXEVE cannot override the 5 minute updating delay present in EVE. In other words, the information given by ISXEVE
            //*** will match what you see in your UI.
            //*** 3. StationID#s match the "LocationID" member of the 'asset' datatype as well as the "ID" member of the 'entity' datatype.
            //*** 4. You will need to open the assets window and manually expand each station to have access to the items at that station.
            //***
            InnerSpace.Echo("ISXEVEWrapperTest (Assets): Begin");
//             using (new FrameLock(true))
//             {
//                 Extension Ext = new Extension();
//                 InnerSpace.Echo("Name: " + Ext.Me.Name);
// 
//                 List<long> stationList;
//                 stationList = Ext.Me.GetStationsWithAssets();
// 
//                 InnerSpace.Echo("You have " + stationList.Count + " stations with assets.");
// 
//                 foreach (int station in stationList)
//                 {
//                     List<Asset> assetList;
//                     assetList = Ext.Me.GetAssets(station);
//                     InnerSpace.Echo("  - Station #" + station + " contains " + assetList.Count + " items.");
//                     foreach (Asset asset in assetList)
//                     {
//                         InnerSpace.Echo("  - ID (" + asset.ID + ") " +
//                             "TypeID (" + asset.TypeID + ") " +
//                             "Type (" + asset.Type + ") ");
//                     }
//                 }
//             }
            InnerSpace.Echo("ISXEVEWrapperTest (Assets): End");
        }

        private void btn_MyOrderTest_Click(object sender, EventArgs e)
        {
            Extension Ext;

            InnerSpace.Echo("ISXEVEWrapperTest (MyOrder): Begin");
            using (new FrameLock(true))
            {
                Ext = new Extension();

                Ext.Me.UpdateMyOrders();
            }
            System.Threading.Thread.Sleep(1000);
            using (new FrameLock(true))
            {
                List<MyOrder> orderList;
                orderList = Ext.Me.GetMyOrders();

                InnerSpace.Echo("You have " + orderList.Count + " open orders.");

                foreach (MyOrder order in orderList)
                {
                    InnerSpace.Echo("  - " + order.Name + ": "+ order.QuantityRemaining + 
                        " @ " + order.Price + " ISK.");
                }
            }
            InnerSpace.Echo("ISXEVEWrapperTest (MyOrder): End");
        }

        private void btn_MarketOrderTest_Click(object sender, EventArgs e)
        {
            Extension Ext = new Extension();

            InnerSpace.Echo("ISXEVEWrapperTest (MarketOrder): Begin");

            Ext.EVE().FetchMarketOrders(3347);

            System.Threading.Thread.Sleep(1000);
            using (new FrameLock(true))
            {
                List<MarketOrder> orderList;
                orderList = Ext.EVE().GetMarketOrders(3347);
                InnerSpace.Echo("Found " + orderList.Count + " orders for the Amarr Titan skillbook.");

                foreach (MarketOrder order in orderList)
                {
                    InnerSpace.Echo("  - " + order.Name + ": " + order.QuantityRemaining +
                        " @ " + order.Price + " ISK.");
                }
            }
            InnerSpace.Echo("ISXEVEWrapperTest (MarketOrder): End");
        }

        private void btnMoveItemsTo_Click(object sender, EventArgs e)
        {
            InnerSpace.Echo("ISXEVEWrapperTest (MoveItemsTo): Begin");
            using (new FrameLock(true))
            {
                Extension Ext = new Extension();

                // move all the items from your ship to the hangar
                List<Item> itemList;
                List<long> itemIdxList;
/*
                itemList = Ext.Me.Ship.GetCargo();

                InnerSpace.Echo("You have " + itemList.Count + " items in your ship's cargo bay.");
                
                itemIdxList = new List<long>(itemList.Count);
                foreach (Item item in itemList)
                {
                    itemIdxList.Add(item.ID);
                }

                InnerSpace.Echo("Moving " + itemIdxList.Count + " items in your hangar.");
                Ext.EVE().MoveItemsTo(itemIdxList, "MyStationHangar", "Hangar");
*/
            }
            InnerSpace.Echo("ISXEVEWrapperTest (MoveItemsTo): End");
        }

        private void btnTargeting_Click(object sender, EventArgs e)
        {
            InnerSpace.Echo("ISXEVEWrapperTest (GetTargeting): Begin");

            using (new FrameLock(true))
            {
                Extension Ext = new Extension();

                List<Entity> getTargets = Ext.Me.GetTargets();
                List<Entity> getTargeting = Ext.Me.GetTargeting();

                InnerSpace.Echo("You have currently " + getTargets.Count + " targets.");
                InnerSpace.Echo("You are currently targeting " + getTargeting.Count + " targets.");
            }

            InnerSpace.Echo("ISXEVEWrapperTest (GetTargeting): End");
        }
    }
}