using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class RedVsRed : IBattlePlan
    {
        public bool MatchesPlan(Alien good, Alien bad)
        {
            if(good.getAColor() != "Red" || good.getAAlign() != true || bad.getAColor() != "Red" || bad.getAAlign() != false)
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
            long damage = good.getAAge() * 8;
            return damage;
        }
    }
}
