using System;

namespace College
{
    class Program
    {
        public static void result(Subject[] arr)
        {
            int sum = 0;
            int task = int.Parse(Console.ReadLine());
            int passesGr = int.Parse(Console.ReadLine()); 
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i].getPoints(task,passesGr);
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
