using Microsoft.AspNetCore.Mvc;
using Server.Api.Core.Interfaces;
using Server.Api.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Server.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
[Produces("application/json")]
public class BookController : ControllerBase{
    private readonly IUnitOfWork _unitOfWork;

    public BookController(IUnitOfWork unitOfWork){
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    public void AddBook(Book book){
        _unitOfWork.Books.Add(book);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public void GetBook(Guid id){}
    
    [SwaggerOperation(
        Summary = "summary",
        Description = "description"
    )]
    [SwaggerResponse(201, "Book updated", typeof(Book))]
    [SwaggerResponse(400, "Failed to update the book", typeof(Book))]
    [HttpPut]
    public void UpdateBook(){}
    // Delete book
    [HttpDelete]
    public void RemoveBook(){}
    [HttpGet]
    public void GetAllBooks(){}
}
