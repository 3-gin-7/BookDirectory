using Server.Api.Core.Interfaces;
using Server.Api.Data;
using Server.Api.Models;

namespace Server.Api.Core.Repository;

public class BookRepository : Repository<Book>, IBookRepository{

    public BookRepository(BookDbContext context):base(context)
    {
    }

    public Task<Book> Test()
    {
        throw new NotImplementedException();
    }
}
