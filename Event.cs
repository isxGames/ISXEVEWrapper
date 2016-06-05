using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace EVE.ISXEVE
{
	/// <summary>
	/// The Event class.
	/// </summary>
	public class Event
	{
		#region .Net Events
		//public event System.EventHandler<LSEventArgs> EVEEvent;
		#endregion

		#region .Net Event Raisers
		/*
		protected virtual void EVE_EVEEvent(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = ReceivedNotice;
			if (temp != null)
				temp(Sender, e);
		}
		*/
		#endregion

		/// <summary>
		/// Event destructor.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1821:RemoveEmptyFinalizers")]
		~Event()
		{
			//LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EVE_EVEEvent"), EVE_Event);

		}

		/// <summary>
		/// Event constructor.
		/// </summary>
		public Event()
		{
			//LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EVE_EVEEvent"), IRC_ReceivedNotice);
		}
	}
}
