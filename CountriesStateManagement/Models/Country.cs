using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesStateManagement.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public List<string> NationalColors { get; set; }
        public string FlagURL { get; set; }

        public Country(string name, string language, string greeting, string description, List<string> nationalColors, string flagURL)
        {
            Name = name;
            Language = language;
            Greeting = greeting;
            Description = description;
            NationalColors = nationalColors;
            FlagURL = flagURL;
        }
    }
}
