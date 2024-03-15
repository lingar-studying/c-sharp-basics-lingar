using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class ToStringDemo
    {

        private int x = 10;

        public override string ToString()
        {

            Console.WriteLine("Here I can create string of the value that I want for the class object");
            return "this is to string demo | x = " + x;
        }
    }
}
