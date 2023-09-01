using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repository;
public class Repository<T> : IRepository<T> where T : class, new()
{
    private readonly StudentContext _context;
    private readonly DbSet<T> _table;

    public Repository(StudentContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public IQueryable<T> Table => _table;

    public void Add(T entity)
    {
        _table.Add(entity);
    }

    public void Delete(T entity)
    {
        _table.Remove(entity);
    }

    public void Delete(int id)
    {
        var entity = _table.Find(id);

        _table.Remove(entity);
    }

    public List<T> GetAll()
    {
        return _table.ToList();
    }

    public List<T> GetByFilter(Expression<Func<T, bool>> filter)
    {
        return _table.Where(filter).ToList();
    }

    public T GetById(int id)
    {
        return _table.Find(id);
    }

    public Task SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    public void Update(T entity)
    {
        _table.Update(entity);
    }
}