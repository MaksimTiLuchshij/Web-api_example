using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IMovie, MockMovie>();
builder.Services.AddControllers();

var app = builder.Build();



app.UseHttpsRedirection();
app.MapControllers();

app.UseDefaultFiles(); // можно заменить
app.UseStaticFiles(); // на app.UseFileServer();

app.Run();