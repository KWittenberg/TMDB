namespace TMDB.MVC.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // MovieDetails
        CreateMap<MovieDetailsBinding, MovieDetailsDbo>();
        CreateMap<MovieDetailsDbo, MovieDetailsViewModel>();

        CreateMap<BelongsToCollectionBinding, BelongsToCollectionDbo>();

        CreateMap<GenreBinding, GenreDbo>();

        CreateMap<ProductionCompanyBinding, ProductionCompanyDbo>();

        CreateMap<ProductionCountryBinding, ProductionCountryDbo>();

        CreateMap<SpokenLanguageBinding, SpokenLanguageDbo>();

        CreateMap<CreditsBinding, CreditsDbo>();
        CreateMap<CastBinding, CastDbo>();
        CreateMap<CrewBinding, CrewDbo>();
    }
}
