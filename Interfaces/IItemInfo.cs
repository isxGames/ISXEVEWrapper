using System;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    public interface IItemInfo : ILSObject
    {
        /// <summary>
        /// Wrapper for the ID member of the ItemInfo datatype.
        /// </summary>
        Int64 ID { get; }

        /// <summary>
        /// Wrapper for the Type member of the ItemInfo datatype.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Wrapper for the TypeID member of the ItemInfo datatype.
        /// </summary>
        int TypeID { get; }

        /// <summary>
        /// Wrapper for the Group member of the ItemInfo datatype.
        /// </summary>
        string Group { get; }

        /// <summary>
        /// Wrapper for the GroupID member of the ItemInfo datatype.
        /// </summary>
        int GroupID { get; }

        /// <summary>
        /// Wrapper for the Category member of the ItemInfo datatype.
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Wrapper for the CategoryID member of the ItemInfo datatype.
        /// </summary>
        int CategoryID { get; }

        /// <summary>
        /// Wrapper for the IsContraband member of the ItemInfo datatype.
        /// </summary>
        bool IsContraband { get; }

        /// <summary>
        /// Wrapper for the GraphicID member of the ItemInfo datatype.
        /// </summary>
        int GraphicID { get; }

        /// <summary>
        /// Wrapper for the Capacity member of the ItemInfo datatype.
        /// </summary>
        double Capacity { get; }

        /// <summary>
        /// Wrapper for the Radius member of the ItemInfo datatype.
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// Wrapper for the RaceID member of the ItemInfo datatype.
        /// </summary>
        int RaceID { get; }

        /// <summary>
        /// Wrapper for the Volume member of the ItemInfo datatype.
        /// </summary>
        double Volume { get; }

        /// <summary>
        /// Wrapper for the BasePrice member of the ItemInfo datatype.
        /// </summary>
        double BasePrice { get; }

        /// <summary>
        /// Wrapper for the PortionSize member of the ItemInfo datatype.
        /// </summary>
        int PortionSize { get; }

        /// <summary>
        /// Wrapper for the MarketGroupID member of the ItemInfo datatype.
        /// </summary>
        int MarketGroupID { get; }

        /// <summary>
        /// Wrapper for the Description member of the ItemInfo datatype.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Wrapper for the ChargeSize member of the ItemInfo datatype.
        /// </summary>
        int ChargeSize { get; }

        /// <summary>
        /// Wrapper for the RangeBonus member of the ItemInfo datatype.
        /// </summary>
        float RangeBonus { get; }

        /// <summary>
        /// Wrapper for the ShieldRadius member of the ItemInfo datatype.
        /// </summary>
        int ShieldRadius { get; }
    }
}