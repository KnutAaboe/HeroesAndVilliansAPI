using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{
    public interface IApiFetcher
    {
        IEnumerable<SuperHero> GetSuperHeroes();
        SuperHero GetSuperHero(string id);
    }
}
