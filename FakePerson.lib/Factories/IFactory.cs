using FakePerson.lib.Factories.NameFactories;

namespace FakePerson.lib.Factories;

public interface IFactory<out T>
{
    public T Create();
}