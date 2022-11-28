// -----------------------------------------------------------------------------------------------
//  ListExtensions.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ListExtensions
{
    public static void PrintList(this List<string> strings)
    {
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
    }
}
