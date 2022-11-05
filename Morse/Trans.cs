using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    internal class Trans
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Zadej text či kód pro překlad.");
            string vstup = Console.ReadLine();
            Sort(vstup);
        }



        public static void Sort(String txt)
        {
            char prvniPismeno = txt[0];
            char druhePismeno = txt[1];


            if (prvniPismeno == '.' || prvniPismeno == '-')
            {
                ZMorse(txt);
            }
            else
                DoMorse(txt);


        }


        public static void ZMorse(string txt)
        {

        }

        public static void DoMorse(string txt)
        {

        }



    }
}
