namespace Models;

using System.ComponentModel.DataAnnotations;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public List<Pet> Pets { get; set; } // En person kan ha flera husdjur
}

public class Pet
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public List<Person> Owners { get; set; } // Ett husdjur kan ha flera ägare
}