using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3DExamen1
{
    internal class Player
    {
        private string Name;
        private int Life;
        private int Damage;

        public Player(string name)
        {
            Name = name;
            Life = 100;
            Damage = 10;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetLife()
        {
            return Life;
        }

        public int GetDamage()
        {
            return Damage;
        }
    }
}
