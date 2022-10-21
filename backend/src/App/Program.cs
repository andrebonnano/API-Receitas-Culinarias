using Api.Setup;
using Application.Interfaces;
using Application.Services;
using Infra.Interfaces.Repositories;
using Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region == Dependency Injection ==
builder.Services.AddScoped<IRecipesRepo, RecipesRepo>();
builder.Services.AddScoped<ICategoriesRepo, CategoriesRepo>();
builder.Services.AddScoped<ICategoriesGetAllService, CategoriesGetAllService>();
#endregion


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
