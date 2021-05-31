using Newtonsoft.Json;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.Model
{
    public class Search
    {

        public class Result
        {
            public string id { get; set; }
            public string name { get; set; }
            public AllinfoHV.Image image { get; set; } 
        }

        public class Results
        {

            [JsonProperty("results-for")]
            public string ResultFor { get; set; }
            public List<Result> results { get; set; }

        }
    }
}
