using Microsoft.AspNetCore.Mvc;
using SuperHeroStuff.Data;
using SuperHeroStuff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStuff.Controllers
{
    [Route("api/[controller]")] //Same name as class
    [ApiController]
    public class SuperHeroController : ControllerBase //Base without view
    {
        private readonly ISuperHeroRepo _repo;

        public SuperHeroController(ISuperHeroRepo repo)
        {
            _repo = repo;
        }


        //private readonly MockSuperHeroRepo repo = new MockSuperHeroRepo();

        //GET api/[controller]
        [HttpGet]
        public ActionResult<IEnumerable<SuperHero>> GetSuperHeroes()
        {
            var superHeroes = _repo.GetSuperHeroes();
            return Ok(superHeroes);
        }

        //GET api/[controller]/x where x = id
        [HttpGet("{id}")]
        public ActionResult <SuperHero> GetSuperHeroByID(string id)
        {
            var superHero = _repo.GetSuperHeroByID(id);
            return Ok(superHero);
        }


    }
}
