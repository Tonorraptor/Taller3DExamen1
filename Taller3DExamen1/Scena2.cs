using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3DExamen1
{
    internal class Scena2 : Scenas
    {
        public Scena2(string description) : base("")
        {
        }

        public override void ScenasPlayer(Player player)
        {
            description = "EL RIO";
            Console.WriteLine(description);
            string options = "";
            Console.WriteLine("1. Sigue toda la rivera del rio hacia el norte");
            Console.WriteLine("2. Sigue toda la rivera del rio hacia el sur");
            Console.WriteLine("3. Cruza el rio");
            options = Console.ReadLine();
            if (options == "1")
            {
                Console.WriteLine("Llegas a la falda de un volcan");
                Console.WriteLine("Vez la lava correr");
                Console.WriteLine("1. Mejor me salgo de aqui");
                Console.WriteLine("2. Saltas las rocas volcanicas");
                string option2 = Console.ReadLine();

                if (option2 == "2")
                {
                    Console.WriteLine("Te caes");
                    Console.WriteLine("Te quemas");
                    Console.WriteLine("Mueres calcinado");
                    player.GetDamage(-100);
                    Console.WriteLine("Vida actual: " + player.GetLife());
                }
                else if (option2 == "1")
                {
                    Console.WriteLine("Escapas al sur");
                    Console.WriteLine("Te vuelve a encontrar a los mosquitos");
                    player.GetDamage(-10);
                    Console.WriteLine("Llegas a las cascadas");
                    Console.WriteLine("Vida actual: " + player.GetLife());
                }
            }
            else if (options == "2")
            {
                Console.WriteLine("Llegaste a las cascadas");
                Console.WriteLine("Vez a tu manada a lo lejos");
                Console.WriteLine("Peeeeero");
                Console.WriteLine("El allosaurio te ve");
                Console.WriteLine("Solo tienes dos opciones");
                Console.WriteLine("1. Bajas a la cascada");
                Console.WriteLine("2. Peleas con el");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Saltas los desfiladeros");
                    Console.WriteLine("La lluvia te atrapa");
                    Console.WriteLine("Pero vez com el allosaurio ruge porque no puede atraparte");
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("El allosaurio te pisa el cuerpo");
                    Console.WriteLine("Te come");
                    player.GetDamage(-100);
                    Console.WriteLine("Vida actual: " + player.GetLife());
                    Console.WriteLine("Perdiste.................");
                }

            }
            else if (options == "3")
            {
                Console.WriteLine("Cruzas el rio");
                Console.WriteLine("Un mosasaurus te ve desde lo profundo del rio");
                Console.WriteLine("Sientes que algo te jala las patas");
                Console.WriteLine("1. Lucho y mejor no cruzo");
                Console.WriteLine("2. Lucho y cruzo");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Agarras fuerza y te regresas");
                    Console.WriteLine("Vez al allosaurio en la orilla");
                    Console.WriteLine("Ambos te quieren comer");
                    Console.WriteLine("Se pelean");
                    Console.WriteLine("El musasaurus lo arrastra al mar");
                    Console.WriteLine("Estas herido");
                    player.GetDamage(-50);
                    Console.WriteLine("Llegas al acantilado");
                    Console.WriteLine("Vida actual: " + player.GetLife());
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("Logras escapar de su mandibula");
                    Console.WriteLine("Intentas cruzar el rio");
                    Console.WriteLine("Como estas herido");
                    Console.WriteLine("El mosasaurus te arrastra al fondo");
                    player.GetDamage(-100);
                    Console.WriteLine("Vida actual: " + player.GetLife());
                    Console.WriteLine("Perdiste.................");
                }

            }
            else Console.WriteLine("Opcion no valida");
        }
    }
}
