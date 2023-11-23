using System.Text.Encodings.Web;
using System.Text.Json;
using FakePerson.lib.Factories;
using FakePerson.lib.Factories.NameFactories;
using FakePerson.lib.Randomizers;


var nameFactory = new RandomAbstractNameFactory(new RandomRussianNameFactory());
var personBuilder = new PersonBuilder(nameFactory.Create());
var random = new Random();

var person = personBuilder
    .SetAge(random.NextAge())
    .SetEmail("person@email.mail")
    .Build();

var jsonOptions = new JsonSerializerOptions()
{
    IncludeFields = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};
var json = JsonSerializer.Serialize(person, jsonOptions);
Console.WriteLine(json);

Console.WriteLine(person);
