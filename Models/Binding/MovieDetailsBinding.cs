namespace TMDB.MVC.Models;

public class MovieDetailsBinding
{
    public bool? adult { get; set; }
    public string? backdrop_path { get; set; }
    //public BelongsToCollectionDbo belongs_to_collection { get; set; }
    public int budget { get; set; }
    public List<GenreBinding> genres { get; set; }
    public string? homepage { get; set; }
    public int id { get; set; }
    public string? imdb_id { get; set; }
    public string? original_language { get; set; }
    public string? original_title { get; set; }
    public string? overview { get; set; }
    public double? popularity { get; set; }
    public string? poster_path { get; set; }
    public List<ProductionCompanyBinding> production_companies { get; set; }
    public List<ProductionCountryBinding> production_countries { get; set; }
    public string? release_date { get; set; }
    public int? revenue { get; set; }
    public int? runtime { get; set; }
    public List<SpokenLanguageBinding> spoken_languages { get; set; }
    public string? status { get; set; }
    public string? tagline { get; set; }
    public string? title { get; set; }
    public bool? video { get; set; }
    public double? vote_average { get; set; }
    public int? vote_count { get; set; }
}


public class BelongsToCollectionBinding
{
    public string? name { get; set; }
    public string? poster_path { get; set; }
    public string? backdrop_path { get; set; }
}

public class GenreBinding
{
    public string? name { get; set; }
}

public class ProductionCompanyBinding
{
    public string? logo_path { get; set; }
    public string? name { get; set; }
    public string? origin_country { get; set; }
}

public class ProductionCountryBinding
{
    public string? iso_3166_1 { get; set; }
    public string? name { get; set; }
}

public class SpokenLanguageBinding
{
    public string? english_name { get; set; }
    public string? iso_639_1 { get; set; }
    public string? name { get; set; }
}