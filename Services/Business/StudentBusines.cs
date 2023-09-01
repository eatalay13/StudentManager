using Data.Models;
using Data.Repository;

namespace Services.Business;

public class StudentBusines
{
    private readonly IRepository<Student> _repository;

    public StudentBusines(IRepository<Student> repository)
    {
        _repository = repository;
    }

    public void Add(Student student)
    {
        _repository.Add(student);

        _repository.SaveChangesAsync();
    }
}