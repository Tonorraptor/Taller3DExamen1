using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3DExamen1
{
    internal class Scena3 : Scenas
    {
        public Scena3(string description) : base("")
        {
        }

        public override void ScenasPlayer(Player player)
        {
            description = "EL ACANTILADO";
            Console.WriteLine(description);
            string options = "";
            Console.WriteLine("La lluvia te atrapo");
            Console.WriteLine("Vez una cueva");
            Console.WriteLine("1. Te refugias");
            Console.WriteLine("2. Te arrieagas");
            options = Console.ReadLine();
            if (options == "1")
            {
                Console.WriteLine("Te ocultaste en la cueva");
                Console.WriteLine("Escuchas gruñidos");
                Console.WriteLine("1. Me lo mecho, ya pase muchas cosas ¿Que podria pasarme?");
                Console.WriteLine("2. Me quedo callado y me camuflo en la oscuridad");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Lo golpeo");
                    Console.WriteLine("Se despierta");
                    Console.WriteLine("Me atrapa");
                    Console.WriteLine("Me come");
                    player.GetDamage(-100);
                    Console.WriteLine("Vida actual: " + player.GetLife());
                    Console.WriteLine("Perdiste.................");
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("Espero que pase la lluvia");
                    Console.WriteLine("La lluvia pasa");
                    Console.WriteLine("La lluvia pasa");
                    Console.WriteLine("Bajo el acantilado");
                    Console.WriteLine("Encuentro a mi manada");
                    Console.WriteLine("FIN..................");
                }
            }
            else if (options == "2")
            {
                Console.WriteLine("Bajo el acantilado en plena lluvia");
                Console.WriteLine("Me resbalo");
                Console.WriteLine("Me caigo en un lugar estrecho");
                Console.WriteLine("Grito y nadie me escucha");
                Console.WriteLine("1. Lucho poe salir");
                Console.WriteLine("2. Me rindo");
                string option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    Console.WriteLine("Me logro liberar");
                    Console.WriteLine("Me quedo cojo");
                    Console.WriteLine("No llego a mi manada");
                    player.GetDamage(-60);
                    if(player.GetLife() <= 0)
                    {
                        Console.WriteLine("Vida actual: " + player.GetLife());
                        Console.WriteLine("PERDISTE.................");
                    }
                    else
                    {
                        Console.WriteLine("Vida actual: " + player.GetLife());
                        Console.WriteLine("Me quedo vagando por ahi");
                    }
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("Me quede sin energia");
                    player.GetDamage(-80);
                    if (player.GetLife() <= 0)
                    {
                        Console.WriteLine("Me desangro y me muero");
                        Console.WriteLine("Vida actual: " + player.GetLife());
                        Console.WriteLine("PERDISTE.................");
                    }
                    else
                    {
                        Console.WriteLine("Espero a que sea comida");
                        Console.WriteLine("Vida actual: " + player.GetLife());
                        Console.WriteLine("FIN..................");

                    }
                }
            }
            else Console.WriteLine("Opcion no valida");
        }
    }
}
