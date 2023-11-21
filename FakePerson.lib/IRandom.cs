namespace FakePerson.lib;

public interface IRandom<out T>
{
    public T Get();
}