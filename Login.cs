using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
  /// Wrapper for the login data type.
	/// </summary>
  public class Login : LavishScriptObject
	{
		#region Constructors
    /// <summary>
    /// Login copy constructor.
    /// </summary>
    /// <param name="Obj"></param>
		public Login(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Check with LavishScriptObject.IsNullOrInvalid. If its not valid,
		/// you're not at the login screen.
		/// </summary>
		public Login()
			: base(LavishScript.Objects.GetObject("Login"))
		{
		}
		#endregion

		#region Members
    /// <summary>
    /// Wrapper for the IsConnecting member of the login type.
    /// </summary>
		public bool IsConnecting
		{
			get
			{
				return GetMember<bool>("IsConnecting");
			}
		}

    /// <summary>
    /// Wrapper for the ServerStatus member of the login type.
    /// </summary>
		public string ServerStatus
		{
			get
			{
				return GetMember<string>("ServerStatus");
			}
		}

    /// <summary>
    /// Wrapper for the ServerPopulation member of the login type.
    /// </summary>
		public int ServerPopulation
		{
			get
			{
				return GetMember<int>("ServerPopulation");
			}
		}
		#endregion

		#region Methods
    /// <summary>
    /// Wrapper for the SetUsername method of the login type.
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
		public bool SetUsername(string username)
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Login.SetUsername", string.Empty);
			return ExecuteMethod("SetUsername", username);
		}

    /// <summary>
    /// Wrapper for the SetPassword method of the login type.
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
		public bool SetPassword(string password)
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Login.SetPassword", string.Empty);
			return ExecuteMethod("SetPassword", password);
		}

    /// <summary>
    /// Wrapper for the Connect method of the login type.
    /// </summary>
    /// <returns></returns>
		public bool Connect()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Login.Connect", string.Empty);
			return ExecuteMethod("Connect");
		}
		#endregion
	}
}
