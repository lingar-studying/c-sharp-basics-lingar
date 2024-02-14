using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.test_solution
{
    internal class Solution3
    {
        public static void TestSolution()
        {
            First[] arr = new First[5];
            arr[0] = new First(13);
            arr[1] = new First();
            arr[2] = new Second();
            arr[3] = new Second(5, arr[0]);
            arr[4] = new Second(2, 3.7, arr[2]);

            //polymorphism:
            foreach(First f in arr)
            {
                Console.WriteLine("Element = " + f);
            }
        }
    }

    public class First
    {
        protected int num;

        public First() { num = 10; }
        public First(int num) { this.num = num; }

        public override string ToString()
        {
            return string.Format("First = [num = {0}]", num);
        }
    }
    public class Second : First
    {
        private double x;
        private First f;

        public Second()
        {
            x = 1.1;
        }
        public Second(int num, First first) : base(num)//you can also assign directly to num, but this seems to be more efficient
        {
            //this.num = num; //possible 
            x = 5.5;
            f = first;
        }

        public Second(int y, double z, First first) {

            num = 5;
            x = 5.5;
            f = first;
            //Second s = (Second)f;//downcasting
        }
        public override string ToString()
        {
            //return base.ToString() + String.Format("Second = [x = {0} | f = {1}]", x, f != null? f : "null");//won't work in older versions then 6
       
            return base.ToString() + String.Format("Second = [x = {0} | f = {1}]", x, f != null? f +"" : "null");
        }

    }

    

}
