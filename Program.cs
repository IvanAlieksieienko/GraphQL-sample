using Microsoft.EntityFrameworkCore;
using SampleHeroesWebAPI.Data;
using SampleHeroesWebAPI.Data.ContextConfigurations;
using SampleHeroesWebAPI.Data.Repositories;
using SampleHeroesWebAPI.Intefraces;
using Path = System.IO.Path;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = Path.Join(builder.Environment.ContentRootPath, "heroes.db");
    options.UseSqlite($"Data Source={connectionString}");
});

var app = builder.Build();

app.MapGraphQL(path: "/graphql");

app.Run();