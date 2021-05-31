using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesAndVilliansAPI.SwaggerExamples.Responses
{
    public class NoContentExample : IExamplesProvider<string>
    {
        public string GetExamples()
        {
            return "Successfully fulfilled and ran the request, but no content. Might be no given allignment in that range";
        }
    }
}
