using System.Collections.Generic;
using Model.Entities;
using Repository.Interfaces;

namespace Repositories.Repositories
{
    public class StaticMovieRepository : IMovieService
    {
        public List<Movie> GetAllMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Title = "Toto à la plage"},
                new Movie() {Title = "Martine en vacances", Description = "C'est nul"},
            };
        }
    }
}