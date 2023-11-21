using FakePerson.lib.Models;

namespace FakePerson.lib.Factories;

public class RandomPersonFactory : IFactory <Person>
{
    public Person Create()
    {
        throw new NotImplementedException();
    }
}