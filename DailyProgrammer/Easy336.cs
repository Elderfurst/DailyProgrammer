﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyProgrammer
{
    public class Easy336 : IRunnable
    {
        private readonly List<int> _input = new List<int>
        {
            21, 9, 5, 8, 10, 1, 3
        };
        private readonly List<int> _expectedValues = new List<int>
        {
            10, 15
        };
        public void Run()
        {
            foreach (var num in _expectedValues)
            {
                Console.WriteLine("Total number of input values that can be greater than " + num + ": " + CalculateCannibals(_input, num).Count);
            }
        }

        private static List<int> CalculateCannibals(List<int> potential, int expected)
        {
            var list = potential.Where(x => x >= expected).ToList();
            potential = potential.Where(x => x < expected).ToList();
            if (potential.Count == 0)
            {
                return list;
            }
            else
            {
                potential = potential.OrderByDescending(x => x).ToList();
                potential[0]++;
                potential.Remove(potential[potential.Count - 1]);
                list.AddRange(CalculateCannibals(potential, expected));
                return list;
            }
        }
    }
}
