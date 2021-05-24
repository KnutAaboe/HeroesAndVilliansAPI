using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.Model
{
    public class Search
    {
        public class Imagee
        {
            public string url { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public string name { get; set; }
            public Imagee image { get; set; } 
        }

        public class Data
        {

            public string response { get; set; }
            [JsonProperty("results-for")]
            public string ResultFor { get; set; }
            public List<Result> results { get; set; }

        }
    }
}
