using TimCoreysTestProject.TestEnvironment;

namespace TestEnvironmentTests;

public class FileLoadingSimulTest
{

    [Fact]
    public void LoadFile_ShouldWork()
    {
        //Arrange
        var fileName = "valid file name";

        //Act
        var result = FileLoadingSimul.LoadFile(fileName);

        //Assert
        Assert.NotNull(result);
    }
}
