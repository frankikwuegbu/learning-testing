using TimCoreysTestProject.TestEnvironment;

namespace TestEnvironmentTests;

public class DataAccessTests
{
    [Fact]
    public void AddPersonToPeopleList_ShouldAddPersonToList()
    {
        //Arrange
        var person = new PersonModel { FirstName = "John", LastName = "Doe"};

        List<PersonModel> people = [];

        //Act
        DataAccess.AddPersonToPeopleList(person, people);

        //Assert
        Assert.True(people.Count == 1);
    }

    [Fact]
    public void ConvertToCsvSimul_ShouldReturnList()
    {
        //Arrange
        var person1 = new PersonModel { FirstName = "John", LastName = "Doe" };
        var person2 = new PersonModel { FirstName = "Jane", LastName = "Doe" };

        List<PersonModel> people = [person1, person2];

        //Act
        var result = DataAccess.ConvertToCsvSimul(people);

        //Assert
        Assert.True(result.Count == 2);
    }

    [Fact]
    public void ConvertToList_ShouldWork()
    {
        //Arrange
        var person = new PersonModel { FirstName = "John", LastName = "Doe" };

        var expected = new List<PersonModel> { person };

        string[] content = [$"{person.FirstName},{person.LastName}"];

        //Act
        var result = DataAccess.ConvertToList(content);

        //Assert
        Assert.True(result.Count == 1);

        //Equal() uses reference equality for objects. so we compare object properties instead
        Assert.Equal(expected[0].FirstName, result[0].FirstName);
        Assert.Equal(expected[0].LastName, result[0].LastName);
    }
}
