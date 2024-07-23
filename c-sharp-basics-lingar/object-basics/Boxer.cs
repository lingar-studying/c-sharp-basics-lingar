using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class Boxer
    {
        //properties
        public string name = "";
        public int weight = 0;
        public bool isHeavyWeight = false;
        public int[] statistics = new int[3];//winnings, loses, knockout

        public void DisplayBoxerData()
        {
            Console.WriteLine($"Boxer name= {name}, weighs {weight} K\"G,\n" +
                $"heavy weight? - {isHeavyWeight},\n" +
                $"Statistics: winnings: {statistics[0]}, loses: {statistics[1]}, knockouts: {statistics[2]}");
        }

        public void ReduceWeight(int reduce)
        {
            weight -= reduce;
            if(weight < 90)
            {
                isHeavyWeight = false;
            }
        }



    }
}
