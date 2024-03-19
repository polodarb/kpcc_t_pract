using Groups.Implementions;
using Students.Implementations;

namespace Groups.Implementions;

public class GroupEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<StudentEntity> Students { get; set; }
    public TeacherEntity Teacher { get; set; }

    public GroupEntity()
    {
        Students = new List<StudentEntity>();
    }

    public void AddStudent(StudentEntity student)
    {
        Students.Add(student);
        student.GroupId = Id;
    }

    public void AssignTeacher(TeacherEntity teacher)
    {
        Teacher = teacher;
    }

    public void DisplayGroupInfo()
    {
        Console.WriteLine($"Group: {Name}, Group ID: {Id}");
        Console.WriteLine($"Teacher: {Teacher?.Name ?? "No teacher assigned"}");
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.DisplayStudentInfo();
        }
    }
}