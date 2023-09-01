using System.Linq.Expressions;

namespace Data.Repository;

public interface IRepository<T> where T : class, new()
{
    List<T> GetAll();

    T GetById(int id);

    void Add(T entity);

    void Update(T entity);

    void Delete(T entity);

    void Delete(int id);

    Task SaveChangesAsync();

    List<T> GetByFilter(Expression<Func<T, bool>> filter);

    IQueryable<T> Table { get; }
}