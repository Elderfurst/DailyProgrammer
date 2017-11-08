using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    public class Easy339 : IRunnable
    {
        private readonly string[] _input = File.ReadAllText(@"Input\Easy339.txt").Split(new string[] { "\r\n" }, StringSplitOptions.None);
        public void Run()
        {
            var mainEntry = "";
            var currentMaxSalary = 0;
            var currentMaxSalaryName = "";
            foreach (var line in _input)
            {
                if (line.Substring(0, 7) != "::EXT::")
                {
                    mainEntry = line;
                }
                else if(line.Substring(7, 4) == "SAL " && int.Parse(line.Substring(11, 17)) > currentMaxSalary)
                {
                    currentMaxSalaryName = mainEntry.Substring(0, 20);
                    currentMaxSalary = int.Parse(line.Substring(11, 17));
                }
            }

            Console.WriteLine(currentMaxSalaryName.Trim() + ", " + (currentMaxSalary).ToString("C"));
        }
    }
}
