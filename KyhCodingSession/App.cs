using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhCodingSession
{
    public class App
    {
        public void Run()
        {
            var lastDepth = -1;
            var numberOfDepthIncreases = 0;

            foreach (var line in File.ReadLines("C:\\Users\\stefa\\Downloads\\day1input.txt"))
            {
                var currentDepth = Convert.ToInt32(line);
                if (lastDepth != -1 && currentDepth > lastDepth)
                    numberOfDepthIncreases++;
                lastDepth = currentDepth; 
            }
            Console.WriteLine($"Antal: {numberOfDepthIncreases}");
        }
    }
}
