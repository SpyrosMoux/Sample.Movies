using Microsoft.AspNetCore.Mvc;
using Sample.Movies.Api.Dto;
using Sample.Movies.Api.Models;
using Sample.Movies.Api.Repositories;

namespace Sample.Movies.Api.Services.Interfaces;

public interface IMovieService
{
    Task<Movie> AddMovie(MovieDto movieDto);
    Task<Movie> GetMovieById(Guid id);
    Task<IEnumerable<Movie>> GetAllMovies();
}