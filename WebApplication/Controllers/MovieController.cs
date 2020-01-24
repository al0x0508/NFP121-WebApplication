using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Repositories.Repositories;
using Repository.Interfaces;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService repo;

        public MovieController(IMovieService repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return repo.GetAllMovies();
        }
    }
}