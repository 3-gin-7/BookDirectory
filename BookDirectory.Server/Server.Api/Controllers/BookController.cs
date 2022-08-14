using Microsoft.AspNetCore.Mvc;

namespace Server.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BookController : ControllerBase{
    // Create book api 
    public void AddBook(){}
    // Read book
    public void GetBook(){}
    // Update book
    public void UpdateBook(){}
    // Delete book
    public void RemoveBook(){}

    public void GetAllBooks(){}
}
