namespace TMDB.MVC.Models;

public class Root
{
    public int id { get; set; }
    public int page { get; set; }
    //public MovieDetails MovieDetails { get; set; }
    public List<Review> results { get; set; }
    public int total_pages { get; set; }
    public int total_results { get; set; }
}
