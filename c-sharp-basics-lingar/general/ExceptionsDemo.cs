using c_sharp_basics_lingar.object_basics;
using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class ExceptionsDemo
    {

        public static void Demo()
        {
            Console.WriteLine("Exception Demo");

            int[] arr = new int[2];
            Pen pen = null;
            //handling excpetion
            try
            {
                //pen.Name = "something";
                //arr[10] = 11;
                //int x = 0;
                //int y = x / 0;
                Console.WriteLine("all good");
            }
            

            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("out of range occured");
            }

            catch (NullReferenceException ex)
            {

                Console.WriteLine("NullReferenceException occured");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception occured");
            }

            //not must
            finally
            {
                Console.WriteLine("Always I will happen");
            }


            ThrowsException throwsException = new ThrowsException(20);

            //will throw exception
            //ThrowsException throwsException2 = new ThrowsException(200);

            try
            {
                ThrowsException throwsException2 = new ThrowsException(200);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ThrowsException throwsException3 = null;

            try
            {
                int rand = new Random().Next(0, 6000);
                throwsException3 = new ThrowsException(rand);
            }
            catch (Exception ex)
            {
                throwsException3 = new ThrowsException(2);

                //throw;
            }
            Console.WriteLine(throwsException3);

            throwsException3.ThrowCustom(2);


            throwsException3.ThrowCustom(6);

            Console.WriteLine("after exception");



        }

    }

    public class ThrowsException
    {
        private int x;
        public override string ToString()
        {
            return "x = " + x;
        }
        public ThrowsException(int x)
        {
            if(x > 50)
            {
                throw new Exception("Not more then 50");
            }
            this.x = x;
        }

        public void ThrowCustom(int x)
        {
            if (x > 5)
            {
                throw new MyException();
            }
        }
    }

    //[Serializable]
    public class MyException : Exception
    {
        public MyException() : base("My specific Exception") { }



    }
}
