using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class FilterDestinations
    {
        public static void Filter_Destinations(List<Category> categories)
        {
            var filter = categories
                .SelectMany(c => c.Destinations)
                .Where(d => { return !string.IsNullOrEmpty(d.Duration) && int.Parse(d.Duration.Split(' ')[0]) < 100; })
                .Select(d => d.Name)
                .ToList();

            Console.WriteLine("Destinations with duration less than 100 minutes:");
            foreach (var category in filter)
            {
                Console.WriteLine(category);
            }
        }
    }
}
