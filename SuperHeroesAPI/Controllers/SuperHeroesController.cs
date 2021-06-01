﻿using HeroesAndVilliansAPI.Data;
using HeroesAndVilliansAPI.Model;
using HeroesAndVilliansAPI.SwaggerExamples.Responses;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesAPI.Data;
using SuperHeroesAPI.Model;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Controllers
{
    [Route("/api")]
    [ApiController]
    public class HeroesAndVilliansController : ControllerBase
    {
        private readonly ApiFetcher data = new ApiFetcher();

        /// <param name="id">Identity of file to download.</param>
        /// <returns> file content found.</returns>
        [HttpGet("GetAllInfo/{id}")]
        [SwaggerOperation(Summary = "Gets all their information", Description = "Gets all the information there is, on this API, about Heroes/Villians by givving their ID.")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(AllinfoHV.Root))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(AllinfoExample))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(string))]
        [SwaggerResponseExample((int)HttpStatusCode.NotFound, typeof(NotFoundExample))]
        //[RequireHttps()]
        public ActionResult<AllinfoHV.Root> GetHeroVillianInfo(string id)
        {
            AllinfoHV.Root allInfo = data.GetHeroVillianInfoByID(id);
            if (allInfo != null)
            {
                return Ok(allInfo); 
            } else
            {
                return NotFound(new { error = "Unable to get data with given input/inputs" });
                //return NotFound();
            }
        }

        //Navn på alle superhelt/Villain i apiet - type of ratio to choose all - superhero - villain
        [HttpGet("GetNames/{startID}&&{alignment}")]
        [SwaggerOperation(Summary = "Gives a list of names", Description = "Gives a list of names of heroes and/or villians. Alignment - good - bad - all (for good and bad) which is default ")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(String))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(GetNamesByAllignmentExample))]
        [SwaggerResponse((int)HttpStatusCode.NoContent, Type = typeof(string))]
        [SwaggerResponseExample((int)HttpStatusCode.NoContent, typeof(NoContentExample))]
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


        //Implementer pvp apiet (ordne med navn istedenfor id?)
        [HttpGet("Comparisons/{id}&&{id2}")]
        [SwaggerOperation(Summary = "Comparing two hero/villian given id", Description = "Comparing two hero/villian given their id, this includes powerstats")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(List<Comparisons.Data>))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ComparisonsExample))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(string))]
        [SwaggerResponseExample((int)HttpStatusCode.NotFound, typeof(NotFoundExample))]
        public ActionResult<IEnumerable<Comparisons.Data>> HeroesVilliansComparisons(string id, string id2)
        {
            List<Comparisons.Data> chosenHeroes = data.HeroesVilliansStats(id, id2);
            if (chosenHeroes != null)
            {

                return Ok(chosenHeroes);
            }
            else
            {
                return NotFound(new { error = "Unable to get data with given input/inputs" });
            }
        }

        [HttpGet("StartsORcontains/{letters}&&{where}")]
        [SwaggerOperation(Summary = "Gives heroes/villians name and id maching given letters", Description = "Gives heroes/villians name and id maching given letter/letters. Where - starts - contains, contains is default")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Search.Results))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(GetHVGivenLettersExample))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(string))]
        [SwaggerResponseExample((int)HttpStatusCode.NotFound, typeof(NotFoundExample))]
        public ActionResult<IEnumerable<Search.Results>> GetHeroesVilliansByLetters(string letters, string where)
        {
            Search.Results foundHeroesVillians = data.SearchForHeroesVillians(letters, where);
            if (foundHeroesVillians != null)
            {

                return Ok(foundHeroesVillians);
            }
            else
            {
                return NotFound(new { error = "Unable to get data with given input/inputs" });
            }
        }

    }
}

    
  