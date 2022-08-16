using Microsoft.AspNetCore.Mvc;
using Server.Api.Core.Interfaces;
using Server.Api.Models;

namespace Server.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BookController : ControllerBase{
    private readonly IUnitOfWork _unitOfWork;

    public BookController(IUnitOfWork unitOfWork){
        _unitOfWork = unitOfWork;
    }

    // Create book api 
    [HttpPost]
    public void AddBook(Book book){
        _unitOfWork.Books.Add(book);
    }

    // Read book
    [HttpGet]
    public void GetBook(){}
    // Update book
    [HttpPut]
    public void UpdateBook(){}
    // Delete book
    [HttpDelete]
    public void RemoveBook(){}
    [HttpGet]
    public void GetAllBooks(){}
}
