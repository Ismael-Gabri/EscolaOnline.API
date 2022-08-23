using EscolaOnline.Api.Data;
using EscolaOnline.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<EscolaOnlineDataContext>();
builder.Services.AddTransient<TokenService>();



var app = builder.Build();

app.MapControllers();

app.Run();
