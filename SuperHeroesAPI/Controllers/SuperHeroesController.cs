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
        private readonly ApiFetcher data = new ApiFetcher();

        [HttpGet("{id}")]
        public ActionResult<SuperHero> Get(string id)
        {
            SuperHero suop = data.GetSuperHero(id);
            return Ok(suop);
        }


       

    }
}

    
  