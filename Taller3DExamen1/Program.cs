namespace Taller3DExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string optionMain="";
            while (optionMain != "0")
            {
                Console.WriteLine("BUSCANDO TU MANADA");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                optionMain = Console.ReadLine();   
                switch (optionMain)
                {
                    case "1":
                        Play();
                        break;
                    case "2":
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }
        private static void Play()
        {
            Console.Clear();
            Console.WriteLine("Escribe el nombre de tu personaje:");
            string name = Console.ReadLine();

            Player player = new Player(name);

            Console.WriteLine("Nombre: " + player.GetName());
            Console.WriteLine("Vida: " + player.GetLife());
            Console.WriteLine("Daño: " + player.GetDamage());
        }
    }
}