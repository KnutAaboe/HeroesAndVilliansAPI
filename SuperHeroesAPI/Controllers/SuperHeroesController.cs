using HeroesAndVilliansAPI.Model;
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

        //All info om en superhelt/villain
        [HttpGet("GetAllInfo/{id}/")]
        public ActionResult<AllinfoHV.Root> GetHeroVillianInfo(string id)
        {
            AllinfoHV.Root allInfo = data.GetHeroVillianInfoByID(id);
            if (allInfo != null)
            {
                return Ok(allInfo); 
            } else
            {
                return NotFound();
            }
        }

        //Navn på alle superhelt/Villain i apiet - type of ratio to choose all - superhero - villain
        [HttpGet("getNames/")]
        public ActionResult<IEnumerable<String>> GetHeroesVillians(int startID, string alignment)
        {
            List<string> allHeroes = data.GetAllHeroesVillians(startID, alignment);
            if (allHeroes != null)
            {

                return Ok(allHeroes);
            }
            else
            {
                return NoContent();
            }
        }

        //Ìmplementer search apiet 


        //Implementer pvp apiet 
        [HttpGet("comparisons/")]
        public ActionResult<IEnumerable<Comparisons.Roots>> HeroesVilliansComparisons(string id, string id2)
        {
            List<Comparisons.Roots> chosenHeroes = data.HeroesVilliansStats(id, id2);
            if (chosenHeroes != null)
            {

                return Ok(chosenHeroes);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("startsORcontains/")]
        public ActionResult<IEnumerable<Search.Data>> GetHeroesVilliansByLetters(string letters, string where)
        {
            Search.Data foundHeroesVillians = data.SearchForHeroesVillians(letters, where);
            if (foundHeroesVillians != null)
            {

                return Ok(foundHeroesVillians);
            }
            else
            {
                return NotFound();
            }
        }

    }
}

    
  