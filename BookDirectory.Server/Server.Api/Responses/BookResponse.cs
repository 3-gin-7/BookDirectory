using Server.Api.Core.Enums;
using Server.Api.Core.Response;
using Server.Api.Models;

namespace Server.Api.Responses;

public class BookResponse : BaseResponse{
    public Book? Book { get; set; }

    public BookResponse(Book? book,
            string message,
            ResponseStatusEnum statusCode,
            string? errorMessage = null) : base(message, statusCode,errorMessage){
        Book = book;
    }
}
