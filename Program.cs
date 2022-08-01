using EscolaOnline.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<EscolaOnlineDataContext>();

var app = builder.Build();

app.MapControllers();

app.Run();
