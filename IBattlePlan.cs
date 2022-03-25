using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	interface IBattlePlan
	{
		bool MatchesPlan(Alien good, Alien bad);
		long ComputeDamage(Alien good, Alien bad);
	}
}
