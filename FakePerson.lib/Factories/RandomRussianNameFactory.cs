using FakePerson.lib.Models.Names;
using FakePerson.lib.Randomizers;
using FakePerson.lib.Randomizers.Names;

namespace FakePerson.lib.Factories;

public class RandomRussianNameFactory : IFactory<RussianName>
{
    private readonly IRandom<RussianName> _random = new RandomRussianName();

    public RussianName Create()
    {
        return _random.Get();
    }
}