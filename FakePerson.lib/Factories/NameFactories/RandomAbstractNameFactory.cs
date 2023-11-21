using FakePerson.lib.Models;

namespace FakePerson.lib.Factories.NameFactories;

public class RandomAbstractNameFactory : IFactory<AbstractName>
{
    private readonly IFactory<AbstractName> _factory;

    public RandomAbstractNameFactory(IFactory<AbstractName> factory)
    {
        _factory = factory;
    }

    public AbstractName Create()
    {
        return _factory.Create();
    }
}