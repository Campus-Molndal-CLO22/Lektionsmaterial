//int birthYear = int.Parse(Console.ReadLine());
var date = AskForBirthData();
Console.WriteLine($"Du föddes på en {date.DayOfWeek}");

// ------------------------------------------------------------------------------------
// - Ett par Visual Studio tips:                                                      -
// - Om du skriver namnet på en metod som inte finns, kommer glödlampan till vänster  -
// - att föreslå att den skapar metoden till dig. Du kan även trycka CTRL . för att   -
// - få fram menyn som låter dig flytta kod till en ny metod (Extract method)         -
// -                                                                                  -
// - Lycka till och koda vilt!                                                        - 
// ------------------------------------------------------------------------------------

SayHello(); // Prova att skapa metoden med glödlampan och välj "Create method"


// Skapa en metod för att fråga om en siffra och returnera den
int AskForNumber(string question, int min = 0, int max = 9999999)
{
    int number = 0;
    while (number < min || number > max)
    {
        number = AskStuff(question);
    }

    return number; // returnera värdet

    static int AskStuff(string question)
    {
        int number;
        Console.WriteLine(question); // Skriv ut frågan
        int.TryParse(Console.ReadLine(), out number); // Omvandla text till tal
        return number;
    }
}

DateTime AskForBirthData()
{
    // Sätt året till noll
    int birthYear = AskForNumber("Ange födelseår: ", 1900, 2022);

    int birthMonth = AskForNumber("Ange födelsemånad: ", 1, 12);

    int birthDay = AskForNumber("Ange födelsedag: ", 1, 31);

    DateTime date = new DateTime(birthYear, birthMonth, birthDay);
    return date;
}

// En massa roliga kommentarer
// som bara tar upp plats