// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

IPrintNameable cat = new Cat();
((Cat)cat).Name = "Mr Mjau";
cat.PrintName();

IPrintNameable person = new Person();
((Person)person).FirstName = "James";
((Person)person).LastName = "Suntherland";
person.PrintName();

Cat cat2 = new Cat();
cat2.Name = "Misse";
Person person2 = new Person();
person2.FirstName = "Heather";
person2.LastName = "Mason";
Print(cat2);
Print(person2);

void Print(IPrintNameable item)
{
    item.PrintName();
}

// Interface är ett kontrakt som innebär att alla klasser
// som implementerar det måste uppfylla kraven för Interfacet
// Allt i ett interface är publikt, inget är statiskt,
// ingen kod i metoderna.
// I -net ska alla namn på Interface börja med I och sluta med -able
// ILoopable, ICountable osv.

interface IPrintNameable
{
    void PrintName();
}

class Cat : IPrintNameable
{
    public string Name { get; set; }
    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}

class Person:IPrintNameable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

