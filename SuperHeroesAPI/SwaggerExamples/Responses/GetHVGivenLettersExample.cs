using HeroesAndVilliansAPI.Model;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.SwaggerExamples.Responses
{
    public class GetHVGivenLettersExample : IExamplesProvider<Search.Results>
    {
        public Search.Results GetExamples()
        {
            return new Search.Results
            {
                ResultFor = "bat",
                results = new List<Search.Result>
                {
                    new Search.Result
                    {
                        id = "63",
                        name = "Batgirl",
                        image = new SuperHeroesAPI.Model.AllinfoHV.Image
                        {
                            url = "https://www.superherodb.com/pictures2/portraits/10/100/1111.jpg"
                        }
                    },
                    new Search.Result
                    {
                        id = "64",
                        name = "Batgirl",
                        image = new SuperHeroesAPI.Model.AllinfoHV.Image
                        {
                            url = "https://www.superherodb.com/pictures2/portraits/10/100/638.jpg"
                        }
                    },
                    new Search.Result
                    {
                        id = "65",
                        name = "Batgirl III",
                        image = new SuperHeroesAPI.Model.AllinfoHV.Image
                        {
                            url = "https://www.superherodb.com/pictures2/portraits/10/100/1112.jpg"
                        }
                    }
                }
            };
        }
    }
}
