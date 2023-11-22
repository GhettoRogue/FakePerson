using FakePerson.lib.Factories;
using FakePerson.lib.Factories.NameFactories;


var nameFactory = new RandomAbstractNameFactory(new RandomRussianNameFactory());
var personBuilder = new PersonBuilder(nameFactory.Create());
var random = new Random();

var person = personBuilder.
