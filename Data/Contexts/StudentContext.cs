using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class StudentContext : DbContext
{
    public StudentContext()
    {
        
    }

    public StudentContext(DbContextOptions<StudentContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<StudentNotes> StudentNotes { get; set; }
}