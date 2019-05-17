﻿using System;

namespace Distinct
{
    using System.Linq;

    class Program
    {
        //Write a function

        //class Solution { public int solution(int[] A); }

        //that, given an array A consisting of N integers, returns the number of distinct values in array A.

        //    For example, given array A consisting of six elements such that:


        //A[0] = 2    A[1] = 1    A[2] = 1

        //A[3] = 2    A[4] = 3    A[5] = 1
        //the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.


        //Write an efficient algorithm for the following assumptions:


        //N is an integer within the range[0..100, 000];
        //each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].

        class Solution
        {
            public int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                var list = A.ToList();
                return list.Distinct().Count();
            }
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();

            solution.solution(new int[] {2, 1, 1, 2, 3, 1});
        }
    }
}
