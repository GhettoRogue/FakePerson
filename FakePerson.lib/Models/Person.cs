namespace FakePerson.lib.Models;

public class Person
{
    public required AbstractName Name  { get; init; }

    public AbstractPhone? Phone { get; set; }
    
    public int? Age { get; set; }
    
    public string? Email { get; set; }
    
    public string? Address { get; set; }
    
}