using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.Model
{
    public class Comparisons
    {

        public class Stats
        {
            public string intelligence { get; set; }
            public string strength { get; set; }
            public string speed { get; set; }
            public string durability { get; set; }
            public string power { get; set; }
            public string combat { get; set; }
        }
        
        public class Looks
        {
            public List<string> height { get; set; }
            public List<string> weight { get; set; }

        }

        public class Picture 
        {
            public string url { get; set; }
        }

        public class Roots
        {
            public string name { get; set; }
            public Stats powerstats { get; set; }
            public Looks looks { get; set; }
            public Picture picture { get; set; }
        }

    }
}
