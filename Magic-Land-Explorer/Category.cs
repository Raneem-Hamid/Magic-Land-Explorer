using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public class Category
    {
        [JsonProperty("category")]
        public string CategoryName { get; set; }

        [JsonProperty("destinations")]
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        // Constructor
        public Category(string categoryName)
        {
            CategoryName = categoryName;
            Destinations = new List<Destination>();
        }

        //public override string ToString()
        //{
        //    string result = $"Category: {CategoryName}\nDestinations:\n";
        //    foreach (var destination in Destinations)
        //    {
        //        result += destination.ToString() + "\n";
        //    }
        //    return result;
        //}
    }
}
