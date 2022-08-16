using Server.Api.Core.Interfaces;
using Server.Api.Data;

namespace Server.Api.Core.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly BookDbContext _bookDbContext;

    public IBookRepository Books { get; init; }

    public UnitOfWork(BookDbContext bookDbContext){
        _bookDbContext = bookDbContext;
        Books = new BookRepository(_bookDbContext);
    }

    public async Task CompleteAsync()
    {
        await _bookDbContext.SaveChangesAsync();
    }
}
