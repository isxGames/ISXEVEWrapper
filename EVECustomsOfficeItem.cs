using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the evecustomsofficeitem datatype.  Represents one commodity row of a customs office /
	/// launchpad import-export window, as returned by the CustomsOfficeItem/SpaceportItem/StagedImportItem/
	/// StagedExportItem members and the GetLaunchpads-adjacent listings on <see cref="EveCustomsOfficeWindow"/>.
	/// </summary>
	public class EVECustomsOfficeItem : LavishScriptObject
	{
		/// <summary>
		/// EVECustomsOfficeItem copy constructor.
		/// </summary>
		/// <param name="copy"></param>
		public EVECustomsOfficeItem(LavishScriptObject copy) : base(copy)
		{
		}

		#region LS Members

		private int? _typeID;
		/// <summary>
		/// Wrapper for the TypeID member of the evecustomsofficeitem datatype.  The commodity's typeID.
		/// </summary>
		public int TypeID
		{
			get
			{
				if (_typeID == null)
					_typeID = this.GetInt("TypeID");
				return _typeID.Value;
			}
		}

		private long? _quantity;
		/// <summary>
		/// Wrapper for the Quantity member of the evecustomsofficeitem datatype.
		/// </summary>
		public long Quantity
		{
			get
			{
				if (_quantity == null)
					_quantity = this.GetInt64("Quantity");
				return _quantity.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the evecustomsofficeitem datatype.  The commodity's display name.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
		}

		private long? _itemID;
		/// <summary>
		/// Wrapper for the ItemID member of the evecustomsofficeitem datatype.  Returns -1 for launchpad
		/// (spaceport) rows, whose rows have no itemID.
		/// </summary>
		public long ItemID
		{
			get
			{
				if (_itemID == null)
					_itemID = this.GetInt64("ItemID");
				return _itemID.Value;
			}
		}

		#endregion
	}
}
