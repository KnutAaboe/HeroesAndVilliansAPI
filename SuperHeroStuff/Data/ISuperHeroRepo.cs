using SuperHeroStuff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStuff.Data
{
    public interface ISuperHeroRepo
    {
        IEnumerable<SuperHero> GetSuperHeroes();
        SuperHero GetSuperHeroByID(string id);

    }
}
