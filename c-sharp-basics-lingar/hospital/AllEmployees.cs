using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class AllEmployees
    {
        private Employee[] arr = new Employee[200];
        private int current;

        public int NumSupervisors()
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("running... " + i);
                if(arr[i] is Supervisor)
                {
                    count++;
                }
            }
            return 0;
        }
        public Nurse? GetNewNurse()
        {
            Nurse newNurse = null;

            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.WriteLine("running... " + i);
                if (arr[i] is Nurse && (newNurse == null || newNurse.GetNum() < arr[i].GetNum()))
                {                 
                    newNurse = (Nurse)arr[i];
                }
            }
            return GetNewNurse == null ? null : newNurse;

        }
    }
}
