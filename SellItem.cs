using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class SellItem : LavishScriptObject
    {
		public SellItem(LavishScriptObject copy) : base(copy)
        {

        }

        #region LS Members

		private string _Name;
		public string Name
		{
			get { return _Name ?? (_Name = this.GetString("Name")); }
		}

		private string _Quantity;
		public string Quantity
		{
			get { return _Quantity ?? (_Quantity = this.GetString("Quantity")); }
		}

		private string _AskPrice;
		public string AskPrice
		{
			get { return _AskPrice ?? (_AskPrice = this.GetString("AskPrice")); }
		}

		private int? _BestJumps;
		public int BestJumps
		{
			get
			{
				if (_BestJumps == null)
					_BestJumps = this.GetInt("BestJumps");
				return _BestJumps.Value;
			}
		}

		private double? _SalesTax;
		public double SalesTax
		{
			get
			{
				if (_SalesTax == null)
					_SalesTax = this.GetDouble("SalesTax");
				return _SalesTax.Value;
			}
		}

		private double? _TotalAmount;
		public double TotalAmount
		{
			get
			{
				if (_TotalAmount == null)
					_TotalAmount = this.GetDouble("TotalAmount");
				return _TotalAmount.Value;
			}
		}

		private double? _AveragePrice;
		public double AveragePrice
		{
			get
			{
				if (_AveragePrice == null)
					_AveragePrice = this.GetDouble("AveragePrice");
				return _AveragePrice.Value;
			}
		}

		private double? _BestPrice;
		public double BestPrice
		{
			get
			{
				if (_BestPrice == null)
					_BestPrice = this.GetDouble("BestPrice");
				return _BestPrice.Value;
			}
		}

		private double? _BestVolumeRemaining;
		public double BestVolumeRemaining
		{
			get
			{
				if (_BestVolumeRemaining == null)
					_BestVolumeRemaining = this.GetDouble("BestVolumeRemaining");
				return _BestVolumeRemaining.Value;
			}
		}

		private Int64? _ItemID;
		public Int64 ItemID
		{
			get
			{
				if (_ItemID == null)
					_ItemID = this.GetInt64("ItemID");
				return _ItemID.Value;
			}
		}

        #endregion

        #region LS Methods

		public bool SetAskPrice(double price)
		{
			Tracing.SendCallback("SellItem.SetAskPrice", price);
			return ExecuteMethod("SetAskPrice", price.ToString());
		}

		public bool SetQuantity(int quantity)
		{
			Tracing.SendCallback("SellItem.SetQuantity", quantity);
			return ExecuteMethod("SetQuantity", quantity.ToString());
		}

        #endregion
    }
}
