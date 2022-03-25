using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BattlePlanContext
    {
        public List<IBattlePlan> Plans = new List<IBattlePlan>();

        public BattlePlanContext()
        {
            Plans.Add(new RedVsRed());
            Plans.Add(new RedVsBlue());
            Plans.Add(new RedVsGreen());
            Plans.Add(new BlueVsRed());
            Plans.Add(new BlueVsBlue());
            Plans.Add(new BlueVsGreen());
            Plans.Add(new GreenVsRed());
            Plans.Add(new GreenVsBlue());
            Plans.Add(new GreenVsGreen());
        }
    }
}
