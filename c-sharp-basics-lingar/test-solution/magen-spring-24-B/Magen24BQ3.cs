using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_B
{
    internal class Magen24BQ3
    {

      
        public static void Demo()
        {
            AMagen24BQ3[] array = new AMagen24BQ3[4];


            array[0] = new CMagen24BQ3();
            array[1] = new BMagen24BQ3();
            array[2] = new AMagen24BQ3();
            array[3] = new BMagen24BQ3();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
                array[i].Method(i + 2);
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
        }
    }

    public class AMagen24BQ3
    {
        protected int x;
        public AMagen24BQ3()
        {
            x = 0;
        }
        public virtual void Method(int num)
        {
            x += num;
        }
        public override string ToString()
        {
            return "" + x;
        }
    }// end of class A
    public class BMagen24BQ3 : AMagen24BQ3
    {
        private int y;
        public BMagen24BQ3()
        {
            y = 1;
        }
        public override void Method(int num)
        {
            x -= num;
            y += num;
        }
        public override string ToString()
        {
            return "" + x + "." + y;
        }
    }// end of class B

    public class CMagen24BQ3 : AMagen24BQ3
    {
        private int y;
        public CMagen24BQ3()
        {
            y = 10;
        }
        public override void Method(int num)
        {
            x += num;
            y += num;
        }
        public override string ToString()
        {
            return "" + x + "/" + y;
        }
    } // end of class C

    
       
    

}
