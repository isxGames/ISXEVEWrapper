using System;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Extensions
{
	public static class LavishScriptObjectExtensions
	{
		public static string GetString(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : lavishScriptObject.GetValue<string>();
			}
		}

		public static string GetString(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : lavishScriptObject.GetValue<string>();
			}
		}

		public static Int64 GetInt64(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<Int64>();
			}
		}

		public static UInt64 GetUInt64(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? 0 : lavishScriptObject.GetValue<UInt64>();
			}
		}

		public static Int64 GetInt64(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<Int64>();
			}
		}

		public static float GetFloat(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<float>();
			}
		}

		public static float GetFloat(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<float>();
			}
		}

		public static double GetDouble(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<double>();
			}
		}

		public static double GetDouble(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<double>();
			}
		}

		public static int GetInt(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
			}
		}

		public static int GetInt(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
			}
		}

		public static bool GetBool(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? false : lavishScriptObject.GetValue<bool>();
			}
		}

		public static bool GetBool(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? false : lavishScriptObject.GetValue<bool>();
			}
		}

		public static Int64? GetNullableInt64(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (Int64?)lavishScriptObject.GetValue<Int64>();
			}
		}

		public static Int64? GetNullableInt64(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (Int64?)lavishScriptObject.GetValue<Int64>();
			}
		}

		public static float? GetNullableFloat(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (float?)lavishScriptObject.GetValue<float>();
			}
		}

		public static float? GetNullableFloat(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (float?)lavishScriptObject.GetValue<float>();
			}
		}

		public static double? GetNullableDouble(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (double?)lavishScriptObject.GetValue<double>();
			}
		}

		public static double? GetNullableDouble(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (double?)lavishScriptObject.GetValue<double>();
			}
		}

		public static int? GetNullableInt(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (int?)lavishScriptObject.GetValue<int>();
			}
		}

		public static int? GetNullableInt(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (int?)lavishScriptObject.GetValue<int>();
			}
		}

		public static bool? GetNullableBool(this ILSObject obj, string member)
		{
			using (var lavishScriptObject = obj.GetMember(member))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (bool?)lavishScriptObject.GetValue<bool>();
			}
		}

		public static bool? GetNullableBool(this ILSObject obj, string member, params string[] args)
		{
			using (var lavishScriptObject = obj.GetMember(member, args))
			{
				return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? null : (bool?)lavishScriptObject.GetValue<bool>();
			}
		}
	}
}
