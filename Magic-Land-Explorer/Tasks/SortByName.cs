using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class SortByName
    {
        public static void Sort_By_Name(List<Category> categories)
        {

            var sortedDestinations = categories
            .SelectMany(c => c.Destinations)
            .OrderBy(d => d.Name)
            .ToList();

        Console.WriteLine("Sorted destinations by name:");
        foreach (var destination in sortedDestinations)
        {
            Console.WriteLine(destination.Name);
        }

        }
        

    }
}
