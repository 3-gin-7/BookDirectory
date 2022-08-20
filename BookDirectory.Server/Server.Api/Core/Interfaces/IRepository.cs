namespace Server.Api.Core.Interfaces;

public interface IRepository<T> where T : class{
    Task<IEnumerable<T>> All();
    Task<T?> GetById(Guid id);
    Task<bool> Add(T entity);
    bool Delete(T entity);
    bool Update(T entity);
}
