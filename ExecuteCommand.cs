using System;
using System.Collections.Generic;
using System.Text;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Enumeration of all the commands that may be executed with the EVE:Execute method.
	/// </summary>
    public enum ExecuteCommand
	{
        /// <summary>
    /// Accelerate
    /// </summary>
		CmdAccelerate,

    /// <summary>
    /// Activate high slot 1
    /// </summary>
		CmdActivateHighPowerSlot1,

    /// <summary>
    /// Activate high slot 2
    /// </summary>
    CmdActivateHighPowerSlot2,

    /// <summary>
    /// Activate high slot 3
    /// </summary>
    CmdActivateHighPowerSlot3,

    /// <summary>
    /// Activate high slot 4
    /// </summary>
    CmdActivateHighPowerSlot4,

    /// <summary>
    /// Activate high slot 5
    /// </summary>
    CmdActivateHighPowerSlot5,

    /// <summary>
    /// Activate high slot 6
    /// </summary>
    CmdActivateHighPowerSlot6,

    /// <summary>
    /// Activate high slot 7
    /// </summary>
    CmdActivateHighPowerSlot7,

    /// <summary>
    /// Activate high slot 8
    /// </summary>
    CmdActivateHighPowerSlot8,

    /// <summary>
    /// Activate low slot 1
    /// </summary>
    CmdActivateLowPowerSlot1,

    /// <summary>
    /// Activate low slot 2
    /// </summary>
    CmdActivateLowPowerSlot2,

    /// <summary>
    /// Activate low slot 3
    /// </summary>
    CmdActivateLowPowerSlot3,

    /// <summary>
    /// Activate low slot 4
    /// </summary>
    CmdActivateLowPowerSlot4,

    /// <summary>
    /// Activate low slot 5
    /// </summary>
    CmdActivateLowPowerSlot5,

    /// <summary>
    /// Activate low slot 6
    /// </summary>
    CmdActivateLowPowerSlot6,

    /// <summary>
    /// Activate low slot 7
    /// </summary>
    CmdActivateLowPowerSlot7,

    /// <summary>
    /// Activate low slot 8
    /// </summary>
    CmdActivateLowPowerSlot8,

    /// <summary>
    /// Activate medium slot 1
    /// </summary>
    CmdActivateMediumPowerSlot1,

    /// <summary>
    /// Activate medium slot 2
    /// </summary>
    CmdActivateMediumPowerSlot2,

    /// <summary>
    /// Activate medium slot 3
    /// </summary>
    CmdActivateMediumPowerSlot3,

    /// <summary>
    /// Activate medium slot 4
    /// </summary>
    CmdActivateMediumPowerSlot4,

    /// <summary>
    /// Activate medium slot 5
    /// </summary>
    CmdActivateMediumPowerSlot5,

    /// <summary>
    /// Activate medium slot 6
    /// </summary>
    CmdActivateMediumPowerSlot6,

    /// <summary>
    /// Activate medium slot 7
    /// </summary>
    CmdActivateMediumPowerSlot7,

    /// <summary>
    /// Activate medium slot 8
    /// </summary>
    CmdActivateMediumPowerSlot8,

    /// <summary>
    /// Close active window
    /// </summary>
		CmdCloseActiveWindow,

    /// <summary>
    /// Close all windows
    /// </summary>
		CmdCloseAllWindows,

    /// <summary>
    /// Decelerate
    /// </summary>
		CmdDecelerate,
		
    /// <summary>
    /// Engage drones on target
    /// </summary>
    CmdDronesEngage,

    /// <summary>
    /// Return drones to orbit
    /// </summary>
		CmdDronesReturnAndOrbit,

    /// <summary>
    /// Return drones to bay
    /// </summary>
		CmdDronesReturnToBay,

    /// <summary>
    /// Undock
    /// </summary>
		CmdExitStation,
		
    /// <summary>
    /// Log off
    /// </summary>
    CmdLogOff,

    /// <summary>
    /// Minimize active window
    /// </summary>
		CmdMinimizeActiveWindow,

    /// <summary>
    /// Minimize all windows
    /// </summary>
		CmdMinimizeAllWindows,

    /// <summary>
    /// Overload entire high-power rack
    /// </summary>
    CmdOverloadHighPowerRack,

    /// <summary>
    /// Overload high slot 1
    /// </summary>
    CmdOverloadHighPowerSlot1,

    /// <summary>
    /// Overload high slot 2
    /// </summary>
    CmdOverloadHighPowerSlot2,

    /// <summary>
    /// Overload high slot 3
    /// </summary>
    CmdOverloadHighPowerSlot3,

    /// <summary>
    /// Overload high slot 4
    /// </summary>
    CmdOverloadHighPowerSlot4,

    /// <summary>
    /// Overload high slot 5
    /// </summary>
    CmdOverloadHighPowerSlot5,

    /// <summary>
    /// Overload high slot 6
    /// </summary>
    CmdOverloadHighPowerSlot6,

    /// <summary>
    /// Overload high slot 7
    /// </summary>
    CmdOverloadHighPowerSlot7,

    /// <summary>
    /// Overload high slot 8
    /// </summary>
    CmdOverloadHighPowerSlot8,

    /// <summary>
    /// Overload entire low-power rack
    /// </summary>
    CmdOverloadLowPowerRack,

    /// <summary>
    /// Overload low slot 1
    /// </summary>
    CmdOverloadLowPowerSlot1,

    /// <summary>
    /// Overload low slot 2
    /// </summary>
    CmdOverloadLowPowerSlot2,

    /// <summary>
    /// Overload low slot 3
    /// </summary>
    CmdOverloadLowPowerSlot3,

    /// <summary>
    /// Overload low slot 4
    /// </summary>
    CmdOverloadLowPowerSlot4,

    /// <summary>
    /// Overload low slot 5
    /// </summary>
    CmdOverloadLowPowerSlot5,

    /// <summary>
    /// Overload low slot 6
    /// </summary>
    CmdOverloadLowPowerSlot6,

    /// <summary>
    /// Overload low slot 7
    /// </summary>
    CmdOverloadLowPowerSlot7,

    /// <summary>
    /// Overload low slot 87
    /// </summary>
    CmdOverloadLowPowerSlot8,

    /// <summary>
    /// Overload entire medium-power rack
    /// </summary>
    CmdOverloadMediumPowerRack,

    /// <summary>
    /// Overload medium slot 1
    /// </summary>
    CmdOverloadMediumPowerSlot1,

    /// <summary>
    /// Overload medium slot 2
    /// </summary>
    CmdOverloadMediumPowerSlot2,

    /// <summary>
    /// Overload medium slot 3
    /// </summary>
    CmdOverloadMediumPowerSlot3,

    /// <summary>
    /// Overload medium slot 4
    /// </summary>
    CmdOverloadMediumPowerSlot4,

    /// <summary>
    /// Overload medium slot 5
    /// </summary>
    CmdOverloadMediumPowerSlot5,

    /// <summary>
    /// Overload medium slot 6
    /// </summary>
    CmdOverloadMediumPowerSlot6,

    /// <summary>
    /// Overload medium slot 7
    /// </summary>
    CmdOverloadMediumPowerSlot7,

    /// <summary>
    /// Overload medium slot 8
    /// </summary>
    CmdOverloadMediumPowerSlot8,

    /// <summary>
    /// Quit Eve
    /// </summary>
		CmdQuitGame,

    /// <summary>
    /// Reload
    /// </summary>
		CmdReloadAmmo,

    /// <summary>
    /// Reset monitor (??)
    /// </summary>
    CmdResetMonitor,

    /// <summary>
    /// Broadcast "enemy spotted" to fleet
    /// </summary>
		CmdSendBroadcast_EnemySpotted,

    /// <summary>
    /// Broadcast "need armor" to fleet
    /// </summary>
    CmdSendBroadcast_HealArmor,

    /// <summary>
    /// Broadcast "need cap" to fleet
    /// </summary>
    CmdSendBroadcast_HealCapacitor,

    /// <summary>
    /// Broadcast "need shields" to fleet
    /// </summary>
    CmdSendBroadcast_HealShield,

    /// <summary>
    /// Broadcast "hold position" to fleet
    /// </summary>
    CmdSendBroadcast_HoldPosition,

    /// <summary>
    /// Broadcast "in position" to fleet
    /// </summary>
    CmdSendBroadcast_InPosition,

    /// <summary>
    /// Broadcast jump beacon location to fleet
    /// </summary>
    CmdSendBroadcast_JumpBeacon,

    /// <summary>
    /// Broadcast a location to fleet
    /// </summary>
    CmdSendBroadcast_Location,

    /// <summary>
    /// Broadcast "need backup" to fleet
    /// </summary>
    CmdSendBroadcast_NeedBackup,

    /// <summary>
    /// Stop ship
    /// </summary>
		CmdStopShip,

    /// <summary>
    /// Toggle drones between aggressive and passive behaviour
    /// </summary>
		CmdToggleAggressivePassive,

    /// <summary>
    /// Toggle audio on and off
    /// </summary>
		CmdToggleAudio,

    /// <summary>
    /// Toggle autopilot on and off
    /// </summary>
		CmdToggleAutopilot,

    /// <summary>
    /// Toggle drone focus fire on and off
    /// </summary>
		CmdToggleDroneFocusFire,

    /// <summary>
    /// Toggle fighter follow on and off
    /// </summary>
    CmdToggleFighterAttackAndFollow,

    /// <summary>
    /// Toggle map window
    /// </summary>
		CmdToggleMap,

    /// <summary>
    /// Toggle all brackets
    /// </summary>
		CmdToggleShowAllBrackets,

    /// <summary>
    /// Toggle special brackets
    /// </summary>
		CmdToggleShowSpecialBrackets,

    /// <summary>
    /// Zoom in
    /// </summary>
		CmdZoomIn,

    /// <summary>
    /// Zoom out
    /// </summary>
		CmdZoomOut,

    /// <summary>
    /// Open assets window
    /// </summary>
		OpenAssets,

    /// <summary>
    /// Open web browser window
    /// </summary>
		OpenBrowser,

    /// <summary>
    /// Open calculator window
    /// </summary>
		OpenCalculator,

    /// <summary>
    /// Open capital navigation window
    /// </summary>
		OpenCapitalNavigation,

		/// <summary>
		/// This is a toggle
		/// </summary>
		OpenCargoHoldOfActiveShip,

    /// <summary>
    /// Open chat channels window
    /// </summary>
    OpenChannels,

    /// <summary>
    /// Open character sheet window
    /// </summary>
    OpenCharactersheet,

    /// <summary>
    /// Open configuration window
    /// </summary>
    OpenConfigMenu,

    /// <summary>
    /// Open contracts window
    /// </summary>
    OpenContracts,

    /// <summary>
    /// Open corporation information window
    /// </summary>
    OpenCorporationPanel,

    /// <summary>
    /// Open drone bay window
    /// </summary>
		OpenDroneBayOfActiveShip,

    /// <summary>
    /// Open factory window
    /// </summary>
    OpenFactory,

    /// <summary>
    /// Open fitting window
    /// </summary>
    OpenFitting,

    /// <summary>
    /// Open FPS window
    /// </summary>
    OpenFpsMonitor,

    /// <summary>
    /// Open station items window
    /// </summary>
    OpenHangarFloor,

    /// <summary>
    /// Open help window
    /// </summary>
    OpenHelp,

    /// <summary>
    /// Open mail window
    /// </summary>
    OpenInbox,

    /// <summary>
    /// Open journal window
    /// </summary>
    OpenJournal,

    /// <summary>
    /// Open jukebox window
    /// </summary>
    OpenJukebox,

    /// <summary>
    /// Open log window
    /// </summary>
    OpenLog,

    /// <summary>
    /// Open map window
    /// </summary>
    OpenMapBrowser,

    /// <summary>
    /// Open market window
    /// </summary>
    OpenMarket,

    /// <summary>
    /// Open medical window
    /// </summary>
    OpenMedical,

    /// <summary>
    /// Open militia window
    /// </summary>
    OpenMilitia,

    /// <summary>
    /// Open mission journal window
    /// </summary>
    OpenMissions,

    /// <summary>
    /// Open monitor window
    /// </summary>
    OpenMonitor,

    /// <summary>
    /// Open moon mining window
    /// </summary>
    OpenMoonMining,

    /// <summary>
    /// Open notepad window
    /// </summary>
    OpenNotepad,

    /// <summary>
    /// Open overview settings window
    /// </summary>
    OpenOverviewSettings,

    /// <summary>
    /// Open people and places window
    /// </summary>
    OpenPeopleAndPlaces,

    /// <summary>
    /// Open repair window
    /// </summary>
    OpenRepairshop,

    /// <summary>
    /// Open reprocessing window
    /// </summary>
    OpenReprocessingplant,

    /// <summary>
    /// Open scanner window
    /// </summary>
    OpenScanner,

    /// <summary>
    /// Open ship configuration window
    /// </summary>
    OpenShipConfig,

    /// <summary>
    /// Open ship hangar window
    /// </summary>
    OpenShipHangar,

    /// <summary>
    /// Open station control window
    /// </summary>
    OpenStationManagement,

    /// <summary>
    /// Open tutorial window
    /// </summary>
    OpenTutorials,

    /// <summary>
    /// Open wallet window
    /// </summary>
    OpenWallet,

    /// <summary>
    /// Screen capture
    /// </summary>
    PrintScreen,

    /// <summary>
    /// Toggle between full-screen and windowed mode
    /// </summary>
    WinCmdToggleWindowed
	}
}
