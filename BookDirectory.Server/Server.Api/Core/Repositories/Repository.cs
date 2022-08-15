using Microsoft.EntityFrameworkCore;
using Server.Api.Core.Interfaces;
using Server.Api.Data;

namespace Server.Api.Core.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly BookDbContext _context;
    protected readonly DbSet<T> dbSet = null!;

    public Repository(BookDbContext context){
        _context = context;
    }
    public async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return true;
    }

    public Task<IEnumerable<T>> All()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
