using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.Movies.Api.Models;

public class Movie
{
    public Movie(String title, String description, String genre, DateOnly releaseDate)
    {
        this.Title = title;
        this.Description = description;
        this.Genre = genre;
        this.ReleaseDate = releaseDate;
    }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public String Title { get; set; }
    public String Description { get; set; }
    public String Genre { get; set; }
    public DateOnly ReleaseDate { get; set; }
}