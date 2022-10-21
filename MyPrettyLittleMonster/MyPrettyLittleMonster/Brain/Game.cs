namespace MyPrettyLittleMonster.Brain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game
{
    internal void Start()
    {
        DoIntro();
    }

    private void DoIntro()
    {
        var view = new Views.Intro();
        view.Show();
    }
}
