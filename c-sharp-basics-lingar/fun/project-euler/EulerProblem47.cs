using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * 
https://projecteuler.net/problem=47

Problem - find the first number of the sequence of four number with distinct factors. 

Steps to solve: 
*** all should be done in the fastest and efficient way ***
*
-
- Find the primes factors of numbers. 
- On each number we need to compare it vs it's previous if it's distinct. 
- if does - save the first. and  - count and check the next.
- if you reach 4 - this is the number - return the first you have saved. 
- if not distinct - reset the count. 
- 

  
  
 * */
namespace c_sharp_basics_lingar.fun.project_euler
{
    public class EulerProblem47
    {
        public static void Demo()
        {
            Console.WriteLine("EulerProblem47");
        }

    }
}
