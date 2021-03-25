using SuperHeroStuff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStuff.Data
{
    public class MockSuperHeroRepo : ISuperHeroRepo
    {
       public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var heroList = new List<SuperHero>
            {
                new SuperHero {id = "1", name = "The Amazing Knut", intelligence = "20", strength = "50"},
                new SuperHero {id = "2", name = "Lil Peet", intelligence = "0", strength = "1"},
                new SuperHero {id = "3", name = "Chris Stien", intelligence = "0", strength = "2"}
            };


            return heroList;
        }

        public SuperHero GetSuperHeroByID(string id)
        {
            return GetSuperHeroes().FirstOrDefault((x) => x.id.Equals(id));
        }

    }
}
