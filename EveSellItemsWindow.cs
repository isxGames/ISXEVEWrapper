using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EveSellItemsWindow : EVEWindow
    {
        public EveSellItemsWindow(LavishScriptObject obj) : base(obj)
        {
        }

        #region LavishScript Members

		private int? _Duration;
		public int Duration
		{
			get
			{
				if (_Duration == null)
					_Duration = this.GetInt("Duration");
				return _Duration.Value;
			}
		}

		private int? _RemainingOrders;
		public int RemainingOrders
		{
			get
			{
				if (_RemainingOrders == null)
					_RemainingOrders = this.GetInt("RemainingOrders");
				return _RemainingOrders.Value;
			}
		}

		private int? _NumItems;
		public int NumItems
		{
			get
			{
				if (_NumItems == null)
					_NumItems = this.GetInt("NumItems");
				return _NumItems.Value;
			}
		}

		private string _BrokersFee;
		public string BrokersFee
		{
			get { return _BrokersFee ?? (_BrokersFee = this.GetString("BrokersFee")); }
		}

		private string _TotalAmount;
		public string TotalAmount
		{
			get { return _TotalAmount ?? (_TotalAmount = this.GetString("TotalAmount")); }
		}

		private string _SalesTax;
		public string SalesTax
		{
			get { return _SalesTax ?? (_SalesTax = this.GetString("SalesTax")); }
		}


		/// <summary>
		/// Wraps the Item member of the EveSellItemsWindow datatype.
		/// </summary>
		/// <param name="Index"># is between 1 and 'NumItems'</param>
		/// <returns></returns>
		public SellItem Item(int Index)
		{
			return new SellItem(GetMember("Item", Index.ToString(CultureInfo.CurrentCulture)));
		}

        #endregion

        #region LavishScript Methods

		/// <summary>
		/// Wraps the SetDuration method of the EveSellItemsWindow datatype.
		/// </summary>
		/// <param name="duration">duration is the number of days for the order.  Only use one of the following: 0,1,3,7,14,30,90</param>
		/// <returns></returns>
		public bool SetDuration(int duration)
		{
			Tracing.SendCallback("EveSellItemsWindow.SetDuration", duration);
			return ExecuteMethod("SetDuration", duration.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wraps the Sell method of the EveSellItemsWindow datatype.
		/// </summary>
		/// <returns></returns>
		public bool Sell()
		{
			Tracing.SendCallback("EveSellItemsWindow.Sell");
			return ExecuteMethod("Sell");
		}

        #endregion
    }
}
