namespace TimCoreysTestProject.TestEnvironment;

public static class FileLoadingSimul
{
    public static string LoadFile(string fileName)
    {
        if (fileName.Length < 10)
        {
            throw new FileNotFoundException();
        }

        return "file successfully loaded";
    }

    public static string LoadFileWithCustomError(string fileName)
    {
        if (fileName.Length < 10)
        {
            throw new ArgumentException("could not load file", nameof(fileName));
        }

        return "file successfully loaded";
    }
}