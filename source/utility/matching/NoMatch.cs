using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.utility.matching
{
	public class NoMatch<Item> : IMatchA<Item>
	{
		public bool matches(Item item)
		{
			return false;
		}
	}
}
