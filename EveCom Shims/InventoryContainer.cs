using System;
using System.Collections.Generic;
using EVE.ISXEVE;

namespace EVE.Shims.EveCom
{
	/// <summary>
	/// Root class for all containers
	/// </summary>
	public abstract class InventoryContainer
	{
		/// <summary>
		/// List all the items in the container
		/// </summary>
		public abstract List<Item> Items
		{
			get;
		}

		/// <summary>
		/// The inventory container's name
		/// </summary>
		public abstract string Name
		{
			get;
		}

		/// <summary>
		/// Is the inventory container loaded and ready to use?(item lists and capacity values)
		/// </summary>
		public abstract bool IsPrimed
		{
			get;
		}

		/// <summary>
		/// Does the container have capacity?
		/// </summary>
		public abstract bool HasCapacity
		{
			get;
		}

		/// <summary>
		/// The inventory container's maximum capacity
		/// </summary>
		public abstract double MaxCapacity
		{
			get;
		}

		/// <summary>
		/// The inventory container's current used capacity
		/// </summary>
		public abstract double UsedCapacity
		{
			get;
		}

		/// <summary>
		/// Prime the inventory container
		/// </summary>
		public abstract void Prime();

		/// <summary>
		/// Stack all in the inventory container
		/// </summary>
		public abstract void StackAll();

		/// <summary>
		/// Move an item to the inventory container
		/// </summary>
		/// <param name="ItemToAdd">The item to add</param>
		public abstract void Add(Item ItemToAdd);

		/// <summary>
		/// Move an item to the inventory container
		/// </summary>
		/// <param name="ItemToAdd">The item to add</param>
		/// <param name="Quantity">How much of the item to add</param>
		public abstract void Add(Item ItemToAdd, int Quantity);

		/// <summary>
		/// Move items to the inventory container
		/// </summary>
		/// <param name="ItemsToAdd">The items to add</param>
		public abstract void Add(IEnumerable<Item> ItemsToAdd);

		/// <summary>
		/// Move bookmarks to the inventory container
		/// </summary>
		/// <param name="ItemsToAdd">The bookmarks to add</param>
		/// <param name="Move">Should the bookmarks be moved?</param>
		public abstract void AddBookmarks(IEnumerable<Bookmark> ItemsToAdd, bool Move = false);
	}
}
