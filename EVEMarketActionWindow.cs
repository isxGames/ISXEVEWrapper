using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	public class EveMarketActionWindow : EVEWindow
	{
		public EveMarketActionWindow(LavishScriptObject obj) : base(obj)
		{
		}

		#region LavishScript Members

		//private EVEUISingleLineEdit _BidPrice;
		//public EVEUISingleLineEdit BidPrice
		//      {
		//	//get
		//	//{
		//	//	if (_BidPrice == null)
		//	//	    _BidPrice = this.getEVEUISingleLineEdit("BidPrice");
		//	//	return _BidPrice.Value;
		//	//}
		//}

		public EVEUISingleLineEdit BidPrice()
		{
			return new EVEUISingleLineEdit(GetMember("BidPrice"));
		}

		public EVEUILabel BidPricePercentageComparison()
		{
			return new EVEUILabel(GetMember("BidPricePercentageComparison"));
		}

		private double? _RegionalAverage;
		public double RegionalAverage
		{
			get
			{
				if (_RegionalAverage == null)
					_RegionalAverage = this.GetDouble("RegionalAverage");
				return _RegionalAverage.Value;
			}
		}

		/// <summary>
		/// Wraps the BestRegional member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUILabel BestRegional()
		{
			return new EVEUILabel(GetMember("BestRegional"));
		}

		/// <summary>
		/// Wraps the BestMatchable member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUILabel BestMatchable()
		{
			return new EVEUILabel(GetMember("BestMatchable"));
		}

		/// <summary>
		/// Wraps the Quantity member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUISingleLineEdit Quantity()
		{
			return new EVEUISingleLineEdit(GetMember("Quantity"));
		}

		/// <summary>
		/// Wraps the QuantityMin member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUISingleLineEdit QuantityMin()
		{
			return new EVEUISingleLineEdit(GetMember("QuantityMin"));
		}

		/// <summary>
		/// Wraps the Duration member of the EVEUICombo datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUICombo Duration()
		{
			return new EVEUICombo(GetMember("Duration"));
		}

		/// <summary>
		/// Wraps the Range member of the EVEUICombo datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUICombo Range()
		{
			return new EVEUICombo(GetMember("Range"));
		}

		/// <summary>
		/// Wraps the Fee member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUISingleLineEdit Fee()
		{
			return new EVEUISingleLineEdit(GetMember("Fee"));
		}

		/// <summary>
		/// Wraps the Total member of the EVEMarketActionWindow datatype.
		/// </summary>
		/// <returns></returns>
		public EVEUILabel Total()
		{
			return new EVEUILabel(GetMember("Total"));
		}

		private bool? _IsReady;
		public bool IsReady
		{
			get
			{
				if (_IsReady == null)
					_IsReady = this.GetBool("IsReady");
				return _IsReady.Value;
			}
		}

		#endregion

		#region LavishScript Methods

		/// <summary>
		/// Wraps the Buy method of the EveSellItemsWindow datatype.
		/// </summary>
		/// <returns></returns>
		public bool Buy()
		{
			Tracing.SendCallback("EVEMarketActionWindow.Buy");
			return ExecuteMethod("Buy");
		}

		/// <summary>
		/// Wraps the Cancel method of the EveSellItemsWindow datatype.
		/// </summary>
		/// <returns></returns>
		public bool Cancel()
		{
			Tracing.SendCallback("EVEMarketActionWindow.Cancel");
			return ExecuteMethod("Cancel");
		}

		#endregion
	}
}
