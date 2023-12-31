﻿using FakePerson.lib.Factories;
using FakePerson.lib.Factories.NameFactories;
using FakePerson.Lib.Factories.NameFactories;
using FakePerson.lib.Models;
using FakePerson.lib.Models.Names;

namespace FakePerson.lib.Randomizers;

public class RandomPerson : IRandom<Person>
{
    private PersonBuilder _personBuilder;

    public void AddName(Type type)
    {
        RandomAbstractNameFactory nameFactory = null;
        if (type is RussianName)
        {
            nameFactory = new RandomAbstractNameFactory(new RandomRussianNameFactory());
        }
        else if (type is SimpleName)
        {
            nameFactory = new RandomAbstractNameFactory(new RandomSimpleNameFactory());
        }
        else
        {
            return; // !!! Выбросить ошибку !!!
        }

        _personBuilder = new PersonBuilder(nameFactory.Create());
    }
    
    public void AddAge()
    {
        var random = new Random();
        var age = random.NextAge();
        _personBuilder.SetAge(age);
    }
    
    public void AddEmail()
    {
        // TODO Добавить метод по генерации случайного e-mail
    }
    
    public void AddAddress()
    {
        // TODO Добавить метод по генерации случайного адреса
    }
    
    public Person Get()
    {
        return _personBuilder.Build();
    }
}