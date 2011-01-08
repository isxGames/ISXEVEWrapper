using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isxProfiler
{
	static class Extensions
	{
		public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach (var item in collection)
				action(item);
		}

		public static IEnumerable<int> Range(this int max)
		{
			for (int i = 0; i < max; i++)
				yield return i;
		}

		public static void Times(this int i, Action<int> action)
		{
			i.Range().Each(action);
		}
	}

}
