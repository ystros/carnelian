using System;
using System.Collections.Generic;

namespace Carnelian
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<TValue> Each<TValue>(this IEnumerable<TValue> values, Action<TValue> block)
		{
			foreach(var value in values)
			{
				block(value);
			}
			return values;
		}
	}
}

