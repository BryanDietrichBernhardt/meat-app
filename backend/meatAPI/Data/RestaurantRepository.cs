using System.Runtime.Serialization.Json;
public static class RestaurantRepository {

  public static List<Restaurant> Restaurants2 { get; set; } = new List<Restaurant>();

  public static List<Restaurant> Restaurants { get; set; } = new List<Restaurant>()
  {
    new Restaurant() {
      Id = "bread-bakery",
      Name = "Bread & Bakery",
      Category = "Bakery",
      DeliveryEstimate = "25m",
      Rating = 4.9,
      ImagePath = "assets/img/restaurants/breadbakery.png",
      About = "A Bread & Brakery tem 40 anos de mercado. Fazemos os melhores doces e pães. Compre e confira.",
      Hours = "Funciona de segunda à sexta, de 8h às 23h"},
    new Restaurant() {
      Id = "burger-house",
      Name = "Burger House",
      Category = "Hamburgers",
      DeliveryEstimate = "100m",
      Rating = 3.5,
      ImagePath = "assets/img/restaurants/burgerhouse.png",
      About = "40 anos se especializando em trash food.",
      Hours = "Funciona todos os dias, de 10h às 22h"},
    new Restaurant() {
      Id = "coffee-corner",
      Name = "Coffee Corner",
      Category = "Coffee Shop",
      DeliveryEstimate = "30-40m",
      Rating = 4.8,
      ImagePath = "assets/img/restaurants/coffeecorner.png",
      About = "A Coffe Corner foi eleita a melhor cafeteria da cidade.",
      Hours = "Funciona de segunda à sábado, de 6h às 22h"},
    new Restaurant() {
      Id = "green-food",
      Name = "Green Food",
      Category = "Saudável",
      DeliveryEstimate = "75m",
      Rating = 4.1,
      ImagePath = "assets/img/restaurants/greenfood.png",
      About = "Comida saudável é no Green Food. Compramos barato, vendemos caro.",
      Hours = "Somente em horário de almoço, das 11h às 15h"},
    new Restaurant() {
      Id = "ice-cream",
      Name = "Ice Cream",
      Category = "Ice Creams",
      DeliveryEstimate = "40-65m",
      Rating = 4.5,
      ImagePath = "assets/img/restaurants/icy.png",
      About = "A Ice Cream é uma sorveteria inovadora.",
      Hours = "Funciona todos os dias, de 10h às 1h"},
  };

  public static void Add(Restaurant restaurant) {
      Restaurants.Add(restaurant);
  }

  public static Restaurant? GetBy(string id) {
      return Restaurants.FirstOrDefault(r => r.Id == id);
  }

  public static List<Restaurant> GetAll() {
    return Restaurants;
  }
}
