using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace App.Entities
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<SearchMovies> SearchMovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var appPermsDB = Utility.AppConfiguration().GetSection("ConnectionStrings").GetSection("OMDb").Value;

                optionsBuilder.UseSqlServer(appPermsDB, options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });

                base.OnConfiguring(optionsBuilder);
            }

            catch (Exception ex)
            {
               // ActivityLog<string>.Logger("...Database Connection  Exception..:", ex.Message);
            }
        }
    }
}
