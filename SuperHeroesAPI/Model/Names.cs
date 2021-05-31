using Newtonsoft.Json;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.Model
{
    public class Names
    {
            public class Bio
            {
                [JsonProperty("full-name")]
                public string FullName { get; set; }
                public string alignment { get; set; }
            }

            public class Rooot
            {
                public string id { get; set; }
                public string name { get; set; }
                public Bio biography { get; set; }
                public AllinfoHV.Image image { get; set; }
            }


        

    }
}
