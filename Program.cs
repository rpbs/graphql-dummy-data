using GraphiQl;
using GraphQL;
using GraphQL.Types;
using graphql_dummy_data;
using graphql_dummy_data.Interfaces;
using graphql_dummy_data.Queries;
using graphql_dummy_data.Repos;
using graphql_dummy_data.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICarRepository, CarRepository>();

builder.Services.AddTransient<CarType>();
builder.Services.AddTransient<BrandType>();

builder.Services.AddTransient<RootQuery>();
builder.Services.AddTransient<CarQuery>();
builder.Services.AddTransient<BrandQuery>();


builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services
    .AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson().AddErrorInfoProvider(opt => opt.ExposeExceptionDetails = true));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();


app.UseHttpsRedirection();

app.MapControllers();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
