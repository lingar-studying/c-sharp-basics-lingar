using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic
{
    internal class AlgoDraft
    {
        public static void Demo()
        {
            Console.WriteLine("Algo Demo");
            int x = 5;
            int y = 50;
            Random rand = new Random();
            int num = rand.Next(x,y + 1);
            Console.WriteLine("random between {0} to {1} ---> {2}", x, y, num);
        }
    }
}
