﻿namespace Data.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public ICollection<StudentNotes> StudentNotes { get; set; }
}