using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PardalAppPDV
{
    static internal class Maths
    {
        public static int percent(double per, double amount)
        {
            int value = 0;

            value = Convert.ToInt32((amount * per) / 100);   

            return value;
        }
    }
}
