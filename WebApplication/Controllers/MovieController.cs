using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using MoveServices.Service;
using Repositories.Repositories;
using Repository.Interfaces;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService service;

        public MovieController(IMovieService service)
        {
            this.service = service;
        }

        
        
        [HttpPost("create")]
        public Movie Create(Movie movie)
        {
            return service.CreateMovie(movie);
        }

        [HttpPut("{id}")]
        public Movie Put(int id, [FromBody] Movie movie)
        {
            return service.UpdateMovie(id, movie);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return service.DeleteMovie(id);
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return service.GetAllMovies();
        }

        [HttpPost("")]
        public IActionResult Post(Movie movie)
        {
            var res = service.CreateMovie(movie);
            if (res != null)
            {
                return Ok(res);
            }

            return BadRequest("Cannot add movie in Db, please check the payload");
        }
    }
}