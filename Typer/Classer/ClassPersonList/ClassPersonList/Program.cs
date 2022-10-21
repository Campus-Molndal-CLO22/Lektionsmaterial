using ClassPersonList.Pocos;

Person person = new Person();
person.FirstName = "Clark";
person.LastName = "Kent";
person.PrintName();

Max100 max = new();
max.Value = -10;
Console.WriteLine(max.Value);

max.Value = 300;
Console.WriteLine(max.Value);
Console.WriteLine(max);
