namespace Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Morseovka v1.0.0";
                Config.ConfigTest();
                Config.ConfigLoad();
                Menu();
            }
        }


        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("Překlad      [1]");
            Console.WriteLine("Procvičování [2]");
            Console.WriteLine("Nastavení    [3]");
            Výběr();
        }


        public static void Výběr()
        {

            string text = Convert.ToString(Console.ReadKey().KeyChar);
            int ciselnyVyber;

            if (int.TryParse(text, out ciselnyVyber))
            {
                ciselnyVyber = Convert.ToInt32(text);
            }
            else
                Menu();



            switch (ciselnyVyber)
            {
                default:
                    Menu();
                    break;

                case 1:
                    Trans.Start();
                    break;

                case 2:
                    Prac.Start();
                    break;

                case 3:
                    ConfigByUser.Start();
                    break;





            }




        }



    }
}