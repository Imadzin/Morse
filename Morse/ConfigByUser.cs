using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Délka pípnutí tečky: "+Config.delkaPipnutiTecka+"ms [2]");
            Console.WriteLine("Délka pípnutí čárky: "+Config.delkaPipnutiCarka+"ms [3]");
            Console.WriteLine("Délka odmlčení po znaku: "+Config.delkaLomeno+"ms [4]");
            Console.WriteLine("Délka odmlčení po mezeře: " + Config.delkaMezera+"ms [5]");
            Console.WriteLine("Frekvence pípání: " + Config.frekvencePipani + "hz [6]");
           string volba = Console.ReadLine();
            int volbaInt;

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

                case 1:
                    ConfigByUserWrite(0,Convert.ToString( Config.pipani = !(Config.pipani)));
                    Start();
                    break;

                case 2:
                    BT("Zadej hodnotu:", ConsoleColor.DarkRed);
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
                   }else
                   {
                        SW.WriteLine(countOfLines[currentLine]);
                   }
                   
                    
                }

                SW.Flush();

            }
        }

        public static void BT(string txt, ConsoleColor barva)
        {

        }


    }
}
