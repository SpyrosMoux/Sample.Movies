using Sample.Movies.Api.Dto;
using Sample.Movies.Api.Models;
using Sample.Movies.Api.Repositories;
using Sample.Movies.Api.Services.Interfaces;

namespace Sample.Movies.Api.Services;

public class MovieService : IMovieService
{
    private readonly MovieRepository _movieRepository;
    private readonly ILogger<MovieService> _logger;

    public MovieService(MovieRepository movieRepository, ILogger<MovieService> logger)
    {
        _movieRepository = movieRepository;
        _logger = logger;
    }

    public async Task<Movie> AddMovie(MovieDto movieDto)
    {
        Movie movie = ToMovie(movieDto);
        _movieRepository.AddMovieAsync(movie);
        return movie;
    }

    public async Task<Movie> GetMovieById(Guid id)
    {
        return await _movieRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
       var movies = await _movieRepository.GetMoviesAsync();
       return movies;
    }

    private static Movie ToMovie(MovieDto movieDto)
    {
        return new Movie(movieDto.Title, movieDto.Description, movieDto.Genre, movieDto.ReleaseDate);
    }
}