using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_22_A
{
    public class Q4Summer22A
    {



        public static void PrintByYear(ChildSummer22A[] arr, int year)
        {
            int countMales = 0, countFemales = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j].GetYear() == year)
                {
                    if (arr[j].GetGender() == 'm')
                        countMales++;
                    else
                        countFemales++;
                }
            }
            Console.WriteLine("at year {0} number of males = {1}, numbers of females = {2}"
                    , year, countMales, countFemales);

        }
        public static void PrintByMonth(ChildSummer22A[] arr)
        {
           
            for(int i =0; i <=11; i++)
            {
                int countMales = 0, countFemales = 0;
                for (int j =0; j < arr.Length; j++)
                {
                    if(arr[j].GetMonth() == i)
                    {
                        if (arr[j].GetGender() == 'm')
                            countMales++;
                        else
                            countFemales++;
                    }
                }
                Console.WriteLine("at month {0} number of males = {1}, numbers of females = {2}"
                    , (i+1), countMales, countFemales);
            }
        }
    }

    //Child
    public class ChildSummer22A
    {
        private string name = "";
        private char gender = ' ';
        private int year = 0;
        private int month = 0;

        public int GetYear() { return year; }
        public int GetMonth() { return month; }
        public char GetGender() { return gender; }



    }
}
