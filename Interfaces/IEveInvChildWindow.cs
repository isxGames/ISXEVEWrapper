using System;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    /// <summary>
    /// Wrapper for the EveInvChildWindow datatype.
    /// </summary>
    public interface IEveInvChildWindow : ILSObject
    {
        /// <summary>
        /// Wrapper for the Capacity member of eveinvchildwindow
        /// </summary>
        double Capacity { get; }

        /// <summary>
        /// Wrapper for the UsedCapacity member of eveinvchildwindow
        /// </summary>
        double UsedCapacity { get; }

        /// <summary>
        /// Wrapper for the LocationFlag member of eveinvchildwindow
        /// </summary>
        string LocationFlag { get; }

        /// <summary>
        /// Wrapper for the LocationFlagID member of eveinvchildwindow
        /// </summary>
        int LocationFlagId { get; }

        /// <summary>
        /// Wrapper for the IsInRange member of eveinvchildwindow
        /// </summary>
        bool IsInRange { get; }

        /// <summary>
        /// Wrapper for the ItemID member of eveinvchildwindow
        /// </summary>
        Int64 ItemId { get; }

        /// <summary>
        /// Wrapper for the HasCapacity member of eveinvchildwindow
        /// </summary>
        bool HasCapacity { get; }

        /// <summary>
        /// Wrapper for the Name member of eveinvchildwindow
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Wrapper for the MakeActive method of eveinvchildwindow
        /// </summary>
        /// <returns></returns>
        bool MakeActive();

        /// <summary>
        /// Wrapper for the OpenAsNewWindow method of eveinvchildwindow
        /// </summary>
        /// <returns></returns>
        bool OpenAsNewWindow();
    }
}