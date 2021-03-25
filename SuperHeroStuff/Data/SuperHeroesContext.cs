using Microsoft.EntityFrameworkCore;
using SuperHeroStuff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStuff.Data
{
    public class SuperHeroesContext : DbContext
    {
        public SuperHeroesContext(DbContextOptions<SuperHeroesContext> opt) : base(opt)
        {

        }

        //Saying we want to represent our SuperHero objects as a DbSet 
        public DbSet<SuperHero> SuperHeroes { get; set; }

        //If we had more models to be added, we would have to add an associated DB set within our DB context

    }
}
