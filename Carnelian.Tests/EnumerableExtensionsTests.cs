using System.Collections.Generic;
using NUnit.Framework;

namespace Carnelian.Tests
{
	namespace EnumerableExtensionsTests
	{
		[TestFixture]
		public class EachMethod
		{
			int[] array = new int[] { 1, 2, 3, 4, 5 };
			
			[Test]
			public void it_calls_the_block_for_each_item()
			{
				var results = new List<int>();
				
				array.Each(x => { results.Add(x); });
				
				Assert.AreEqual(array, results.ToArray());
			}
			
			[Test]
			public void it_returns_the_original_enumerable()
			{
				var returnValue = array.Each(x => {});
				Assert.AreSame(array, returnValue);
			}
		}
	}
}

