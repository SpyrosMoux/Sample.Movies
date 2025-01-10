using Microsoft.AspNetCore.Mvc;
using Sample.Movies.Api.Dto;
using Sample.Movies.Api.Services.Interfaces;

namespace Sample.Movies.Api.Controllers;

[ApiController]
[Route("movies")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private readonly IMovieService _movieService;

    public MoviesController(ILogger<MoviesController> logger, IMovieService movieService)
    {
        _logger = logger;
        _movieService = movieService;
    }

    [HttpPost]
    public IActionResult AddMovie([FromBody] MovieDto movieDto)
    {
        var movie = _movieService.AddMovie(movieDto);
        if (movie == null)
        {
            return BadRequest();
        }
        return Ok(movie);
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        if (string.IsNullOrWhiteSpace(id.ToString()))
        {
            return BadRequest();
        }
        
        var movie = _movieService.GetMovieById(id);
        if (movie.Result == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var movies = _movieService.GetAllMovies();
        return Ok(movies);
    }
}