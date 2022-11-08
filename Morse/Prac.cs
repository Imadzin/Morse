namespace Morse
{
    internal class Prac
    {

        public static void Start()
        {
            Console.Clear();

            var rnd = new Random();

            int nahoda = rnd.Next(0, 2);

            if (nahoda == 1)
            {
                PDoMorse();
            }
            else


            {
                PZMorse();
            }


        }


        public static void PDoMorse()
        {
            var rnd = new Random();

            int index = rnd.Next(0, 43);

            if (Dic.N_abeceda[index] == "")
            {
                PDoMorse();
            }

            Console.WriteLine("Přelož: " + Dic.N_abeceda[index]);
            Console.WriteLine();
            string vstup = Console.ReadLine().ToLower();

            if (vstup == Dic.M_abeceda[index])
            {

                BarText("SPRÁVNĚ", ConsoleColor.Green);
            }
            else
            {
                BarText("ŠPATNĚ", ConsoleColor.Red);
                Console.WriteLine("správná odpověď: " + Dic.M_abeceda[index]);
            }
            Console.ReadKey();
            Start();
        }
        public static void PZMorse()
        {

            var rnd = new Random();

            int index = rnd.Next(0, 43);

            if (Dic.M_abeceda[index] == "")
            {
                PZMorse();
            }

            Console.WriteLine("Přelož: " + Dic.M_abeceda[index]);
            Beeper.Pipani(Dic.M_abeceda[index]);
            Console.WriteLine();
            string vstup = Console.ReadLine();

            if (vstup == Dic.N_abeceda[index])
            {

                BarText("SPRÁVNĚ", ConsoleColor.Green);
            }
            else
            {
                BarText("ŠPATNĚ", ConsoleColor.Red);
                Console.WriteLine("správná odpověď: " + Dic.N_abeceda[index]);
            }
            Console.ReadKey();
            Start();

        }


        public static void BarText(string txt, ConsoleColor barva)
        {
            Console.ForegroundColor = barva;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;


        }

    }
}
