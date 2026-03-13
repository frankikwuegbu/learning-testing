using TimCoreysTestProject.TestEnvironment;

namespace TestEnvironmentTests;

public class FileLoadingSimulTest
{

    [Fact]
    public void LoadFile_ShouldWork()
    {
        //Arrange
        var fileName = "valid file name";
        var expectedResult = "file successfully loaded";

        //Act
        var actualResult = FileLoadingSimul.LoadFile(fileName);

        //Assert
        Assert.Contains(expectedResult, actualResult);
    }

    [Fact]
    public void LoadFile_ShouldFail()
    {
        //Arrange
        var fileName = "doc";

        //Act + Assert
        Assert.Throws<FileNotFoundException>(() =>  FileLoadingSimul.LoadFile(fileName));
    }

    [Fact]
    public void LoadFileWithCustomError_ShouldFail()
    {
        //Arrange
        var fileName = "doc";

        //Act +Assert
        Assert.Throws<ArgumentException>(fileName, () => FileLoadingSimul.LoadFileWithCustomError(fileName));
    }
}
