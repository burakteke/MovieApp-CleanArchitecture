using Microsoft.AspNetCore.Mvc;
using Movie.Application.Interfaces;
using Movie.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<MovieDomain>> GetAll()
        {
            return _movieService.GetAllMovies();
        }

    }
}
