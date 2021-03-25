using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{
    public class MockSuperHeroRepo : IApiFetcher
    {
        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            


            //var heroes = new List<SuperHero>

            // {
            //    new SuperHero {
            //    id = "1", name = "The Amazing Knut", intelligence = "20", strength = "50",
            //    speed = "6", durability = "20", power = "50", combat = "9" },
                
            //    new SuperHero {
            //    id = "2", name = "Lil Peet", intelligence = "0", strength = "1",
            //    speed = "1", durability = "0", power = "10", combat = "99" },

            //    new SuperHero {
            //    id = "3", name = "Chris Stien", intelligence = "0", strength = "2",
            //    speed = "-2", durability = "20", power = "13", combat = "09" }
            //};

            return;
        }

        public SuperHero GetSuperHeroById(string id)
        {
            return GetSuperHeroes().FirstOrDefault((x) => x.id == id);
        }

        //public IEnumerable<SuperHero> GetSuperHero()
        //{
        //    throw new NotImplementedException();
        //}

        //public SuperHero GetSuperHeroeById(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
