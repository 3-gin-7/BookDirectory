namespace Server.Api.Models;

public class Book{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!; // object
    public string Language { get; set; } = null!; // enum
    public string Country { get; set; } = null!; //enum
    public int Pages { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Spine { get; set; }
    public string Publisher { get; set; } = null!;
    public DateTime DatePublished { get; set; }
    public string City { get; set; } = null!;
    public string Genre { get; set; }= null!; //enum
    public int Rating { get; set; } //object
    public double Price { get; set; }
    public string Format { get; set; } = null!; //enum
}
