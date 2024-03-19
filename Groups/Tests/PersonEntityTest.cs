using Groups.Implementions;
using NUnit.Framework;

namespace Groups.Tests;

[TestFixture]
public class PersonEntityTests
{
    [Test]
    public void PersonEntity_ConstructsObjectWithCorrectProperties()
    {
        // Arrange
        int expectedId = 1;
        string expectedName = "John";

        // Act
        var person = new PersonEntity
        {
            Id = expectedId,
            Name = expectedName
        };

        // Assert
        Assert.Equals(expectedId, person.Id);
        Assert.Equals(expectedName, person.Name);
    }
}