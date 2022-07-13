using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to Meat API!");
app.MapGet("/restaurants", () => {
    return RestaurantRepository.GetAll();
  });

app.Run();
