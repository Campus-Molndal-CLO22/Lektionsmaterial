using MoqDemo.Interface;

namespace MoqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NameList : INameList
{
    List<string> names = new List<string>();

    public void Add(string name)
    {
        names.Add(name);
    }

    public string Find(string text)
    {
        return names.Find(x => x.Contains(text));
    }

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }

    public int Count
    {
        get { return names.Count; }
    }

    public void Clear()
    {
        names.Clear();
    }
}
