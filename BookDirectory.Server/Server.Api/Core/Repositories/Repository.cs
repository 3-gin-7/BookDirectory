using Microsoft.EntityFrameworkCore;
using Server.Api.Core.Interfaces;
using Server.Api.Data;

namespace Server.Api.Core.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    // protected readonly BookDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(BookDbContext context){
        // _context = context;
        _dbSet = context.Set<T>();
    }
    public async Task<bool> Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public async Task<IEnumerable<T>> All()
    {
        return await _dbSet.ToListAsync();
    }

    public bool Delete(T entity)
    {
        _dbSet.Remove(entity);
        return true;
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public bool Update(T entity)
    {
        _dbSet.Update(entity);
        return true;
    }
}
