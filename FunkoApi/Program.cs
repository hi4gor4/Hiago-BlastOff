using FunkoApi.DataContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<FunkoApiContext>();
var app = builder.Build();


app.MapControllers();

app.Run();
