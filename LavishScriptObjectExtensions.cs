using System;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;

namespace Extensions
{
	public static class LavishScriptObjectExtensions
	{
		public static string GetStringFromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : lavishScriptObject.GetValue<string>();
			}
		}

		public static string GetStringFromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : lavishScriptObject.GetValue<string>();
			}
		}

		public static Int64 GetInt64FromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<Int64>();
			}
		}

		public static Int64 GetInt64FromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<Int64>();
			}
		}

		public static float GetFloatFromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<float>();
			}
		}

		public static float GetFloatFromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<float>();
			}
		}

		public static double GetDoubleFromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<double>();
			}
		}

		public static double GetDoubleFromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<double>();
			}
		}

		public static int GetIntFromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
			}
		}

		public static int GetIntFromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
			}
		}

		public static bool GetBoolFromLSO(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? false : lavishScriptObject.GetValue<bool>();
			}
		}

		public static bool GetBoolFromLSO(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? false : lavishScriptObject.GetValue<bool>();
			}
		}
	}
}
