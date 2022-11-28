// -----------------------------------------------------------------------------------------------
//  DemoClass.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Demo;

using System;
using System.Collections.Generic;

using LiveKod_CLO22_Linq_20221115.Interfaces;
using LiveKod_CLO22_Linq_20221115.Extensions;
using System.Linq;

public class LinqDemo : IDemo
{
    #region Public Methods

    public void Start()
    {
        Console.WriteLine($"Hello from {this.GetType().Name}");

        // Linq = Language Integrated Query
        // Det betyder att vi kan skriva frågor i SQL-liknande former till våra listor.

        // Vi skapar en lista med namn
        List<string> namn = new List<string>();
        // The expendables
        namn.Add("Bruce Willis");
        namn.Add("Arnold Schwarzenegger");
        namn.Add("Sylvester Stallone");
        namn.Add("Chuck Norris");
        namn.Add("Jean-Claude Van Damme");
        namn.Add("Steven Seagal");
        namn.Add("Jet Li");
        namn.Add("Jason Statham");
        namn.Add("Dolph Lundgren");
        namn.Add("Will Ferrell");

        // LOL, Will Ferrel suger!
        namn.Remove("Will Ferrell");

        //// Vi vill ha alla namn som börjar på J
        //// Vi skapar en ny lista
        //List<string> jNamn = new List<string>();
        //// Vi loopar igenom alla namn i listan
        //foreach(var item in namn)
        //{
        //    // Om namnet börjar på J
        //    if(item.StartsWith("J"))
        //    {
        //        // Lägg till namnet i listan
        //        jNamn.Add(item);
        //    }
        //}

        // Bättre alternativ
        // SELECT * FROM namn WHERE namn LIKE 'J%'
        var jNamn2 = namn                       // Vi tar listan med namn
            .Where(n => n.StartsWith("J"))      // Skapar en ny lista
            .ToList();                          // Använder bara den nya listan

        // Samma sak men klumpigare
        //var jnamn3 = namn.Where(n => n.StartsWith("J"));
        //var newList = jnamn3.ToList();
        //newList.ForEach(n => Console.WriteLine(n));








    }

    #endregion Public Methods
}