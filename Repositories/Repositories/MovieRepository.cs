using System.Collections.Generic;
using System.Linq;
using Model;
using Model.Entities;
using Repository.Interfaces;

namespace Repositories.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            this._context = context;
        }

        public List<Movie> GetAllMovies()
        {
            return this._context.Movies.ToList();
        }

        public Movie CreateMovie(Movie movie)
        {
            this._context.Movies.Add(movie);
            this._context.SaveChanges();
            return movie;
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            var entity = _context.Movies.FirstOrDefault(x => x.id == id);
            movie.id = id;
            _context.Entry(entity).CurrentValues.SetValues(movie);
            _context.SaveChanges();
            return entity;
        }

        public bool DeleteMovie(int id)
        {
            var entity = _context.Movies.FirstOrDefault(x => x.id == id);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public Movie GetByTitle(string movieTitle)
        {
            return _context.Movies.FirstOrDefault(x => x.Title == movieTitle);
        }
    }
}