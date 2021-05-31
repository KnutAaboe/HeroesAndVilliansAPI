using HeroesAndVilliansAPI.Model;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.SwaggerExamples.Responses
{
    public class GetNamesByAllignmentExample : IExamplesProvider<IEnumerable<String>>
    {
        public IEnumerable<string> GetExamples()
        {
            return new List<string>
            {
                "720 img: https://www.superherodb.com/pictures2/portraits/10/100/807.jpg | Diana Prince, aka Wonder Woman",
  "721 img: https://www.superherodb.com/pictures2/portraits/10/100/1290.jpg | Wondra",
  "722 img: https://www.superherodb.com/pictures2/portraits/10/100/164.jpg | Wyatt Wingfoot, aka Wyatt Wingfoot",
  "723 img: https://www.superherodb.com/pictures2/portraits/10/100/565.jpg | Laura Kinney, aka X-23",
  "724 img: https://www.superherodb.com/pictures2/portraits/10/100/1150.jpg | Nate Grey, aka X-Man",
  "726 img: https://www.superherodb.com/pictures2/portraits/10/100/70.jpg | Hank Pym, aka Yellowjacket",
  "727 img: https://www.superherodb.com/pictures2/portraits/10/100/178.jpg | Rita DeMara, aka Yellowjacket II",
  "728 img: https://www.superherodb.com/pictures2/portraits/10/100/179.jpg | Ymir, aka Ymir",
  "729 img: https://www.superherodb.com/pictures2/portraits/10/100/10454.jpg | Yoda, aka Yoda",
  "730 img: https://www.superherodb.com/pictures2/portraits/10/100/809.jpg | Zatanna Zatara, aka Zatanna",
  "732 img: https://www.superherodb.com/pictures2/portraits/10/100/85.jpg | Tony Stark, aka Ironman"
            };
        }
    }
}
