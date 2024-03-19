namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public string StudentId { get; set; }
    public int GroupId { get; set; }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student: {Name}, Student ID: {StudentId}, Group ID: {GroupId}");
    }
}