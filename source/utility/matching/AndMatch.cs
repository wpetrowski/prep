using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.utility.matching
{
	public class AndMatch<Item> : IMatchA<Item>
	{
		private readonly IMatchA<Item> _left;
		private readonly IMatchA<Item> _right;

		public AndMatch(IMatchA<Item> left, IMatchA<Item> right)
		{
			_left = left;
			_right = right;
		}

		public bool matches(Item item)
		{
			return _left.matches(item) && _right.matches(item);
		}
	}
}
