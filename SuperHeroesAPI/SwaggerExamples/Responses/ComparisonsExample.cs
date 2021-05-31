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

            };
        }
    }
}
