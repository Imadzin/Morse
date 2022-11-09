namespace Morse
{
    internal class ConfigByUser
    {

        public static void Start()
        {
            Config.ConfigLoad();
            Console.Clear();
            Console.WriteLine("Nastavení:");
            Console.WriteLine();
            Console.WriteLine("Pípání - " + Config.pipani + " [1]");
            Console.WriteLine("Délka pípnutí tečky: " + Config.delkaPipnutiTecka + "ms [2]");
            Console.WriteLine("Délka pípnutí čárky: " + Config.delkaPipnutiCarka + "ms [3]");
            Console.WriteLine("Délka odmlčení po znaku: " + Config.delkaLomeno + "ms [4]");
            Console.WriteLine("Délka odmlčení po mezeře: " + Config.delkaMezera + "ms [5]");
            Console.WriteLine("Frekvence pípání: " + Config.frekvencePipani + "hz [6]");
            Console.WriteLine();
            Console.WriteLine("Reset [9]");
            Console.WriteLine("Zpět [0]");

            string volba = Console.ReadLine();
            int volbaInt;
            string vstup;
            int intVstup;

            if (int.TryParse(volba,out volbaInt))
            {
                volbaInt=Convert.ToInt32(volba);
            }else
            {
                Start();
            }

            switch (volbaInt)
            {

                default:
                    Start();
                    break;

                case 0:
                    Program.Menu();
                    break;

                case 1:
                    ConfigByUserWrite(0,Convert.ToString( Config.pipani = !(Config.pipani)));
                    Start();
                    break;

                case 2:
                    Console.Clear();
                    BT("Zadej hodnotu délky pípnutí tečky \".\":", ConsoleColor.DarkRed);

                    vstup = Console.ReadLine();

                    if (int.TryParse(vstup, out intVstup))
                    {
                        ConfigByUserWrite(1, Math.Abs(intVstup).ToString());
                    }
                    Start();
                    break;

                case 3:
                    Console.Clear();
                    BT("Zadej hodnotu délky pípnutí čárky \"-\": ", ConsoleColor.DarkRed);

                    vstup = Console.ReadLine();

                    if (int.TryParse(vstup, out intVstup))
                    {
                        ConfigByUserWrite(2, Math.Abs(intVstup).ToString());
                    }
                    Start();
                    break;

                case 4:
                    Console.Clear();
                    BT("Zadej hodnotu odmlčení mezi znaky v ms:", ConsoleColor.DarkRed);

                    vstup = Console.ReadLine();

                    if (int.TryParse(vstup, out intVstup))
                    {
                        ConfigByUserWrite(3, Math.Abs(intVstup).ToString());
                    }
                    Start();
                    break;

                case 5:
                    Console.Clear();
                    BT("Zadej hodnotu délky mezery v ms:", ConsoleColor.DarkRed);

                    vstup = Console.ReadLine();

                    if (int.TryParse(vstup, out intVstup))
                    {
                        ConfigByUserWrite(4, Math.Abs(intVstup).ToString());
                    }
                    Start();
                    break;

                case 6:
                    Console.Clear();
                    BT("Zadej hodnotu pro frekvenciv hz (37-1258):", ConsoleColor.DarkRed);

                    vstup = Console.ReadLine();

                    if (int.TryParse(vstup, out intVstup))
                    {
                        int tmp = Math.Clamp(Math.Abs(intVstup), 37, 1258);
                       
                        ConfigByUserWrite(5, tmp.ToString());
                    }
                    Start();
                    break;

                case 9:
                    Console.Clear();
                    Config.DefaultConfig();
                    Start();
                    break;




            }


        }


        public static void ConfigByUserWrite(int line, string txt)
        {
            string[] countOfLines = File.ReadAllLines("Config.txt");

            using (StreamWriter SW = new StreamWriter("Config.txt"))
            {

               for (int currentLine = 0; currentLine <= countOfLines.Length-1; currentLine++)
                {


                    if (currentLine == line)
                    {
                        SW.WriteLine(txt);
                   }
                    else
                    {
                        SW.WriteLine(countOfLines[currentLine]);
                    }


                }

                SW.Flush();

            }
        }

        public static void BT(string txt, ConsoleColor barva)
        {
            Console.ForegroundColor = barva;
            Console.WriteLine(txt);
            Console.ForegroundColor=ConsoleColor.White;

        }


    }
}
