namespace FakePerson.lib.Models.Names;

public record RussianName : AbstractName
{
    public required string LastName { get; init; }

    public string? Patronymic { get; init; }
}