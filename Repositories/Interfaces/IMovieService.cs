using System;
using System.Collections.Generic;
using System.Text;
using Model.Entities;

namespace Repository.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}