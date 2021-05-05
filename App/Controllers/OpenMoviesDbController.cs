using App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class OpenMoviesDbController : ControllerBase
    {

        private readonly MoviesDbContext context;
        public OpenMoviesDbController(MoviesDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetMovies")]
        public async Task<IEnumerable<Movies>> GetMovies()
        {
            return context.Movies.ToList();
        }

        [HttpGet("GetMovieById/{Id}")]
        public async Task<Movies> GetMovieById(int Id)
        {
            return context.Movies.Where(x => x.ID == Id).SingleOrDefault();
        }

        [HttpGet("GetMovieByTitle/{t}")]
        public async Task<IEnumerable<Movies>> GetMovieByTitle(string t)
        {
            return context.Movies.Where(x => x.Title.Contains(t)).ToList();
        }

        [HttpPost("SaveSearchedMovie")]
        public async Task<bool> SaveSearchedMovie([FromBody] SearchMovies movieSearch)
        {
            context.SearchMovies.Add(movieSearch);
            await context.SaveChangesAsync();
            return true;
        }


    }
}
