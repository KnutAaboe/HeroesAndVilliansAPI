using HeroesAndVilliansAPI.Model;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{
    public interface IApiFetcher
    {
        //IEnumerable<SuperHero> GetSuperHeroes();
        AllinfoHV.Root GetHeroVillianInfoByID(string id);
        List<string> GetAllHeroesVillians(int startID, string alignment);
        Search.Data SearchForHeroesVillians(string letters, string where);
        List<Comparisons.Roots> HeroesVilliansStats(string id, string id2);



    }
}
