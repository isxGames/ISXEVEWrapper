using System;
using EVE.ISXEVE;

namespace EVE.Shims.EveCom
{
	public class Session
	{
		// Properties
		public static long CharID { get; }
		public static bool InFleet { get; }
		public static bool InSpace { get; }
		public static bool InStation { get; }
		public static DateTime? NextDowntime { get; }
		public static DateTime NextSessionChange { get; }
		public static DateTime Now { get; }
		public static int RegionID { get; }
		public static bool Safe { get; }
		public static long ShipID { get; }
		public static int SolarSystemID { get; }
		public static long StationID { get; }
		public static string StationName { get; }
		public static double SystemSecurity { get; }
		public static double TiDi { get; }


		//This needs to be set up so that the above info is available!
	}
}