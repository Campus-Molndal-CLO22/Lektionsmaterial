namespace MyPrettyLittleMonster.Views;

using System;

internal class Intro
{
    public Intro()
    {
    }

    internal void Show()
    {
        ScrollWords("Do you know that feeling when you're looking at a mirror,");
        ScrollWords("and you see a monster staring back at you?");
        ScrollWords("Well, that's what happens to me every day.");
        ScrollWords("I'm a monster, not an evil monster, a kind one.");
        ScrollWords("But I'm still a monster.");
        ScrollWords("I'm a monster that likes to eat candy.");
        ScrollWords("I'm a monster that likes to play games.");
        ScrollWords("I'm a monster that likes to watch TV.");
        ScrollWords("I'm a monster that likes to go to school.");
        ScrollWords("I'm a monster that likes to go to the park.");
        ScrollWords("I'm a monster that likes to go to the beach.");
        ScrollWords("I'm a monster that don't likes to go to the zoo.");
        ScrollWords("all those poor animals... in cages...");
        ScrollWords("I'm a monster that likes to go to the movies.");
        ScrollWords("I'm a monster that likes to go to the circus.");
    }

    public void ScrollWords(string text)
    {
        Random rand = new Random();
        // Split the sentences into text
        var words = text.Split(' ');
        var sentence = "";

        var y = Console.CursorTop;

        // Loop through each word
        foreach (var word in words)
        {
            var end = sentence.Length;
            var start = rand.Next(end + 1, end + 30);
            if (start > Console.WindowWidth) start = Console.WindowWidth - word.Length - 1;
            // Loop through each word
            for (var x = start; x > end; x--)
            {
                Console.SetCursorPosition(x, y);
                // Write the sentence
                Console.Write(word + " ");
                // Wait for a bit
                System.Threading.Thread.Sleep(10);
            }
            sentence += $"{word} ";
            //sentence = string.Concat(word, " "); // <-- snabbt
        }
        Console.WriteLine();
    }
}