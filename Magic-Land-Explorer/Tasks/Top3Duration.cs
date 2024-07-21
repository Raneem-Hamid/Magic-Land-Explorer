using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static void Top3_Duration(List<Category> categories) 
        {
            var top3 = categories
                .SelectMany(c => c.Destinations)
                .Where(d => !string.IsNullOrEmpty(d.Duration))
                .OrderByDescending(d =>  int.Parse(d.Duration.Split(' ')[0]))
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var item in top3)
            {
                Console.WriteLine($"{item.Name} - {item.Duration}");
            }
        }
    }
}
