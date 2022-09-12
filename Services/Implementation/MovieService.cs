using TMDB.MVC.Models;

namespace TMDB.MVC.Services.Implementation;

public class MovieService : IMovieService
{
    private readonly ApplicationDbContext db;
    private readonly IMapper mapper;
    
    public MovieService(ApplicationDbContext db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;
    }

    /// <summary>
    /// GetPopularMovies
    /// </summary>
    /// <returns></returns>
    public async Task<List<Movies>> GetPopularMovies()
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/popular?api_key=" + TMDBApiKey.ApiKey + "&language=en-US&page="))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<PopularMovies>(responseData);
                return model.results;
            }
        }
    }

    /// <summary>
    /// GetMovieDetails
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<MovieDetails> GetMovieDetails(int? id)
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/" + id + "?api_key=" + TMDBApiKey.ApiKey + "&language=en-US"))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<MovieDetails>(responseData);
                return model;
            }
        }
    }

    /// <summary>
    /// GetMovieReview
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<List<Review>> GetMovieReview(int? id)
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/" + id + "/reviews?api_key=" + TMDBApiKey.ApiKey))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<Root>(responseData);
                return model.results;
            }
        }
    }

    /// <summary>
    /// GetMovieCredits
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Credits> GetMovieCredits(int? id)
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/" + id + "/credits?api_key=" + TMDBApiKey.ApiKey + "&language=en-US"))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<Credits>(responseData);
                return model;
            }
        }
    }



    /// <summary>
    /// GetCreditsAsync
    /// </summary>
    /// <returns></returns>
    public async Task<List<CreditsDbo>> GetCreditsAsync(int? id)
    {
        var dbo = await db.CreditsDbo
            .Include(x => x.cast)
            .Include(x => x.crew)
            .Where(x => x.id == id).ToListAsync();
        return dbo;
    }


    /// <summary>
    /// GetGenreAsync
    /// </summary>
    /// <returns></returns>
    public async Task<List<GenreDbo>> GetGenreAsync(int? id)
    {
        var dbo = await db.GenreDbo.Where(x=>x.MovieDetailsDboId == id).ToListAsync();
        return dbo;
    }

    /// <summary>
    /// GetCastAsync
    /// </summary>
    /// <returns></returns>
    public async Task<List<CastDbo>> GetCastAsync(int? id)
    {
        var dbo = await db.CastDbo.Where(x => x.CreditsDboId == id).ToListAsync();
        return dbo;
    }

    /// <summary>
    /// GetCrewAsync
    /// </summary>
    /// <returns></returns>
    public async Task<List<CrewDbo>> GetCrewAsync(int? id)
    {
        var dbo = await db.CrewDbo.Where(x => x.CreditsDboId == id).ToListAsync();
        return dbo;
    }





    /// <summary>
    /// ImportPopularMoviesToDb
    /// </summary>
    /// <returns></returns>
    public async Task ImportPopularMoviesToDb()
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/popular?api_key=" + TMDBApiKey.ApiKey + "&language=en-US&page="))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<PopularMovies>(responseData);

                foreach (var movie in model.results)
                {
                    var movieDb = await db.Movies.FirstOrDefaultAsync(x => x.id == movie.id);
                    if (movieDb == null)
                    {
                        db.Movies.Add(movie);
                    }
                }
                await db.SaveChangesAsync();
            }
        }
    }
    
    /// <summary>
    /// ImportMovieDetailsToDb
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task ImportMovieDetailsToDb(int? id)
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/" + id + "?api_key=" + TMDBApiKey.ApiKey + "&language=en-US"))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<MovieDetailsBinding>(responseData);

                var movieDetails = await db.MovieDetailsDbo.FirstOrDefaultAsync(x => x.id == id);
                if (movieDetails == null)
                {
                    var dbo = mapper.Map<MovieDetailsDbo>(model);
                    db.MovieDetailsDbo.Add(dbo);
                }
                await db.SaveChangesAsync();
            }
        }
    }
    
    /// <summary>
    /// ImportMovieCreditsToDb
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task ImportMovieCreditsToDb(int? id)
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/" + id + "/credits?api_key=" + TMDBApiKey.ApiKey + "&language=en-US"))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<CreditsBinding>(responseData);

                var creditsId = await db.CreditsDbo.FirstOrDefaultAsync(x => x.id == id);
                if (creditsId == null)
                {
                    var dbo = mapper.Map<CreditsDbo>(model);
                    db.CreditsDbo.Add(dbo);
                }
                await db.SaveChangesAsync();
            }
        }
    }



}