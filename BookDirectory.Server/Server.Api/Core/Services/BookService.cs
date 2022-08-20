using Server.Api.Core.Enums;
using Server.Api.Core.Interfaces;
using Server.Api.Models;
using Server.Api.Responses;

namespace Server.Api.Core.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepo;

    public BookService(IBookRepository bookRepo)
    {
        _bookRepo = bookRepo;
    }

    public async Task<BookResponse> AddBook(Book book)
    {
        try{
            await _bookRepo.Add(book);
            return new BookResponse(book, "Book Added", ResponseStatusEnum.Success);
        }catch(Exception e){
            return new BookResponse(null, "Failed to Add book", ResponseStatusEnum.Failure, e.Message);
        }
    }

    public async Task<BookResponse> DeleteBook(Guid id)
    {
        try
        {
            var book = await _bookRepo.GetById(id);
            if(book is null) return new BookResponse(null, "Failed to delete the book", ResponseStatusEnum.Failure, "Book not found");
            _bookRepo.Delete(book);
            return new BookResponse(book, "Book Deleted", ResponseStatusEnum.Success);
        }
        catch (Exception e)
        {
            return new BookResponse(null, "Failed to delete book", ResponseStatusEnum.Failure, e.Message);
        }
    }

    public async Task<BookResponse> GetBook(Guid id)
    {
        try{
            var book = await _bookRepo.GetById(id);
            if(book is null) return new BookResponse(null, "Failed to fetch the book", ResponseStatusEnum.Failure, "Book not found");
            return new BookResponse(book, "Book fetched", ResponseStatusEnum.Success);
        }catch(Exception e){
            return new BookResponse(null, "Failed to fetch book", ResponseStatusEnum.Failure, e.Message);
        }
    }

    public async Task<BookListResponse> ListBooks()
    {
        try{
            var books = await _bookRepo.All();
            return new BookListResponse(books, "Books fetched", ResponseStatusEnum.Success);
        }catch(Exception e){
            return new BookListResponse(null, "Failed to fetch books", ResponseStatusEnum.Failure, e.Message); 
        }
    }

    public BookResponse UpdateBook(Book book)
    {
        //TODO find better way to update with mapper?
        try
        {
            _bookRepo.Update(book);
            return new BookResponse(book, "Book updated", ResponseStatusEnum.Success);
        }
        catch (Exception e)
        {
            return new BookResponse(null, "Failed to update book", ResponseStatusEnum.Failure, e.Message);
            throw;
        }
    }
}
