using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MSBingMapsExtended.Data;
using MSBingMapsExtended.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<GPTService>();
builder.Services.AddSingleton<GraphQLService>();
builder.Services.AddSingleton(provider => new QueryCreator(provider.GetService<GraphQLService>(), provider.GetService<GPTService>()));
builder.Services.AddSingleton(provider => new GraphGPTService(provider.GetService<GraphQLService>(), provider.GetService<GPTService>(), provider.GetService<QueryCreator>()));

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5195",
                                              "http://localhost:5044");
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
