using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    public class Easy336 : IRunnable
    {
        private readonly int[] _expectedValues = new int[]
        {
            10, 15
        };
        public void Run()
        {
            int[] input = new int[]
            {
                21, 9, 5, 8, 10, 1, 3
            };
            foreach (int num in _expectedValues)
            {
                Console.WriteLine("Total number of input values that can be greater than " + num + ": " + CalculateCannibals(num, input));
            }
        }

        private int CalculateCannibals(int num, int[] input)
        {
            var counter = 0;
            foreach (int input in _input)
            {
                if (input > num)
                {
                    counter++;
                }
                else
                {
                    
                }
            }
            return counter;
        }
    }
}
