using FakePerson.lib.Factories;
using FakePerson.lib.Models.Names;
using FakePerson.lib.Randomizers;
using FakePerson.Lib.Randomizers.Names;


namespace FakePerson.Lib.Factories.NameFactories;

public class RandomSimpleNameFactory : IFactory<SimpleName>
{
    private readonly IRandom<SimpleName> _random = new SimpleNameRandom();
    public SimpleName Create()
    {
        return _random.Get();
    }
}