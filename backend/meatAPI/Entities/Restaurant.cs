public class Restaurant {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string DeliveryEstimate { get; set; }
    public double Rating { get; set; }
    public string ImagePath { get; set; }
    public string About { get; set; }
    public string Hours { get; set; }

  public Restaurant(string id, string name, string category, string deliveryEstimate, double rating, string imagePath, string about, string hours)
  {
    Id = id;
    Name = name;
    Category = category;
    DeliveryEstimate = deliveryEstimate;
    Rating = rating;
    ImagePath = imagePath;
    About = about;
    Hours = hours;
  }

  public Restaurant()
  {
  }
}
