using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing3
{
	[Flags]
	public enum Zone
	{
		None = 0,
		Corrupt = 1,
		Crimson = 2,
		Holy = 4,
		Snow = 8,
		Jungle = 16,
		Shroom = 32,
		Dungeon = 64,
		Desert = 128
	}
}
