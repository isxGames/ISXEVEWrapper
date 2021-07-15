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
    }
}
