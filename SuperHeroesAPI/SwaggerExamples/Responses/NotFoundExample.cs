using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.SwaggerExamples.Responses
{
    public class NotFoundExample : IExamplesProvider<String>
    {
        public string GetExamples()
        {
            return "Error: Unable to get data with given input/inputs";
        }
    }
}
