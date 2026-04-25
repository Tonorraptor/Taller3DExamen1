namespace Taller3DExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Execute();
        }
        private static void Execute()
        {
            string optionMain = "";
            while (optionMain != "2")
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
            Console.WriteLine("Eres un pequeño diplodocus que por distraido se pierde de la manada y tiene que buscarlo.");
            Console.WriteLine("Escribe el nombre de tu personaje:");
            string name = Console.ReadLine();

            Player player = new Player(name);

            Scenas scena = new Scena1();
            scena.ScenasPlayer(player);
            Console.WriteLine("VIDA TOTAL: " + player.GetLife());
            Console.WriteLine("Presione 1 Volver ha intentar");
            Console.WriteLine("Presione 2 para salir");
            FinalizedGame();
        }
        private static void FinalizedGame()
        {
            string exit = Console.ReadLine();
            switch (exit)
            {
                case "1":
                    Console.Clear();
                    Play();
                    break;
                case "2":
                    Console.Clear();
                    Execute();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    FinalizedGame();
                    break;
            }
        }
    }
}