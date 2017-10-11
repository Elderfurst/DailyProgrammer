﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DailyProgrammer
{
    public class Easy335
    {
        public void Run()
        {
            const string input = @"76 74 45 48 13 75 16 14 79 58 78 82 46 89 81 88 27 64 21 63
                                    37 35 88 57 55 29 96 11 25 42 24 81 82 58 15 2 3 41 43 36
                                    54 64 52 39 36 98 32 87 95 12 40 79 41 13 53 35 48 42 33 75
                                    21 87 89 26 85 59 54 2 24 25 41 46 88 60 63 23 91 62 61 6
                                    94 66 18 57 58 54 93 53 19 16 55 22 51 8 67 20 17 56 21 59
                                    6 19 45 46 7 70 36 2 56 47 33 75 94 50 34 35 73 72 39 5";
            var array = Regex.Split(input, "\\n").Select(x => x.Trim().Split(' ').Select(int.Parse));
            foreach (var singleList in array)
            {
                Console.WriteLine(FindDistanceRating(singleList.ToList()));
            }
        }

        public int FindDistanceRating(List<int> list, int gap = 1)
        {
            var distanceRating = 0;
            foreach (var num in list)
            {
                if (list.Contains(num + gap))
                {
                    
                    distanceRating += (Math.Abs(list.IndexOf(num) - list.IndexOf(num + gap)));
                }
            }
            return distanceRating;
        }
    }
}
