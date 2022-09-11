namespace TMDB.MVC.Services.Interface;

public interface IMovieService
{
    Task<List<Movies>> GetPopularMovies();
    Task<MovieDetails> GetMovieDetails(int? id);
    Task<List<Review>> GetMovieReview(int? id);
    Task<Credits> GetMovieCredits(int? id);


    Task<List<GenreDbo>> GetGenreAsync(int? id);





    Task ImportPopularMoviesToDb();
    Task ImportMovieDetailsToDb(int? id);
}