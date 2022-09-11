namespace TMDB.MVC.Controllers;

public class PopularMoviesDbController : Controller
{
    private readonly ApplicationDbContext db;
    private readonly IMovieService movieService;

    public PopularMoviesDbController(ApplicationDbContext db, IMovieService movieService)
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
        await movieService.ImportPopularMoviesToDb();
        var popularMovies = await db.Movies.ToListAsync();
        return View(popularMovies);
    }

    /// <summary>
    /// Movie Details
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        await movieService.ImportMovieDetailsToDb(id);
        await movieService.ImportMovieCreditsToDb(id);

        var movieDetails = await db.MovieDetailsDbo
            .Include(x => x.spoken_languages)
            .Include(x=>x.production_companies)
            .Include(x => x.production_countries)
            .FirstOrDefaultAsync(x => x.id == id);
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
