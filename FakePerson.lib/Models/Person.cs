﻿namespace FakePerson.lib.Models;

public class Person
{
    public required AbstractName Name  { get; init; }

    public required AbstractPhone Phone { get; set; }
    
    
}