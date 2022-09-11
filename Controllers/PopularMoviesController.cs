namespace TMDB.MVC.Controllers;

public class PopularMoviesController : Controller
{
    private readonly ApplicationDbContext db;
    private readonly IMovieService movieService;

    public PopularMoviesController(ApplicationDbContext db, IMovieService movieService)
    {
        this.db = db;
        this.movieService = movieService;
    }

    /// <summary>
    /// GetPopularMovies
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> IndexAsync()
    {
        var popularMovies = await movieService.GetPopularMovies();
        return View(popularMovies);
    }

    /// <summary>
    /// Movie Details
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        var movieDetails = await movieService.GetMovieDetails(id);
        return View(movieDetails);
    }

    /// <summary>
    /// Movie Review
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Review(int? id)
    {
        var movieReview = await movieService.GetMovieReview(id);
        return View(movieReview);
    }
}
