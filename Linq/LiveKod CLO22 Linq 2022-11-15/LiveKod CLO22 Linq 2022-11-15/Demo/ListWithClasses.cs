// -----------------------------------------------------------------------------------------------
//  ListWithClasses.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveKod_CLO22_Linq_20221115.Interfaces;

public class ListWithClasses : IDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string BestMovie { get; set; }
    }
    public void Start()
    {
        List<Person> actors = new()
           {
               new Person { Name = "Bruce Willis", Age = 65, BestMovie = "Die Hard" },
               new Person { Name = "Arnold Schwarzenegger", Age = 73, BestMovie = "Terminator" },
               new Person { Name = "Sylvester Stallone", Age = 74, BestMovie = "Rocky" },
               new Person { Name = "Chuck Norris", Age = 81, BestMovie = "Walker Texas Ranger" },
               new Person { Name = "Jean-Claude Van Damme", Age = 60, BestMovie = "Bloodsport" },
               new Person { Name = "Steven Seagal", Age = 68, BestMovie = "Under Siege" },
               new Person { Name = "Jet Li", Age = 57, BestMovie = "Brotherhood of the wolf" },
               new Person { Name = "Jason Statham", Age = 52, BestMovie = "The Transporter" },
               new Person { Name = "Dolph Lundgren", Age = 63, BestMovie = "Rocky IV" },
               new Person { Name = "Will Ferrell", Age = 58, BestMovie = null },
               new Person { Name = "Lance Henriksen", Age = 80, BestMovie = "Aliens" },
           };

        actors.RemoveAll(actors => actors.BestMovie == null);

        actors
            .Where(n => n.Name.StartsWith("J"))
            .OrderByDescending(n => n.Age)
            .ThenBy(n => n.Name)
            .ToList()
            .ForEach(n => Console.WriteLine(n.Name + " (" + n.Age + ") - " + n.BestMovie));
    }
}
