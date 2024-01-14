using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class Supervisor: Doctor
    {
        private Employee[] arr;
        private int current;

        public Supervisor(string name, string specialization, 
            Employee[] arr, int current): base(name, specialization)
        {
            this.arr = arr;
            this.current = current;
        }
    }
}
