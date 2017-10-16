using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private List<int> CalculateCannibals(List<int> potential, int expected)
        {
            var list = potential.Where(x => x >= expected).ToList();
            potential = potential.Where(x => x < expected).ToList();
            potential.Sort();
            potential[0]++;
            potential.Remove(potential.Count - 1);
            if (potential.Count == 0)
            {
                return list;
            }
            else
            {
                list.AddRange(CalculateCannibals(potential, expected));
                return list;
            }
        }
    }
}
