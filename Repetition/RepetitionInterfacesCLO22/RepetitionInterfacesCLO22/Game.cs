namespace RepetitionInterfacesCLO22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RepetitionInterfacesCLO22.Interfaces;

    internal class Game
    {

    }

    internal class Monster : IVillian
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
