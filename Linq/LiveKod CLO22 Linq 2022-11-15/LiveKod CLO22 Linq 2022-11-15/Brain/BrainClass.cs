// -----------------------------------------------------------------------------------------------
//  BrainClass.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Brain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using LiveKod_CLO22_Linq_20221115.Interfaces;

public static class BrainClass
{
    #region Public Methods

    public static void ShowMenu()
    {
        // Inspired from https://stackoverflow.com/a/699871
        var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetInterfaces().Contains(typeof(IDemo))
                                 && t.GetConstructor(Type.EmptyTypes) != null
                        select Activator.CreateInstance(t) as IDemo;

        List<IDemo> list = instances.ToList();
        var amount = list.Count;
        Console.WriteLine("Select demo to run");
        Console.WriteLine();
        for (int inst = 0; inst < amount; inst++)
        {
            IDemo instance = list[inst];
            Console.WriteLine($"{inst + 1:  0} - {PascalCaseToSentence(instance.GetClassName)}");
        }
        Console.WriteLine();
        int choice = 0;
        int top = Console.GetCursorPosition().Top;
        if (top > 22)
            top = 22;

        while (choice < 1 || choice > amount)
        {
            Console.SetCursorPosition(0, top);
            Console.Write(">" + new string(' ', Console.WindowWidth - 2));
            Console.SetCursorPosition(2, top);
            var input = Console.ReadLine() ?? "";
            _ = int.TryParse(input, out choice);
            Console.CursorTop--;
        }
        Console.Clear();
        list[choice - 1].Start();
    }

    #endregion Public Methods

    #region Private Methods

    private static string PascalCaseToSentence(string str)
    {
        // Borrowed from https://stackoverflow.com/a/64167929
        if (string.IsNullOrEmpty(str?.Trim()))
            return "";
        else if (str.Length == 1)
            return str.ToUpper();
        else
            return string.Concat(str.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
    }

    #endregion Private Methods
}