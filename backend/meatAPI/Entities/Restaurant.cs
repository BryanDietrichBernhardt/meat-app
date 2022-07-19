public class Restaurant {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string DeliveryEstimate { get; set; }
    public double Rating { get; set; }
    public string ImagePath { get; set; }
    public string About { get; set; }
    public string Hours { get; set; }
    public List<Review> Reviews { get; set; }
    public List<MenuItem> MenuItem { get; set; }

  public Restaurant(string id, string name, string category, string deliveryEstimate, double rating, string imagePath, string about, string hours, List<Review> reviews, List<MenuItem> menuItem)
  {
    Id = id;
    Name = name;
    Category = category;
    DeliveryEstimate = deliveryEstimate;
    Rating = rating;
    ImagePath = imagePath;
    About = about;
    Hours = hours;
    Reviews = reviews;
    MenuItem = menuItem;
  }

  public Restaurant()
  {
  }
}
