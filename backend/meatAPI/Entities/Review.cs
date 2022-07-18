public class Review {
  public string Name { get; set; }
  public double Rating { get; set; }
  public DateTime Date { get; set; }
  public string Comments { get; set; }

  public Review(string name, double rating, DateTime date, string comments)
  {
    Name = name;
    Rating = rating;
    Date = date;
    Comments = comments;
  }

  public Review(){}

}
