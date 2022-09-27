Dictionary<int, string> lista = new();
lista.Add(1000, "Tusen");
lista.Add(100, "Hundra");

if (lista.ContainsKey(1000))
    Console.WriteLine(lista[1000]);

Dictionary<string, string> Stränglista = new();
Stränglista.Add("Tusen", "Tusen och en natt");

if (Stränglista.ContainsKey("Tusen"))
    Console.WriteLine(Stränglista["Tusen"]);

foreach (var rad in lista)
{
    Console.WriteLine(rad.Key + " = " + rad.Value);
}


List<string> ord = new();
