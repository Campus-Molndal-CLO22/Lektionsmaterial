int value = 4;
IncreaseValue(ref value);
Console.WriteLine(value);

string text = "Hello"; 
ChangeText(ref text);
Console.WriteLine(text);

List<string> texts = new();
texts.Add("Katt");
AddDog(texts);

foreach(string animal in texts)
    Console.WriteLine(animal);

void AddDog(List<string> texts)
{
    texts.Add("Dog");
}

void IncreaseValue(ref int value) // ny variabel skapas, den dör med metoden
{
    value++;
}

void ChangeText(ref string text) // ref håller den levande
{
    text += "World";
}

// -------------------------------------------------------------------
// Skapa en lista med personer
List<Person> people = new()
{
    new Person{Name="Johan", Age=34},
    new Person{Name="Peter", Age=26},
};

// Kopiera listan med metoden CopyList
List<Person> copy = CopyList(people);
// Lägg till en person i kopian
copy.Add(new Person { Name = "Lena", Age = 29 });

copy[0].Name = "Jack Nicholson";
copy[1].Age = 75; // vild chansning

// skriv ut listorna
Console.WriteLine("Lista 1");
foreach(Person person in people)
    Console.WriteLine(person);

Console.WriteLine("Lista 2");
foreach(Person person in copy)
    Console.WriteLine(person)
        ;

List<Person> CopyList(List<Person> people)
{
    List<Person> newList=new List<Person>();
    foreach (Person person in people)
    {
        newList.Add(new Person() { Name = person.Name, Age = person.Age });
    }
    return newList;
}

// -------------------------------------------------------------------

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString() => $"{Name}, {Age}";
}