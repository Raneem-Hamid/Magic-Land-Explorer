using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public class Destination
    {
       
    public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; } 
        public string Description { get; set; }

        
        public Destination(string name, string type, string location, string duration, string description)
        {
            Name = name;
            Type = type;
            Location = location;
            Duration = duration;
            Description = description;
        }
    }
}
