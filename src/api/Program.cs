var builder = WebApplication........CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/health", () => Results.Ok("Healthy"));

app.MapGet("/version", () =>
{
    var version = Environment.GetEnvironmentVariable("APP_VERSION") ?? "local";
    return Results.Ok(new { version });
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
