using System;
using System.Collections.Generic;
using System.Text;
using Model.Entities;

namespace Repository.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        bool DeleteMovie(int id);
        public Movie GetByTitle(string movieTitle);
    }
}