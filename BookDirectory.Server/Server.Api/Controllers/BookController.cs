using Microsoft.AspNetCore.Mvc;
using Server.Api.Core.Interfaces;
using Server.Api.Models;
using Server.Api.Responses;
using Swashbuckle.AspNetCore.Annotations;

namespace Server.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
[Produces("application/json")]
public class BookController : ControllerBase{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService){
        _bookService = bookService;
    }

    [SwaggerOperation(
            Summary = "Adding the book",
            Description = "Adds the book to the database"
            )]
    [SwaggerResponse(200, "Book added", typeof(BookResponse))]
    [SwaggerResponse(400, "Failed to add book", typeof(BadRequestResult))]
    [HttpPost]
    public async Task<IActionResult> AddBook(Book book){
        return Ok(await _bookService.AddBook(book));
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetBook(Guid id){
        return Ok(await _bookService.GetBook(id));
    }

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
