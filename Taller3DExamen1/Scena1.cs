using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Taller3DExamen1
{
    internal class Scena1 : Scenas
    {
        public Scena1(string description) : base("")
        {
        }

        public override void ScenasPlayer(Player player)
        {
            description = "EL BOSQUE";
            string options = "";
            Console.WriteLine("1. Explorar el bosque");
            Console.WriteLine("2. Quedarte ahi");
            options = Console.ReadLine();
            if (options == "1")
            {
                Console.WriteLine("Encuentras un rio");
                Console.WriteLine("Hay mosquitos");
                Console.WriteLine("1. Embarrate en el lodo");
                Console.WriteLine("2. Pelearte con los mosquitos");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Te embarraste en el lodo y los mosquitos no te pican");
                    Console.WriteLine("Puedes seguir tu casmino");
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("Te estan atacando, pierdes 10 de vida");
                    player.GetLife(-10);
                    Console.WriteLine("Huyes del lugar");
                }
            }
            else if (options == "2")
            {
                Console.WriteLine("Anochece");
                Console.WriteLine("Lloras en el bosque");
                Console.WriteLine("Escuchaste un rujido");
                Console.WriteLine("El allosaurio te ve");
                Console.WriteLine("1. Huyes del lugar");
                Console.WriteLine("2. Sigues llorando");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Te pusiste valiente y te alejaste de ahi");
                    Console.WriteLine("Llegaste al rio");
                    Console.WriteLine("Los mosquitos te picaron");
                    player.GetLife(-10);
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("El allosaurio te pisa el cuerpo");
                    Console.WriteLine("Te come");
                    player.GetLife(-100);
                    Console.WriteLine("Perdiste.................");
                }

            }
            else Console.WriteLine("Opcion no valida");
        }
    }
}
