using System.Collections.Generic;
using Model;
using Model.Entities;
using MoveServices.Service;
using Repository.Interfaces;

namespace MoveServices.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }
        
        public Movie CreateMovie(Movie movie)
        {
            var dbMovie = _movieRepository.GetByTitle(movie.Title);
            if (dbMovie == null)
            {
                return this._movieRepository.CreateMovie(movie);
            }

            return null;
        }
        

        public List<Movie> GetAllMovies()
        {
            return this._movieRepository.GetAllMovies();
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            return this._movieRepository.UpdateMovie(id, movie);
        }

        public bool DeleteMovie(int id)
        {
            return this._movieRepository.DeleteMovie(id);
        }
    }
}