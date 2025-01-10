using Microsoft.EntityFrameworkCore;
using Sample.Movies.Api.Db;
using Sample.Movies.Api.Models;

namespace Sample.Movies.Api.Repositories;

public class MovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public async void AddMovieAsync(Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
    }

    public async Task<Movie> GetByIdAsync(Guid id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task<List<Movie>> GetMoviesAsync()
    {
        return await _context.Movies.ToListAsync();
    }
}