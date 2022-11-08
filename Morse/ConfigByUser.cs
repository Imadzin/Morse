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
            Console.WriteLine("Pípání - " + Config.pipani + "[1]");
            Console.WriteLine("Délka pípnutí tečky: "+Config.delkaPipnutiTecka+"ms [2]");
            Console.WriteLine("Délka pípnutí čárky: "+Config.delkaPipnutiCarka+"ms [3]");
            Console.WriteLine("Délka odmlčení po znaku: "+Config.delkaLomeno+"ms [4]");
            Console.WriteLine("Délka odm");

        }


    }
}
