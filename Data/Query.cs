using SampleHeroesWebAPI.Data.ContextConfigurations;
using SampleHeroesWebAPI.Models;

namespace SampleHeroesWebAPI.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) => context.Superheros;
}