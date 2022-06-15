var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{nome}", (string nome) => {
    return Results.Ok($"Tudo certo na bahia {nome}, terra linda de meu Deus");
});

app.Run();
