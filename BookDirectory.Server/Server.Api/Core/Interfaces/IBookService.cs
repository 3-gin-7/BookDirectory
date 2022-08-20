using Server.Api.Models;
using Server.Api.Responses;

namespace Server.Api.Core.Interfaces;

public interface IBookService{
    public Task<BookResponse> AddBook(Book book);
    public Task<BookResponse> GetBook(Guid id);
    public BookResponse UpdateBook(Book book);
    public Task<BookResponse> DeleteBook(Guid id);
    public Task<BookListResponse> ListBooks();
}
