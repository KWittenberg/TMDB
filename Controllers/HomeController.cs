namespace TMDB.MVC.Controllers;

public class HomeController : Controller
{


    /// <summary>
    /// Get Popular Movies
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> IndexAsync()
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        var baseAddress = new Uri("http://api.themoviedb.org/3/");

        using (var httpClient = new HttpClient { BaseAddress = baseAddress })
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

            using (var response = await httpClient.GetAsync("movie/popular?api_key="+ TMDBApiKey.ApiKey +"&language=en-US&page="))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<PopularMovies>(responseData);
                return View(model.results);
            }
        }
    }

    /// <summary>
    /// GET: Movie/Details/5
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<IActionResult> Details(int? id)
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
                return View(model);
            }
        }
    }


    /// <summary>
    /// GET: Review
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<IActionResult> Review(int? id)
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
                return View(model);
            }
        }
    }







    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
