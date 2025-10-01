using Avaliacao1ProvaPratica.Repository;
using Avaliacao1ProvaPratica.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICandidatoRepository, CandidatoRepository>();
builder.Services.AddSingleton<IVotoService, VotoService>();
builder.Services.AddSingleton<ICandidadtoService, CandidatoService>();
builder.Services.AddSingleton<IVotoRepository, VotoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
