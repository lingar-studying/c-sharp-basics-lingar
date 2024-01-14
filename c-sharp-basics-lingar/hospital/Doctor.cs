using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class Doctor: Employee
    {
        private string specialization;
        public Doctor(string name, string specialization) : base(name)
        {
            this.specialization = specialization;
        }
    }
}
