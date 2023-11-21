using FakePerson.lib.Models.Names;

namespace FakePerson.lib;

public class RandomRussianName : IRandom<RussianName>
{
    private readonly IEnumerable<string> _listOfLastNames;

    private readonly IEnumerable<string> _listOfFirstNames;

    private readonly IEnumerable<string> _listOfPatronymics;

    public RandomRussianName()
    {
        _listOfLastNames = new List<string>() { "Сидоров", "Иванов", "Петров" };
        _listOfFirstNames = new List<string>() { "Иван", "Петр", "Василий" };
        _listOfPatronymics = new List<string>() { "Иванович", "Петрович", "Васильевич" };
    }

    public RussianName Get()
    {
        var random = new Random();
        return new RussianName()
        {
            LastName = random.NextString(_listOfLastNames),
            FirstName = random.NextString(_listOfFirstNames),
            Patronymic = random.NextString(_listOfPatronymics)
        };
    }
}