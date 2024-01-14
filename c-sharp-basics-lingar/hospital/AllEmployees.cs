using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class AllEmployees 
    {
        private Employee[] arr;//== new Employee[200] --> it's not efficient and also not blocking the option to replcae the value to bigger array. 
        private int current;
        private const int MAX_EMPLOYEES = 200;

        public void setArr(Employee[] arr)
        {
            if (arr.Length > MAX_EMPLOYEES)
            {
                //You don't need to do this, it's only for test. You can do return instead. 
                throw new Exception("Hospital can't contain more employees than " + MAX_EMPLOYEES);
            }
            this.arr = arr;
        }
        public AllEmployees(Employee[] arr, int current)
        {

            //this.arr = arr;
            setArr(arr);
            this.current = current;
        }
        public int NumSupervisors()
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("running... " + i);
                if(arr[i] is Supervisor)
                {
                    count++;
                }
            }
            return count;
        }
        public Nurse? GetNewNurse(string type)
        {
            Nurse newNurse = null;

            for (int i = arr.Length-1; i >=0; i--)
            {
                //Console.WriteLine("running... " + i + "!" );
                if (arr[i] is Nurse && ((Nurse) arr[i]).Type.Equals(type) &&  (newNurse == null || newNurse.GetNum() < arr[i].GetNum()))
                {                 
                    newNurse = (Nurse)arr[i];
                }
            }
            return newNurse == null ? null : newNurse;

        }
    }
}
