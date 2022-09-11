namespace TMDB.MVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Movies> Movies { get; set; }
    public DbSet<MovieDetailsDbo> MovieDetailsDbo { get; set; }
    public DbSet<GenreDbo> GenreDbo { get; set; }
    
    //public DbSet<BelongsToCollectionDbo> BelongsToCollectionDbo { get; set; }
    public DbSet<ProductionCompanyDbo> ProductionCompanyDbo { get; set; }
    public DbSet<ProductionCountryDbo> ProductionCountryDbo { get; set; }
    public DbSet<SpokenLanguageDbo> SpokenLanguageDbo { get; set; }


    public DbSet<CreditsDbo> CreditsDbo { get; set; }
    public DbSet<CastDbo> CastDbo { get; set; }
    public DbSet<CrewDbo> CrewDbo { get; set; }


}
