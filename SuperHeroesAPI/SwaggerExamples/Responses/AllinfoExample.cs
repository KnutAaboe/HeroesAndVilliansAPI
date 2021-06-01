using SuperHeroesAPI.Model;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.Data
{
    public class AllinfoExample : IExamplesProvider<AllinfoHV.Root>
    {

        public AllinfoHV.Root GetExamples()
        {
            return new AllinfoHV.Root
            {

                id = "1",
                name = "Wayne",
                powerstats = new AllinfoHV.Powerstats
                {
                    
                    intelligence = "999",
                    strength = "999",
                    speed = "999",
                    durability = "999",
                    power = "999",
                    combat = "999",
                },
                biography = new AllinfoHV.Biography
                {
                    FullName = "Knut Anders Aabø Opstad",
                    AlterEgos = "No alter egos found.",
                    aliases = new List<string>
                    {
                        "Insider",
                        "Matches Malone"
                    },
                    PlaceOfBirth = "Crest Hill, Bristol Township; Gotham County",
                    FirstAppearance = "Detective Comics #2",
                    publisher = "DC Comics",
                    alignment = "good",
                },
                appearance = new AllinfoHV.Appearance
                {
                    gender = "Male",
                    race = "Human",
                    height = new List<string>
                    {
                        "6",
                        "182 cm"
                    },
                    weight = new List<string>
                    {
                        "185 lbs",
                        "82 kg"
                    },
                    EyeColor = "green",
                    HairColor = "brown",
                },
                work = new AllinfoHV.Work
                {
                    occupation = "IT developer",
                    @base = "Batcave, Stately Wayne Manor, Gotham City; Hall of Justice, Justice League Watchtower"
                },
                connections = new AllinfoHV.Connections
                {
                    GroupAffiliation = "Batman Family, Batman Incorporated, Justice League, Outsiders, Wayne Enterprises, Club of Heroes, formerly White Lantern Corps, Sinestro Corps",
                    relatives = "Damian Wayne (son), Dick Grayson (adopted son), Tim Drake (adopted son), Jason Todd (adopted son), Cassandra Cain (adopted ward)\nMartha Wayne (mother, deceased), Thomas Wayne (father, deceased), Alfred Pennyworth (former guardian), Roderick Kane (grandfather, deceased), Elizabeth Kane (grandmother, deceased), Nathan Kane (uncle, deceased), Simon Hurt (ancestor), Wayne Family"
                },
                image = new AllinfoHV.Image
                {
                    url = "httpss://www.superherodb.com/pictures2/portraits/10/100/639.jpg"
                }

            };

        }

        //public AllinfoHV.Root GetExamples()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
