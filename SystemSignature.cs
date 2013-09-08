using System;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the SystemSignature datatype.
    /// </summary>
    public class SystemSignature : LavishScriptObject
    {
        public SystemSignature(LavishScriptObject Copy) : base(Copy)
        {
        }

        private Int64? _id;
        /// <summary>
        /// Wrapper for the ID member of the SystemSignature datatype.
        /// </summary>
        public Int64 ID
        {
            get
            {
                if (_id == null)
                    _id = this.GetInt64FromLSO("ID");

                return _id.Value;
            }
        }

        private string _name;
        /// <summary>
        /// Wrapper for the Name member of the SystemSignature datatype.
        /// </summary>
        public string Name
        {
            get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
        }

        private double? _deviation;
        /// <summary>
        /// Wrapper for the Deviation member of the SystemSignature datatype.
        /// </summary>
        public double Deviation
        {
            get
            {
                if (_deviation == null)
                    _deviation = this.GetDoubleFromLSO("Deviation");

                return _deviation.Value;
            }
        }

        private int? _difficulty;
        /// <summary>
        /// Wrapper for the Difficulty member of the SystemSignature datatype.
        /// </summary>
        public int Difficulty
        {
            get
            {
                if (_difficulty == null)
                    _difficulty = this.GetIntFromLSO("Difficulty");

                return _difficulty.Value;
            }
        }

        private string _group;
        /// <summary>
        /// Wrapper for the Group member of the SystemSignature datatype.
        /// </summary>
        public string Group
        {
            get { return _group ?? (_group = this.GetStringFromLSO("Group")); }
        }

        private int? _groupId;
        /// <summary>
        /// Wrapper for the GroupID member of the SystemSignature datatype.
        /// </summary>
        public int GroupID
        {
            get
            {
                if (_groupId == null)
                    _groupId = this.GetIntFromLSO("GroupID");

                return _groupId.Value;
            }
        }

        private bool? _isWarpable;
        /// <summary>
        /// Wrapper for the IsWarpable member of the SystemSignature datatype.
        /// </summary>
        public bool IsWarpable
        {
            get
            {
                if (_isWarpable == null)
                    _isWarpable = this.GetBoolFromLSO("IsWarpable");

                return _isWarpable.Value;
            }
        }

        private double? _signalStrength;
        /// <summary>
        /// Wrapper for the SignalStrength member of the SystemSignature datatype.
        /// </summary>
        public double SignalStrength
        {
            get
            {
                if (_signalStrength == null)
                    _signalStrength = this.GetDoubleFromLSO("SignalStrength");

                return _signalStrength.Value;
            }
        }

        private Entity _toEntity;
        /// <summary>
        /// Wrapper for the ToEntity member of the SystemSignature datatype.
        /// </summary>
        public Entity ToEntity
        {
            get { return _toEntity ?? (_toEntity = new Entity(GetMember("ToEntity"))); }
        }

        private Item _toItem;
        /// <summary>
        /// Wrapper for the ToItem member of the SystemSignature datatype.
        /// </summary>
        public Item ToItem
        {
            get { return _toItem ?? (_toItem = new Item(GetMember("ToItem"))); }
        }

        private double? _x;
        /// <summary>
        /// Wrapper for the X member of the SystemSignature datatype.
        /// </summary>
        public double X
        {
            get
            {
                if (_x == null)
                    _x = this.GetDoubleFromLSO("X");

                return _x.Value;
            }
        }

        private double? _y;
        /// <summary>
        /// Wrapper for the Y member of the SystemSignature datatype.
        /// </summary>
        public double Y
        {
            get
            {
                if (_y == null)
                    _y = this.GetDoubleFromLSO("Y");

                return _y.Value;
            }
        }

        private double? _z;
        /// <summary>
        /// Wrapper for the Z member of the SystemSignature datatype.
        /// </summary>
        public double Z
        {
            get
            {
                if (_z == null)
                    _z = this.GetDoubleFromLSO("Z");

                return _z.Value;
            }
        }

        /// <summary>
        /// Wrapper for the AlignTo method of the SystemSignature datatype.
        /// </summary>
        /// <returns></returns>
        public bool AlignTo()
        {
            return ExecuteMethod("AlignTo");
        }

        /// <summary>
        /// Wrapper for the Approach method of the SystemSignature datatype.
        /// </summary>
        /// <returns></returns>
        public bool Approach()
        {
            return ExecuteMethod("Approach");
        }

        /// <summary>
        /// Wrapper for the WarpTo method of the SystemSignature datatype.
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
