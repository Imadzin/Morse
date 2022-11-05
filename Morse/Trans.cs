using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diacritics.Extensions;


namespace Morse
{
    internal class Trans
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Zadej text či kód pro překlad.");
            string vstup = Console.ReadLine().ToLower().RemoveDiacritics();
            Sort(vstup);
        }



        public static void Sort(String txt)
        {
            if (txt == "")
            {
                Start();
            }
              

            char prvniPismeno = txt[0];
          


            if (prvniPismeno == '.' || prvniPismeno == '-')
            {
                ZMorse(txt);
            }
            else
                DoMorse(txt);


        }


        public static void ZMorse(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                
            }



        }

        public static void DoMorse(string txt)
        {
            Console.WriteLine();



            for(int i = 0; i < txt.Length; i++)
            {
                int index = -1;

                string fragment = txt[i].ToString();

                do
                {
                    index++;
                }while(fragment != Dic.N_abeceda[index]);

                Console.Write(Dic.M_abeceda[index]);
                Console.Write("/");

            }

            Console.WriteLine("//");
            Console.ReadKey();
            Start();

        }

        

    }
}
