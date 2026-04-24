using System;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    public interface IBookMark : ILSObject
    {
        /// <summary>
        /// Wrapper for the ID member of a bookmark object
        /// </summary>
        Int64 ID { get; }

        /// <summary>
        /// Wrapper for the Type member of a bookmark object
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Wrapper for the TypeID member of a bookmark object
        /// </summary>
        int TypeID { get; }

        /// <summary>
        /// Wrapper-side convenience that returns the GroupID of the entity this bookmark points to, or -1 if unavailable.
        /// NOT a native ISXEVE bookmark member; delegates to ToEntity.GroupID (only resolves when the entity is loaded in space).
        /// </summary>
        int GroupID { get; }

        /// <summary>
        /// If the bookmark refers to an entity currently available on your
        /// overhead, it will return said entity. Use LavishScriptObject.IsNullOrInvalid
        /// to check for validity
        /// </summary>
        Entity ToEntity { get; }

        /// <summary>
        /// Wrapper for the SolarSystemID member of a bookmark object
        /// </summary>
        int SolarSystemID { get; }

        /// <summary>
        /// Wrapper for the Distance member of a bookmark object
        /// </summary>
        double Distance { get; }

        /// <summary>
        /// Wrapper for the X member of a bookmark object
        /// </summary>
        double X { get; }

        /// <summary>
        /// Wrapper for the Y member of a bookmark object
        /// </summary>
        double Y { get; }

        /// <summary>
        /// Wrapper for the Z member of a bookmark object
        /// </summary>
        double Z { get; }

        /// <summary>
        /// Wrapper for the Label member of a bookmark object
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Wrapper for the Note member of a bookmark object
        /// </summary>
        string Note { get; }

        /// <summary>
        /// Wrapper for the DateCreated member of a bookmark object
        /// </summary>
        string DateCreated { get; }

        /// <summary>
        /// Wrapper for the TimeCreated member of a bookmark object
        /// </summary>
        string TimeCreated { get; }

        /// <summary>
        /// Wrapper for the AgentID member of a bookmark object
        /// </summary>
        int AgentID { get; }

        /// <summary>
        /// Wrapper for the LocationID member of a bookmark object
        /// </summary>
        Int64 LocationID { get; }

        /// <summary>
        /// Wrapper for the LocationNumber member of a bookmark object
        /// </summary>
        int LocationNumber { get; }

        /// <summary>
        /// Wrapper for the LocationType member of a bookmark object
        /// </summary>
        string LocationType { get; }

        /// <summary>
        /// Wrapper for the ItemID member of a bookmark object
        /// </summary>
        Int64 ItemID { get; }

        /// <summary>
        /// Wrapper for the CreatorID member of a bookmark object
        /// </summary>
        Int64 CreatorID { get; }

        /// <summary>
        /// (NOTE:  Only works for agent bookmarks.)
        /// </summary>
        bool DeadSpace { get; }

        /// <summary>
        /// Wrapper for the OwnerID member of the 'bookmark' type.
        /// </summary>
        long OwnerID { get; }

        /// <summary>
        /// Wrapper for the JumpsTo member of a bookmark object. Computed live by ISXEVE on every read.
        /// </summary>
        int JumpsTo { get; }

        /// <summary>
        /// This will only work with bookmarks for which there is an "AlignTo To" option available via the in-game UI.
        /// </summary>
        /// <returns></returns>
        bool AlignTo();

        /// <summary>
        /// Warp to 0 distance
        /// </summary>
        bool WarpTo();

        /// <summary>
        /// Warp to the given distance
        /// </summary>
        bool WarpTo(int Distance);
        
        /// <summary>
        /// Warp fleet to 0 distance
        /// </summary>
        bool WarpFleetTo();

        /// <summary>
        /// Removes bookmark.
        /// </summary>
        bool Remove();

        /// <summary>
        /// Sets bookmark as current destination.
        /// </summary>
        bool SetDestination();

        /// <summary>
        /// Add bookmark to waypoint list.
        /// </summary>
        bool AddWaypoint();

        /// <summary>
        /// Determine the # of jumps to the given solarsystem or station ID.
        /// </summary>
        /// <remarks>
        /// The ISXEVE bookmark.JumpsTo member does NOT accept a user-supplied argument; the id parameter
        /// is silently ignored and this method returns the same value as the <see cref="JumpsTo"/> property.
        /// Use <c>Universe[id].JumpsTo</c> for arbitrary destinations.
        /// </remarks>
        /// <param name="solarSystemOrStationId">Ignored by ISXEVE.</param>
        [Obsolete("Argument is ignored by ISXEVE; returns same as JumpsTo property. Use Universe[id].JumpsTo for arbitrary destinations.")]
        int GetJumpsTo(int solarSystemOrStationId);
    }
}
