using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * Next time:
 * 
 * In the current version it's not working. 
 * You have to fix some things. 
 * 
 * The way you are gathering the factors into string won't working, since there are numbers with some digits, and the 
 * method you have done doesn't know to count them,
 * 
 * You should use dictionary for contains the factors as keys and the count of them as numbers.
 * And on site to check if it's on the right count.
 * 
 * From there it's much easier to check it inside some algorithm. 
 * 
 * 
 * 
https://projecteuler.net/problem=47

Problem - find the first number of the sequence of four number with distinct prime factors.

Steps to solve: 
*** all should be done in the fastest and efficient way ***
*
- Start from 644 (according to the question description)
- Find the primes factors of numbers. 
- On each number we need to compare it vs it's previous if it's distinct. 
- if does - save the first. and  - count and check the next.
- if you reach 4 - this is the number - return the first you have saved. 
- if not distinct - reset the count. 
- 
Discussion 
  
  How to find factors - at all and in the fastest way. 
    Start from 2 and check if it's divided. If does return this method on the result. 
    if it's not - it's a prime
    if it's odd - you can skip evens. 
    If you reach half or more then half of the number - it won't be divided any more. 
    Actually - until the sqrt 
    For efficiency you can save the primes you aggregating and check vs them. 

    Maybe there are more efficient ways to do it. 

Maybe by multiplying primes in each other. 
Or something else. 

Work on it. 

Pay attention - you need to find n of n . 4 of four. and like that... 

https://byjus.com/maths/factors-of-a-number/
https://stackoverflow.com/questions/239865/best-way-to-find-all-factors-of-a-given-number


- think... 
- if you have the primes maybe you can easily find ? 

 * */
namespace c_sharp_basics_lingar.fun.project_euler
{
    public class EulerProblem47
    {

        public static Dictionary<int, int> savedOld = new Dictionary<int, int>();
        public static int[] savedPrimesOld;


        public static List<int> savedPrimesList = new List<int>();


        public static void Demo()
        {
            Console.WriteLine("EulerProblem47");
            Solve(2);
            string str1 = "2233355", str2 = "23335";
            //Console.WriteLine("Is distinct ? " + IsDistinct2(str1, str2));
        }

        public static void Solve(int amt)
        {
            int countFound = 0;
            Dictionary<int, int> previousPrimesFactors = new Dictionary<int, int>();
            Dictionary<int, int> currentFactors = new Dictionary<int, int>();
            //Console.WriteLine("check = " + current[2]);
            List<int> primes = new List<int>();
            primes.Add(2);

            //start from 3
            int num = 2;
            //You can get the result by substract 3
            string previous = "";
            while (true)
            {
                //Console.WriteLine("Primes list = " + String.Join("," , primes));
                num++;

                int result = num;
                currentFactors.Clear();
                if (num > 16) return;
                //start checking the factors. Go over the exist number. 
                //on each number : 
                foreach (int prime in primes)
                {
                    //you can save unnecessary actions... 
                    if (prime > num / 2 || result == 1) break;



                    // divide it vs the saved primes. 

                    int reminder = result % prime;
                    //if it's can be divide - insert the number to the string current.  
                    //do this again
                    while (reminder == 0)//better condition:

                    {

                        if (currentFactors.ContainsKey(prime))
                        {
                            currentFactors[prime] += 1;
                        }
                        else
                        {
                            currentFactors.Add(prime, 1);
                        }

                        result = result / prime;//taking the next result (it's must be divided
                        reminder = result % prime;//next divider. 
                    }
                    //if not - go over to the next prime


                }


                //it's now should be or 1 or the number itself. 

                //So if it's more than 1 - it's a prime, add it to the list. Count go into 0. 
                if (result > 1)
                {
                    countFound = 0;
                    primes.Add(num);
                    previousPrimesFactors.Clear();
                    continue;

                }
                // if it's 1 -
                else
                {
                    //  if count == 0 it's the first so assign it to the previous. 
                    //and don't compare. 

                    if (countFound == 0 && previousPrimesFactors.Count == 0)
                    {
                        previousPrimesFactors = currentFactors;
                        continue;
                    }
                    // if count more then > 0
                    //  compare the string vs previous. IF it's equal -count. 

                    else
                    {
                        //get the short and long


                        Console.WriteLine("The number is : " + num);
                        if (IsDistinct5(currentFactors, amt))
                        {
                            countFound++;
                        }
                        //  If NOT - count into 0 
                        else
                        {
                            countFound = 0;


                        }

                        previousPrimesFactors = currentFactors;

                    }
                }
                // if count == amt - print and return .  
                if (countFound == amt)
                {
                    Console.WriteLine("The number is " + (num - amt + 1));
                    return;
                }

            }

        }

        public static void Solve2(int amt)
        {
            int countFound = 0;

            //Console.WriteLine("check = " + current[2]);
            List<int> primes = new List<int>();
            primes.Add(2);
            List<int> currentFactors = new List<int>();

            //start from 3
            int num = 2;

            while (true)
            {
                //Console.WriteLine("Primes list = " + String.Join("," , primes));
                num++;
                //reset the current factors 
                currentFactors = new List<int>();

                int result = num;

                if (num > 16) return;
                //start checking the factors. Go over the exist number. 
                //on each number : 
                foreach (int prime in primes)
                {
                    //you can save unnecessary actions... 
                    if (prime > num / 2 || result == 1) break;

                    int exponent = 0;


                    // divide it vs the saved primes. 

                    int reminder = result % prime;
                    //if it's can be divide - insert the number to the string current.  
                    //do this again

                    while (reminder == 0)//better condition:

                    {
                        exponent++;



                        result = result / prime;//taking the next result (it's must be divided
                        reminder = result % prime;//next divider. 
                    }
                    if (exponent > 0)
                        currentFactors.Add(exponent * prime);

                }


                //it's now should be or 1 or the number itself. 

                //So if it's more than 1 - it's a prime, add it to the list. Count go into 0. 
                if (result > 1)
                {
                    primes.Add(num);
                    countFound = 0;
                    continue;

                }
                else if (currentFactors.Count != amt)
                {
                    savedPrimesList.Clear();
                    countFound = 0;
                    continue;
                }
                // in this case we need to check
                else
                {
                    //check if distinct against the saved. 
                    if (IsDistinctNew(currentFactors))
                    {

                        countFound++;
                        // if count == amt - print and return .  
                        if (countFound == amt)
                        {
                            Console.WriteLine("The number is " + (num - amt + 1));
                            return;
                        }
                    }
                    else
                    {
                        countFound = 0;
                    }
                   
                }
            }


        }

        public static bool IsDistinctNew(List<int> currentFactors)
        {
            for (int i = 0; i < currentFactors.Count; i++)
            {
                if (savedPrimesList.Contains(currentFactors[i]){
                    savedPrimesList = currentFactors;
                    return false;
                }
                else
                {
                    savedPrimesList.Add(currentFactors[i]);
                }
            }

            return true;
        }


        //You need to to compate distint.

        public static bool IsDistinct(string shortS, string longS, int index)
        {
            if (shortS.Length == index)
            {
                return true;
            }
            char lastChar = shortS[index];
            while (true)
            {
                if (shortS[index] != longS[index])
                {

                }
            }

            return true;
        }
        public static bool IsDistinct2(string shortS, string longS, int amt)
        {
            int index = 0;
            int countTests = 0;
            while (index < shortS.Length)
            {
                if (countTests > amt)
                {
                    return false;
                }
                char lastChar = shortS[index];
                int countA = 0, countB = 0;
                while (index < shortS.Length && lastChar == shortS[index])
                {
                    countA++;
                    index++;
                }
                int indexB = longS.IndexOf(lastChar);
                countTests++;

                if (indexB < 0) continue;
                while (indexB < longS.Length && lastChar == longS[indexB])
                {
                    countB++;
                    indexB++;
                }
                if (countA == countB)
                    return false;
                //lastChar = shortS[index];

            }

            return countTests == amt;

        }

        public static bool IsDistinct3(string shortS, string longS, int amt)
        {
            Console.WriteLine("shortS = " + shortS + " longS = " + longS);

            //Check the difference chars in each string. 
            List<char> chars1 = new List<char>();
            List<char> chars2 = new List<char>();

            char lastChar = '-';
            //chars1.Add(lastChar);
            for (int index = 0; index < shortS.Length; index++)
            {
                if (shortS[index] != lastChar)
                {
                    lastChar = shortS[index];
                    chars1.Add(lastChar);
                }
            }
            //if one of them not equal to amt - return false 

            if (chars1.Count != amt) return false;

            lastChar = '-';
            for (int index = 0; index < longS.Length; index++)
            {
                if (longS[index] != lastChar)
                {
                    lastChar = longS[index];
                    chars2.Add(lastChar);
                }
            }
            //if one of them not equal to amt - return false 

            if (chars2.Count != amt) return false;

            List<char> theShort = null;
            List<char> theLong = null;

            if (chars1.Count <= chars2.Count)
            {
                theShort = chars1;
                theLong = chars2;
            }
            else
            {
                theShort = chars2;
                theLong = chars1;
            }

            //find those which equals
            //
            List<char> equalToCheck = new List<char>();
            foreach (char c in theShort)
            {
                if (theLong.Contains(c))
                {
                    equalToCheck.Add(c);
                }
            }

            foreach (char c in equalToCheck)
            {
                int index = shortS.IndexOf(c);
                int countA = 0, countB = 0;
                while (index < shortS.Length && c == shortS[index])
                {
                    countA++;
                    index++;
                }
                index = longS.IndexOf(c);
                while (index < longS.Length && c == longS[index])
                {
                    countB++;
                    index++;
                }
                if (countA == countB)
                {
                    return false;
                }
            }
            //Maybe use dictionary
            //count and compare on each char. If it's equal return false.

            //that's all. 



            //Count each of them. 



            return true;
        }

        public static bool IsDistinct4(Dictionary<int, int> current, Dictionary<int, int> previous, int amt)
        {
            Console.WriteLine("current = " + String.Join(",", current) + " previous = " + String.Join(",", previous));

            if (current.Count != amt || previous.Count != amt)
            {
                return false;
            }
            foreach (KeyValuePair<int, int> kvp in current)
            {
                if (previous.ContainsKey(kvp.Key) &&

                    kvp.Value == previous[kvp.Key])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDistinct5(Dictionary<int, int> current, int amt)
        {

            if (current.Count != amt)
            {
                savedOld.Clear();
                //saved = current;

                return false;
            }
            foreach (KeyValuePair<int, int> kvp in current)
            {
                if (savedOld.ContainsKey(kvp.Key) &&

                    kvp.Value == savedOld[kvp.Key])
                {
                    savedOld = current;
                    return false;
                }
                else
                {
                    savedOld.Add(kvp.Key, kvp.Value);
                }
            }

            return true;
        }


        public static bool IsDistinct6(List<int> check, int amt)
        {

            if (check.Count != amt)
            {
                savedPrimesOld = new int[amt * amt];
                //saved = current;

                return false;
            }
            foreach (int i in check)
            {
                foreach (int j in savedPrimesOld)
                {
                    if (i == j)
                    {

                        return false;
                    }
                }
            }

            return true;
        }

    }
}
