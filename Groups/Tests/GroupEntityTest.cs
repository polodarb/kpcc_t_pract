using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students.Implementations;

namespace Groups.Tests;

using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class GroupEntityTests
{
    [Test]
    public void AddStudent_StudentIsAddedToGroup()
    {
        // Arrange
        var group = new GroupEntity { Id = 1, Name = "Group A" };
        var student = new StudentEntity();

        // Act
        group.AddStudent(student);

        // Assert
        Assert.Equals(1, group.Students.Count);
        Assert.Equals(1, student.GroupId);
    }

    [Test]
    public void AssignTeacher_TeacherIsAssignedToGroup()
    {
        // Arrange
        var group = new GroupEntity { Id = 1, Name = "Group A" };
        var teacher = new TeacherEntity();

        // Act
        group.AssignTeacher(teacher);

        // Assert
        Assert.Equals(teacher, group.Teacher);
    }

    [Test]
    public void DisplayGroupInfo_PrintsCorrectInfo()
    {
        // Arrange
        var group = new GroupEntity { Id = 1, Name = "Group A" };
        var teacher = new TeacherEntity();
        group.AssignTeacher(teacher);

        var student1 = new StudentEntity { StudentId = "S123", GroupId = 1 };
        var student2 = new StudentEntity { StudentId = "S456", GroupId = 1 };
        group.AddStudent(student1);
        group.AddStudent(student2);

        // Capture console output
        var consoleOut = new StringWriter();
        Console.SetOut(consoleOut);

        // Act
        group.DisplayGroupInfo();
        var output = consoleOut.ToString().Trim();

        // Assert
        StringAssert.Contains($"Group: {group.Name}, Group ID: {group.Id}", output);
        StringAssert.Contains($"Teacher: {teacher.Name ?? "No teacher assigned"}", output);
        StringAssert.Contains($"Student: {student1.Name}, Student ID: {student1.StudentId}, Group ID: {student1.GroupId}", output);
        StringAssert.Contains($"Student: {student2.Name}, Student ID: {student2.StudentId}, Group ID: {student2.GroupId}", output);
    }
}
