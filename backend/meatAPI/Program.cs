using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to Meat API!");
app.MapGet("/restaurants", () => {
    return RestaurantRepository.GetAll();
  });
app.MapGet("/restaurants/{id}", ([FromRoute] string id) => {
  return RestaurantRepository.GetById(id);
});
app.MapGet("/restaurants/{id}/reviews", ([FromRoute] string id) => {
  return RestaurantRepository.GetReviewsOfRestaurant(id);
});

app.Run();
