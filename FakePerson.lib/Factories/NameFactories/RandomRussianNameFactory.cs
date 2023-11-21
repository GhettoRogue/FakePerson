using FakePerson.lib.Models.Names;

namespace FakePerson.lib.Factories.NameFactories;

public class RandomRussianNameFactory : IFactory<RussianName>
{
    private readonly IRandom<RussianName> _random = new RandomRussianName();

    public RussianName Create()
    {
        return _random.Get();
    }
}