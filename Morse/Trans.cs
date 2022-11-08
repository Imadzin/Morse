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

            if (txt == Config.prikazZpet)
            {
                Program.Menu();
            }


            if (prvniPismeno == '.' || prvniPismeno == '-')
            {
                ZMorse(txt);
            }
            else
                DoMorse(txt);


        }


        public static void ZMorse(string txt)
        {
            string[] letters = txt.Split('/');

            string output = "";

            for (var i = 0; i < letters.Length; i++)
            {
                int index = Array.IndexOf(Dic.M_abeceda, letters[i]);

                if (index == -1) continue;

                output += Dic.N_abeceda[index];
            }

            Console.WriteLine(output.Trim());
            Console.ReadKey();
            Start();

        }

        public static void DoMorse(string txt)
        {
            string output = "";

            for (int i = 0; i < txt.Length; i++)
            {
                string fragment = txt[i].ToString();

                int index = Array.IndexOf(Dic.N_abeceda, fragment);

                if (txt.Length - i > 1) {
                    string lookahead = txt[i + 1].ToString();

                    if (Dic.N_abeceda.Contains(fragment + lookahead))
                    {
                        index = Array.IndexOf(Dic.N_abeceda, fragment + lookahead);
                        i++;
                    }
                }

                output += Dic.M_abeceda[index] + "/";
            }

            Console.WriteLine(output + "//");
            Beeper.Pipani(output);

            Console.ReadKey();
            Start();

        }
    }
}
