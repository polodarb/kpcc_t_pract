using Students.Implementations;

namespace Groups.Tests;

using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class TeacherEntityTests
{
    [Test]
    public void DisplayTeacherInfo_PrintsCorrectInfo()
    {
        // Arrange
        var teacher = new TeacherEntity
        {
            Name = "John Doe",
            TeacherId = "T123"
        };

        // Capture console output
        var consoleOut = new StringWriter();
        Console.SetOut(consoleOut);

        // Act
        teacher.DisplayTeacherInfo();
        var output = consoleOut.ToString().Trim();

        // Assert
        Assert.Equals($"Teacher: {teacher.Name}, Teacher ID: {teacher.TeacherId}", output);
    }
}
