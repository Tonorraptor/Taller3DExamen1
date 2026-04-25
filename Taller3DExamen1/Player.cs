using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3DExamen1
{
    internal class Player
    {
        private string Name;
        private int Life;

        public Player(string name)
        {
            Name = name;
            Life = 100;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetLife()
        {
            return Life;
        }

        public int GetDamage(int life)
        {
            return Life+=life;
        }
    }
}
