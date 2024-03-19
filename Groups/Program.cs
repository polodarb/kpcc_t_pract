using Groups.Implementions;
using Students.Implementations;

namespace Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new StudentEntity { Id = 1, Name = "John", StudentId = "S001" };
            var student2 = new StudentEntity { Id = 2, Name = "Alice", StudentId = "S002" };
            
            var teacher = new TeacherEntity { Id = 1, Name = "Mr. Vasya", TeacherId = "T001" };
            
            var group = new GroupEntity { Id = 1, Name = "Mathematics" };
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AssignTeacher(teacher);

            group.DisplayGroupInfo();
        }
    }
}