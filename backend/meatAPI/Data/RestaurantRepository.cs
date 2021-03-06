using System.Runtime.Serialization.Json;
public static class RestaurantRepository {
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
      Hours = "Funciona de segunda à sexta, de 8h às 23h",
      Reviews = new List<Review>() {
        new Review() {
          Name = "Carlos",
          Rating = 4.6,
          Date = DateTime.Parse("15/02/2021"),
          Comments = "Ótimo lugar para comer!"
        },
        new Review() {
          Name = "Tui Reichert",
          Rating = 5,
          Date = DateTime.Parse("22/07/2022"),
          Comments = "Os doces são os melhores, super saborosos."
        },
        new Review() {
          Name = "Alex",
          Rating = 1.5,
          Date = DateTime.Parse("06/11/2021"),
          Comments = "Comida veio estragada!!! Pelo menos trocaram depois, mas foi muito demorado."
        },
        new Review() {
          Name = "Jão",
          Rating = 3.5,
          Date = DateTime.Parse("03/03/2022"),
          Comments = "Não agradou muito meu paladar... Mas minha esposa gostou"
        }
      },
      MenuItem = new List<MenuItem>() {
        new MenuItem() {
          Id = "1",
          Name = "Marmita M",
          Description = "Arroz, feijão, bife de frango, ovo frito e salada",
          ImagePath = "assets/img/foods/ceasar.png",
          Price = 12.90
        },
        new MenuItem() {
          Id = "2",
          Name = "Marmita G",
          Description = "Arroz, feijão, bife de frango, ovo frito e salada",
          ImagePath = "assets/img/foods/ceasar.png",
          Price = 14.50
        },
        new MenuItem() {
          Id = "3",
          Name = "Pão Integral",
          Description = "Pão caseiro da casa feito na hora!",
          ImagePath = "assets/img/foods/bread.png",
          Price = 14.50
        }
      }
    },
    new Restaurant() {
      Id = "burger-house",
      Name = "Burger House",
      Category = "Hamburgers",
      DeliveryEstimate = "100m",
      Rating = 3.5,
      ImagePath = "assets/img/restaurants/burgerhouse.png",
      About = "40 anos se especializando em trash food.",
      Hours = "Funciona todos os dias, de 10h às 22h",
      Reviews = new List<Review>() {
        new Review() {
          Name = "Alberto",
          Rating = 5,
          Date = DateTime.Parse("15/02/2021"),
          Comments = "Ótimo lugar para comer!"
        },
        new Review() {
          Name = "Jhon",
          Rating = 5,
          Date = DateTime.Parse("22/07/2022"),
          Comments = "Os doces são os melhores, super saborosos."
        },
        new Review() {
          Name = "Laura",
          Rating = 3.3,
          Date = DateTime.Parse("06/11/2021"),
          Comments = "Comida veio estragada!!! Pelo menos trocaram depois, mas foi muito demorado."
        }
      },
      MenuItem = new List<MenuItem>() {
        new MenuItem() {
          Id = "1",
          Name = "Fatia de Bolo",
          Description = "Fatia de Bolo de Morango",
          ImagePath = "assets/img/foods/cake.png",
          Price = 12.90
        },
        new MenuItem() {
          Id = "2",
          Name = "Bolo de Morango",
          Description = "Bolo recheado e coberto com morangos",
          ImagePath = "assets/img/foods/straw.png",
          Price = 14.50
        },
        new MenuItem() {
          Id = "3",
          Name = "Cup Cake de Choc. Branco",
          Description = "Cup Cake de chocolate branco",
          ImagePath = "assets/img/foods/cupcake.png",
          Price = 14.50
        }
      }
      },

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

  public static Restaurant? GetById(string id) {
      return Restaurants.FirstOrDefault(r => r.Id == id);
  }

  public static List<Restaurant> GetAll() {
    return Restaurants;
  }

  public static List<Review>? GetReviewsOfRestaurant(string id) {
    return Restaurants.FirstOrDefault(r => r.Id == id).Reviews;
  }

  public static List<MenuItem>? GetMenuOfRestaurant(string id) {
    return Restaurants.FirstOrDefault(r => r.Id == id).MenuItem;
  }
}
