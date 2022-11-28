// -----------------------------------------------------------------------------------------------
//  ExtensionsDemo.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Demo;

using System;
using System.Collections.Generic;

using LiveKod_CLO22_Linq_20221115.Extensions;
using LiveKod_CLO22_Linq_20221115.Interfaces;

public class ExtensionsDemo : IDemo
{
    public void Start()
    {
        Console.WriteLine("Hello extensions");
        // Extensions har vissa regler
        // 1. De måste vara static
        // 2. De måste vara i en statisk klass
        // 3. De måste ha this före datatypen de ska användas på
        // 4. De måste ha en parameter som är datatypen de ska användas på (this List<string> strings)

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

        namn.PrintList();
    }
}