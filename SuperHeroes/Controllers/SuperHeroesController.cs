using Microsoft.AspNetCore.Mvc;
using SuperHeroesAPI.Data;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Controllers
{
    [Route("/api")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly string apiKey = API.APIKEY;
        //private readonly MockSuperHeroRepo superHeroeRepo = new MockSuperHeroRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<SuperHero>> GetSuperHeroes()
        {
            var superHeros = superHeroeRepo.GetSuperHeroes();

            return Ok(superHeros);
        }

        [HttpGet("{id}")]
        public ActionResult <SuperHero> GetSuperHeroById(string id)
        {
            var superHero = superHeroeRepo.GetSuperHeroById(id);
            return Ok(superHero);
        }

    }     

    
    public static class Fetcher
    {
        public static SuperHero getUserById()
        {
            string url = string.Format("https://www.superheroapi.com/api.php/" + API) //4119716678052887/287/biography
        }

    }

}
