﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* EXERCISE 1
Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

Example 1:

Input: low = 3, high = 7
Output: 3
Explanation: The odd numbers between 3 and 7 are [3,5,7].

Example 2:

Input: low = 8, high = 10
Output: 1
Explanation: The odd numbers between 8 and 10 are [9].


Constraints:

    0 <= low <= high <= 10^9
---------------------------------------------------------------------------------------------------------------------------------
*/
/*

public class Solution {
    public int CountOdds(int low, int high) 
    {
        int number=0;

        for(int i = low; i <= high; i++)
        {
            if (i%2!=0)
            number++;
        }
        return number;
    }
}

*/
/*  EXERCISE 2
You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

Example 1:

Input: salary = [4000,3000,1000,2000]
Output: 2500.00000
Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500

Example 2:

Input: salary = [1000,2000,3000]
Output: 2000.00000
Explanation: Minimum salary and maximum salary are 1000 and 3000 respectively.
Average salary excluding minimum and maximum salary is (2000) / 1 = 2000

Constraints:

    3 <= salary.length <= 100
    1000 <= salary[i] <= 106
    All the integers of salary are unique.
*/



namespace Exercises
{
    public class Ex2
    { 
        public static void Main(string[] args)
        {



            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ResetColor();
            Console.ReadLine();
        }

        public double ResultingAverage(int[] salary)
        {

        }

    }
}

