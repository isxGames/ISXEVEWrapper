using System;

namespace EVE.ISXEVE.Interfaces
{
    public interface IItemInfoList
    {
        /// <summary>
        /// Wrapper for the ID member of the ItemInfoList datatype.
        /// </summary>
        int ID { get; }

        /// <summary>
        /// Wrapper for the TypeID member of the ItemInfoList datatype.
        /// </summary>
        int TypeID { get; }

        /// <summary>
        /// Wrapper for the Quantity member of the ItemInfoList datatype.
        /// </summary>
        Int64 Quantity { get; }
    }
}