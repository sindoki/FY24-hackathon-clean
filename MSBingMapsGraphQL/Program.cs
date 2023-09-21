using MSBingMapsGraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<RestaurantQuery>();
builder.Services.AddMvc();

var app = builder.Build();

app.MapGraphQL();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
