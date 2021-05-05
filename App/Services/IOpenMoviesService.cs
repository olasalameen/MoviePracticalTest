using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IOpenMoviesService
    {
        Task<IEnumerable<Movies>> GetMovies();
        Task<Movies> GetMovieById(int Id);
        Task<IEnumerable<Movies>> GetMovieByTitle(string t);
        Task<bool> SaveSearchedMovie(SearchMovies movieSearch);

    }
}
