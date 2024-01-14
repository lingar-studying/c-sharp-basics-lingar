using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class Employee
    {
        private int num = serialNumber++;
        private string name;
        private static int serialNumber = 1;

        public Employee(string name)
        {
            this.name = name;
        }



        //https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions#string-data
        //For test later - not need for the test! 
        public override string  ToString()
        {
            return $"name = {name}, num = {num}";
        }

        public int GetNum() { return num; }


    }
}
