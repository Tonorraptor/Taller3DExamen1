using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3DExamen1
{
    internal abstract class Scenas
    {
        protected string description { get; set; }

        public Scenas(string description)
        {
            this.description = description;
        }
        public abstract void ScenasPlayer(Player player);
    }
}
