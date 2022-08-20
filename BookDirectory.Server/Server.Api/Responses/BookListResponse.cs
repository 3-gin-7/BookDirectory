using Server.Api.Core.Enums;
using Server.Api.Core.Response;
using Server.Api.Models;

namespace Server.Api.Responses;

public class BookListResponse : BaseResponse{
    public IEnumerable<Book>? Books { get; set; }

    public BookListResponse(IEnumerable<Book>? books,
            string message,
            ResponseStatusEnum statusCode,
            string? errorMessage = null) : base(message, statusCode, errorMessage){
        Books = books;
    }
}
