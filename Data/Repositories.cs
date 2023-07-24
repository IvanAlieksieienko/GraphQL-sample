using SampleHeroesWebAPI.Data.ContextConfigurations;
using SampleHeroesWebAPI.Intefraces;

namespace SampleHeroesWebAPI.Data.Repositories;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public SuperheroRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}

public class SuperpowerRepository : ISuperpowerRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public SuperpowerRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public MovieRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}