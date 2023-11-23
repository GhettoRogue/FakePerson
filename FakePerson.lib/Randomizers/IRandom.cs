namespace FakePerson.lib.Randomizers;

public interface IRandom<out T>
{
    public T Get();
}