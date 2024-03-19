using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public string TeacherId { get; set; }

    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Teacher ID: {TeacherId}");
    }
}