using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class LongestDuration
    {
        public static void Longest_Duration(List<Category> categories)
        {
            var longest = categories
                .SelectMany(c => c.Destinations)
                .Where(d => !string.IsNullOrEmpty(d.Duration))
                .OrderByDescending(d => int.Parse(d.Duration.Split(' ')[0]))
                .FirstOrDefault(); ;

                Console.WriteLine("Destination with the longest duration:");
                Console.WriteLine($"{longest.Name}");
            
        }
    }
}
