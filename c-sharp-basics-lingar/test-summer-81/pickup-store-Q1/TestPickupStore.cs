using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.test_summer_81.pickup_store_Q1
{
    internal class TestPickupStore
    {

        public static void runMe()
        {
            Tablet t = new Tablet("lingar", "5782", 'W', 10.7, 2004.64 );

            Console.WriteLine("Tablet t = " + t);
        }
    }
}
