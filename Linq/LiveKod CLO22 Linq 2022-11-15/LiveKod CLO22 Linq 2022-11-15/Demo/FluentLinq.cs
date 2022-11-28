// -----------------------------------------------------------------------------------------------
//  FluentLinq.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveKod_CLO22_Linq_20221115.Interfaces;

internal class FluentLinq : IDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public void Start()
    {
        var people = new List<Person>()
        {
            new Person{ Name = "Marcus", Age = 52 },
            new Person{ Name = "Eva", Age = 50 },
            new Person{ Name = "Erik", Age = 25 },
        };

        // SELECT * FROM people WHERE Age > 30 Order by Name
        var result = (
            from person in people 
            where person.Age > 30 
            orderby person.Name
            select person
            ).ToList();
        
        // Samma sak
        //var result2 = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        
        foreach (var person in result)
        {
            Console.WriteLine(person.Name + " " + person.Age);
        }
    }
}
