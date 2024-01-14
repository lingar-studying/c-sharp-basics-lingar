using System;
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

        public static void Test2()
        {

            Employee employee = new Employee("Regular Employee");
            Employee nurse = new Nurse("Ruti", "Qualified");
            Employee doctor = new Doctor("Izhak", "Heart");
            Employee supervisor = new Supervisor("Moshe", "Brain", new Employee[] { employee, nurse, doctor }, 10);
            Employee employee2 = new Employee("Regular Employee");
            Employee nurse2 = new Nurse("Rahel", "Qualified");
            Employee doctor2 = new Doctor("Avi", "Heart");
            Employee supervisor2 = new Supervisor("David", "Brain", new Employee[] { employee, nurse, doctor }, 10);
            Employee nurse3 = new Nurse("Lea", "bbb");


            //Employee[] all = { employee, nurse, doctor, supervisor };
            Employee[] all2 = new Employee[250];


            try
            {
                AllEmployees allEmployees1 = new AllEmployees(all2, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine("the following exception happend: " + ex.Message);
            }
            Employee[] all3 = new Employee[200];

            try
            {
                AllEmployees allEmployees1 = new AllEmployees(all3, 10);
                Console.WriteLine("allEmployees1.NumSupervisors() = \n"+ allEmployees1.NumSupervisors());
                Console.WriteLine("GetNewNurse.GetNewNurse() = \n" + allEmployees1.GetNewNurse("Qualified"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("the following exception happend: " + ex.Message);
            }

            Employee[] all4 = {nurse2,  supervisor, nurse, supervisor2, nurse3, doctor2, employee, employee2, doctor };

            try
            {
                AllEmployees allEmployees1 = new AllEmployees(all4, 10);
                Console.WriteLine("allEmployees1.NumSupervisors() = \n" + allEmployees1.NumSupervisors());
                Console.WriteLine("GetNewNurse.GetNewNurse() = \n" + allEmployees1.GetNewNurse("Qualified"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("the following exception happend: " + ex.Message);
            }
        }

    }
}
