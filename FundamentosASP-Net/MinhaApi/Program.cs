var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Tudo certo na bahia, terra linda de meu Deus");
});

app.Run();
