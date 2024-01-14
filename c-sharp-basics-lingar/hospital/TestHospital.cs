﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class TestHospital
    {
        public static void Test1()
        {
            Employee employee = new Employee("Regular Employee");
            Employee nurse = new Nurse("Ruti", "Qualified");
            Employee doctor = new Doctor("Avi", "Heart");
            Employee supervisor = new Supervisor("David", "Brain", new Employee[] { employee, nurse, doctor }, 10);

            Employee[] all = {employee, nurse, doctor, supervisor};

            for(int i = 0; i < all.Length; i++)
            {
                Console.WriteLine(all[i]);
            }
        }
    }
}
