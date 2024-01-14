using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class Nurse: Employee
    {
        private string type;

        public Nurse(string name, string type): base(name)
        {
            this.type = type;
        }
    }
}
