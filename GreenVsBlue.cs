using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class GreenVsBlue : IBattlePlan
    {
        public bool MatchesPlan(Alien good, Alien bad)
        {
            if (good.getAColor() != "Green" || good.getAAlign() != true || bad.getAColor() != "Blue" || bad.getAAlign() != false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public long ComputeDamage(Alien good, Alien bad)
        {
            long damage = good.getAAge() * 16;
            return damage;
        }
    }
}
