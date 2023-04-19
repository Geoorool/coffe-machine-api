using MachineHttpApi.Services;
using MachineHttpApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICoffeeService, CoffeeService>();
builder.Services.AddSingleton<IRecipeService, RecipeService>();
builder.Services.AddSingleton<IServiceService, ServiceService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();