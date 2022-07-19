public class MenuItem {
  public string Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string ImagePath { get; set; }
  public double Price { get; set; }

  public MenuItem(string id, string name, string description, string imagePath, double price) {
    Id = id;
    Name = name;
    Description = description;
    ImagePath = imagePath;
    Price = price;
  }

  public MenuItem() { }
}
