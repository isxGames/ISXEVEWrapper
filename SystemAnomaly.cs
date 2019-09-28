using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the SystemAnomaly datatype.
    /// </summary>
    public class SystemAnomaly : LavishScriptObject
    {
        public SystemAnomaly(LavishScriptObject Copy) : base(Copy)
        {
        }

        private Int64? _id;
        /// <summary>
        /// Wrapper for the ID member of the SystemAnomaly datatype.
        /// </summary>
        public Int64 ID
        {
            get
            {
                if (_id == null)
                    _id = this.GetInt64("ID");

                return _id.Value;
            }
        }

        private string _name;
        /// <summary>
        /// Wrapper for the Name member of the SystemAnomaly datatype.
        /// </summary>
        public string Name
        {
            get { return _name ?? (_name = this.GetString("Name")); }
        }

        private int? _difficulty;
        /// <summary>
        /// Wrapper for the Difficulty member of the SystemAnomaly datatype.
        /// </summary>
        public int Difficulty
        {
            get
            {
                if (_difficulty == null)
                    _difficulty = this.GetInt("Difficulty");

                return _difficulty.Value;
            }
        }

        private int? _dungeonId;
        /// <summary>
        /// Wrapper for the DungeonID member of the SystemAnomaly datatype.
        /// </summary>
        public int DungeonID
        {
            get
            {
                if (_dungeonId == null)
                    _dungeonId = this.GetInt("DungeonID");

                return _dungeonId.Value;
            }
        }

        private string _dungeonName;
        /// <summary>
        /// Wrapper for the Dungeon Name member of the SystemAnomaly datatype.
        /// </summary>
        public string DungeonName
        {
            get { return _dungeonName ?? (_dungeonName = this.GetString("DungeonName")); }
        }

        private string _faction;
        /// <summary>
        /// Wrapper for the Faction member of the SystemAnomaly datatype.
        /// </summary>
        public string Faction
        {
            get { return _faction ?? (_faction = this.GetString("Faction")); }
        }

        private int? _factionId;
        /// <summary>
        /// Wrapper for the FactionID member of the SystemAnomaly datatype.
        /// </summary>
        public int FactionID
        {
            get
            {
                if (_factionId == null)
                    _factionId = this.GetInt("FactionID");

                return _factionId.Value;
            }
        }

        private string _group;
        /// <summary>
        /// Wrapper for the Group member of the SystemAnomaly datatype.
        /// </summary>
        public string Group
        {
            get { return _group ?? (_group = this.GetString("Group")); }
        }

        private int? _groupId;
        /// <summary>
        /// Wrapper for the GroupID member of the SystemAnomaly datatype.
        /// </summary>
        public int GroupID
        {
            get
            {
                if (_groupId == null)
                    _groupId = this.GetInt("GroupID");

                return _groupId.Value;
            }
        }

        private bool? _isWarpable;
        /// <summary>
        /// Wrapper for the IsWarpable member of the SystemAnomaly datatype.
        /// </summary>
        public bool IsWarpable
        {
            get
            {
                if (_isWarpable == null)
                    _isWarpable = this.GetBool("IsWarpable");

                return _isWarpable.Value;
            }
        }

        private int? _scanStrength;
        /// <summary>
        /// Wrapper for the ScanStrength member of the SystemAnomaly datatype.
        /// </summary>
        public int ScanStrength
        {
            get
            {
                if (_scanStrength == null)
                    _scanStrength = this.GetInt("ScanStrength");

                return _scanStrength.Value;
            }
        }

        private double? _signalStrength;
        /// <summary>
        /// Wrapper for the SignalStrength member of the SystemAnomaly datatype.
        /// </summary>
        public double SignalStrength
        {
            get
            {
                if (_signalStrength == null)
                    _signalStrength = this.GetDouble("SignalStrength");

                return _signalStrength.Value;
            }
        }

        private double? _x;
        /// <summary>
        /// Wrapper for the X member of the SystemAnomaly datatype.
        /// </summary>
        public double X
        {
            get
            {
                if (_x == null)
                    _x = this.GetDouble("X");

                return _x.Value;
            }
        }

        private double? _y;
        /// <summary>
        /// Wrapper for the Y member of the SystemAnomaly datatype.
        /// </summary>
        public double Y
        {
            get
            {
                if (_y == null)
                    _y = this.GetDouble("Y");

                return _y.Value;
            }
        }

        private double? _z;
        /// <summary>
        /// Wrapper for the Z member of the SystemAnomaly datatype.
        /// </summary>
        public double Z
        {
            get
            {
                if (_z == null)
                    _z = this.GetDouble("Z");

                return _z.Value;
            }
        }

        /// <summary>
        /// Wrapper for the AlignTo method of the SystemAnomaly datatype.
        /// </summary>
        /// <returns></returns>
        public bool AlignTo()
        {
            return ExecuteMethod("AlignTo");
        }

        /// <summary>
        /// Wrapper for the Approach method of the SystemAnomaly datatype.
        /// </summary>
        /// <returns></returns>
        public bool Approach()
        {
            return ExecuteMethod("Approach");
        }

        /// <summary>
        /// Wrapper for the WarpTo method of the SystemAnomaly datatype.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="isFleetWarp"></param>
        /// <returns></returns>
        public bool WarpTo(int distance, bool isFleetWarp)
        {
            return ExecuteMethod("WarpTo", distance.ToString(), isFleetWarp.ToString());
        }
    }
}
