using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.utility.matching
{
	public static class MatchFactory
	{
		public static IMatchA<Item> CreateMatcher<Item>(Criteria<Item> condition)
		{
			return new CriteriaMatch<Item>(condition);
		}
	}
}
