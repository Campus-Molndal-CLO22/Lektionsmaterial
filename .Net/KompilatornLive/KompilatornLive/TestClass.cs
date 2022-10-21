internal class TestClass
{
    public TestClass()
    {
        // TODO: Skapa en bättre constructor
    }

    internal void Run()
    {
        DisplayMessage("Hello my dear user!");
    }

    private void DisplayMessage(string message)
    {
        DisplayOneWordAtATime(message);
    }

    private void DisplayOneWordAtATime(string message)
    {
        var words = message.Split(' ');
        foreach (var word in words)
            Console.WriteLine(word);

    }
}