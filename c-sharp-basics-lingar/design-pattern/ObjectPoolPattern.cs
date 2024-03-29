using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.design_pattern
{
    public class ObjectPoolPattern
    {

        public static void Demo()
        {
            // declaring an object pool holding class Student objects
            objectPool<Employee> objPool = new objectPool<Employee>();

            Employee obj = objPool.getObj();

            Console.WriteLine("First object assigned");
            Employee obj2 = objPool.getObj();
            Console.WriteLine("Second object assigned");
            int count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);
            objPool.releaseObj(obj);
            Console.WriteLine("First object released back into the pool");
            count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);
            Employee obj3 = objPool.getObj();
            Console.WriteLine("Third object assigned");
            count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);
            objPool.releaseObj(obj2);
            Console.WriteLine("Second object released back into the pool");
            count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);
            objPool.releaseObj(obj3);
            Console.WriteLine("Third object released back into the pool");
            count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);
            Employee obj4 = objPool.getObj();
            Console.WriteLine("Fourth object assigned");
            count = objPool.getCount();
            Console.WriteLine("Current count of pool: " + count);

            Employee obj5 = objPool.getObj();
            Console.WriteLine("Current count of pool: " + count);

            Employee obj6 = objPool.getObj();
            Console.WriteLine("Current count of pool: " + count);


            Employee obj7 = objPool.getObj();
            Console.WriteLine("Current count of pool: " + count);

            Employee obj8 = objPool.getObj();
            Console.WriteLine("Current count of pool: " + count);

            Employee obj9 = objPool.getObj();
            Console.WriteLine("Current count of pool: " + count);

            Employee obj10 = objPool.getObj();





        }
    }

    public class objectPool<T> where T : new()
    {
        // list to hold the objects
        private List<T> objectsList = new List<T>();
        //counter keeps track of the number of objects in the pool
        private int counter = 0;
        // max objects allowed in the pool
        private int maxObjects = 5;

        // returns the number of objects in the pool
        public int getCount()
        {
            return counter;
        }

        // method to get the object from the pool
        public T getObj()
        {
            //Declare item
            T objectItem;
            //Check if the pool has any objects
            //If yes, remove the first object and return it
            // also, decrease the count
            if (counter > 0)
            {
                objectItem = objectsList[0];
                objectsList.RemoveAt(0);
                counter--;
                return objectItem;
            }
            //If the pool has no objects, create a new one and return it
            else
            {
                T obj = new T();
                return obj;
            }
        }

        // method to return the object to the pool
        // If the counter is less than the max objects allowed, add the object to the pool
        //also, increment counter
        public void releaseObj(T item)
        {
            if (counter < maxObjects)
            {
                objectsList.Add(item);
                counter++;
            }
        }

    }

    class Employee
    {
        private string firstName;
        private int employeeID;

        public string getName()
        {
            return firstName;
        }

        public void setName(string name)
        {
            firstName = name;
        }

        public int getID()
        {
            return employeeID;
        }

        public void setID(int ID)
        {
            employeeID = ID;
        }
    }

}
