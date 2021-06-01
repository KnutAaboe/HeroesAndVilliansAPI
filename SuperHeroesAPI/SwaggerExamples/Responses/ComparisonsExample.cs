using HeroesAndVilliansAPI.Model;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.SwaggerExamples.Responses
{
    public class ComparisonsExample : IExamplesProvider<IEnumerable<Comparisons.Data>>
    {
        public IEnumerable<Comparisons.Data> GetExamples()
        {
            return new List<Comparisons.Data>
            {
                new Comparisons.Data
                {
                    name = "Wayne",
                    powerstats = new SuperHeroesAPI.Model.AllinfoHV.Powerstats
                    {
                        intelligence = "999",
                        strength = "999",
                        speed = "999",
                        durability = "999",
                        power = "999",
                        combat = "999"
                    },
                    appearance = new Comparisons.Body
                    {
                        height = new List<string>
                        {
                            "6",
                            "182 cm"
                        },
                        weight = new List<string>
                        {
                            "185 lbs",
                            "82 kg"
                        }
                        
                    },
                    image = new SuperHeroesAPI.Model.AllinfoHV.Image
                    {
                        url = "httpss://www.superherodb.com/pictures2/portraits/10/100/639.jpg"
                    }
                },
                new Comparisons.Data
                {
                    name = "Kent",
                    powerstats = new SuperHeroesAPI.Model.AllinfoHV.Powerstats
                    {
                        intelligence = "99",
                        strength = "99",
                        speed = "99",
                        durability = "99",
                        power = "99",
                        combat = "99"
                    },
                    appearance = new Comparisons.Body
                    {
                        height = new List<string>
                        {
                            "5",
                            "175 cm"
                        },
                        weight = new List<string>
                        {
                            "18 lbs",
                            "78 kg"
                        }

                    },
                    image = new SuperHeroesAPI.Model.AllinfoHV.Image
                    {
                        url = "httpss://www.superherodb.com/pictures2/portraits/10/100/639.jpg"
                    }
                }
            };
        }
    }
}
