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
