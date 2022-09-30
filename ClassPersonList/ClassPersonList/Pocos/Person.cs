namespace ClassPersonList.Pocos;

public class Person
{
    private string firstName;

    public string FirstName
    {
        get
        {
            return firstName;
        }

        set
        {
            firstName = value;
        }
    }
    public string LastName { get; set; }
    public void PrintName()
    {
        Console.WriteLine(FirstName);
    }
}
