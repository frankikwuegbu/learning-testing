namespace TimCoreysTestProject.TestEnvironment;

public static class DataAccess
{
    private static string personTextFile = "PersonText.txt";

    public static void AddNewPerson(PersonModel person)
    {
        List<PersonModel> people = GetAllPeople();

        AddPersonToPeopleList(person, people);

        List<string> lines = ConvertToCsvSimul(people);

        File.WriteAllLines(personTextFile, lines);
    }

    public static void AddPersonToPeopleList(PersonModel person, List<PersonModel> people)
    {
        people.Add(person);
    }

    public static List<string> ConvertToCsvSimul(List<PersonModel> people)
    {
        List<string> output = [];

        foreach (PersonModel person in people)
        {
            output.Add($"{person.FirstName} + {person.LastName}");
        }

        return output;
    }

    public static List<PersonModel> GetAllPeople()
    {
        string[] content = File.ReadAllLines(personTextFile);

        var allPeople = ConvertToList(content);

        return allPeople;
    }

    public static List<PersonModel> ConvertToList(string[] content)
    {
        List<PersonModel> output = [];

        foreach (var person in content)
        {
            string[] name = person.Split(",");

            output.Add(new PersonModel { FirstName = name[0], LastName = name[1] });
        }

        return output;
    }
}