using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_20_A
{
    public class AlgoSummer20AQ7
    {
        public static void Demo()
        {

            Truck truck1 = new Truck("20-408-04", "Yossi", 10);
            //truck1.truckId = "ssss";
            truck1.SetTruckId("other truck id ");
            truck1.SetIsFree(true);
            Truck truck2 = new Truck("24-508-04", "Avi", 30);
            Truck truck3 = new Truck("30-408-04", "David", 5);
            Truck truck4 = new Truck("30-008-04", "Donald", 8);
            Truck truck5 = new Truck("40-408-04", "Bugs", 43);
            Truck truck6 = new Truck("55-408-04", "Joe", 2);
            Truck truck7 = new Truck("97-408-04", "Paul", 53);
            Truck[] trucks = { truck1, truck2, truck3, truck4, truck5, truck6, truck7 };
            truck5.SetIsFree(false);
            Console.WriteLine("truck1 = " + truck1);
            truck7.SetIsFree(false);
            PrintFreeDrivers(trucks);
            string resultOfTheQuestion = GetMaxFreeTruck(trucks);

            Console.WriteLine("the result is: " + resultOfTheQuestion);
           foreach(Truck t in trucks)
            {
                //Console.WriteLine(t);
                
            }


        }//end of demo

        public static void PrintFreeDrivers(Truck[] trucks)
        {
            for(int i=0; i< trucks.Length; i++)
            {

                if(trucks[i].GetIsFree() && trucks[i].GetNumStorage() >= 7)
                {
                    Console.WriteLine(trucks[i].GetDriverName());

                }
            }
        }

        public static string GetMaxFreeTruck(Truck[] trucks)
        {

            string result = "unable to service";
            int lastFound = 0;
            for (int i = 0; i < trucks.Length; i++)
            {

                if (trucks[i].GetIsFree() && trucks[i].GetNumStorage() > lastFound)
                {
                    result = trucks[i].GetTruckId();
                    lastFound = trucks[i].GetNumStorage();
                }
               
            }
            return result;
        }
    }

    public class Truck
    {

        private string truckId = "";
        private string driverName = "";
        private int numStorage = 0;
        private bool isFree = false;

        public Truck(string truckId, string driverName, int numStorage)
        {
            this.truckId = truckId;
            this.driverName = driverName;
            this.numStorage = numStorage;
            this.isFree = true;
        }

        //public Truck(string truckId, string driverName, int numStorage)
        //{
        //    //....

        //}
        public void SetTruckId(string truckId)
        {
            this.truckId = truckId;
        }
        public string GetTruckId()
        {
            return truckId;
        }
        public string GetDriverName()
        {
            return driverName;
        }

        public int GetNumStorage()
        {
            return numStorage;
        }
        public bool GetIsFree()
        {
            return isFree;
        }

        public void SetIsFree(bool isFree)
        {
            this.isFree = isFree;
        }

        public override string ToString()
        {
            return string.Format("Truck=[truckId = {0}, driverName = {1}, numStorage = {2}, isFree = {3}]", 
                
                truckId, driverName, numStorage, isFree);

        }


       
        //- מספר רישוי – truckId string.
//- שם נהג – driverName string.
///- מספר מקומות אחסון עבור המטען – numStorage int.
//- האם המשאית פנויה להובלה? – isFree bool.
    }
}
