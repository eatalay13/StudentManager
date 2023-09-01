namespace Data.Models;

public class StudentNotes
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int LessonId { get; set; }
    public string Note { get; set; }

    public virtual Student Student { get; set; }
    public virtual Lesson Lesson { get; set; }
}
