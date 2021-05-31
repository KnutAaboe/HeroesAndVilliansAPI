using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static SuperHeroesAPI.Model.AllinfoHV;

namespace HeroesAndVilliansAPI.Model
{
    public class Comparisons
    {
        public class Body
        {
            public List<string> height { get; set; }
            public List<string> weight { get; set; }

        }

        public class Data
        {
            public string name { get; set; }
            public AllinfoHV.Powerstats powerstats { get; set; }
            //public Looks looks { get; set; }
            public Body appearance { get; set; }
            public AllinfoHV.Image image { get; set; }
        }

    }
}
