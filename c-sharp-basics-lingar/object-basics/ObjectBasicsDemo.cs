using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class ObjectBasicsDemo
    {
        public static void BoxerDemo()
        {
            //int x      = 10;
            Boxer boxer1 = new Boxer();
            boxer1.name = "Mike Tyson";
            boxer1.weight = 100;
            boxer1.isHeavyWeight = true;
            //public int[] statistics = new int[3];//winnings, loses, knockout
            boxer1.statistics[0] = 50;
            boxer1.statistics[1] = 6;
            boxer1.statistics[2] = 44;

            boxer1.DisplayBoxerData();


            Boxer boxer2 = new Boxer();
            boxer2.name = "Mohamed Ali";
            boxer2.weight = 120;
            boxer2.isHeavyWeight = true;
            //public int[] statistics = new int[3];//winnings, loses, knockout
            boxer2.statistics[0] = 40;
            boxer2.statistics[1] = 3;
            boxer2.statistics[2] = 38;

            boxer2.DisplayBoxerData();

            boxer2.ReduceWeight(50);

            boxer2.DisplayBoxerData();




        }

    }
}
