namespace Sample.Movies.Api.Dto;

public class MovieDto
{
    public String Title { get; set; }
    public String Description { get; set; }
    public String Genre { get; set; }
    public DateOnly ReleaseDate { get; set; }
}