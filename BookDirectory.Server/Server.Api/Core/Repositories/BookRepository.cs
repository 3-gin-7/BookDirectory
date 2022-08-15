using Server.Api.Core.Interfaces;
using Server.Api.Data;

namespace Server.Api.Core.Repository;

public class BookRepository : Repository<Book>, IBookRepository{

    public BookRepository(BookDbContext context):base(context)
    {
    }
}
