using System.Collections.Generic;
using Model.Entities;

namespace MoveServices.Service
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        bool DeleteMovie(int id);
    }
}