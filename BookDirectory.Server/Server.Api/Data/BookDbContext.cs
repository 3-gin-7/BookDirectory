using Microsoft.EntityFrameworkCore;
using Server.Api.Models;

namespace Server.Api.Data;

public class BookDbContext : DbContext{
    public virtual DbSet<Book> Books { get; set; }
    public BookDbContext(DbContextOptions<BookDbContext> opt): base(opt){
        Books = Set<Book>();
    }
}
