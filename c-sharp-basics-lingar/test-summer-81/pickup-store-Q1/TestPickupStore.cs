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
            Tablet t2 = t;
            Tablet t3 = new Tablet("lingar", "5782", 'I', 10.7, 2004.64);


            Tablet t4 = new Tablet("lingar", "5782", 'W', 10.7, 2224.64);

            Tablet t5 = new Tablet("lingarV3", "5782", 'A', 10.7, 2004.64);

            Tablet t6 = new Tablet("lingarV3", "5782", 'A', 10.7, 2004.64);


            Console.WriteLine("Tablet t = " );

            Console.WriteLine("IS same ? - " + t.IsSame(t3));

            Store store = new Store();

            store.AddTablet(t);

            Console.WriteLine("Store = " + store);

            store.AddTablet(t3);

            Console.WriteLine("Store = " + store);

            store.AddTablet(t4);//only update price to t1. 

            Console.WriteLine("Store = " + store);


            store.AddTablet(t5);//only update price to t1. 

            store.AddTablet(t6);//only update price to t1. 

            Console.WriteLine("Store = " + store);


        }
    }
}
