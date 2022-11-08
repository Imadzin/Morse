namespace Morse
{
    internal class Config
    {
        public static bool pipani;
        public static int delkaPipnutiTecka; //ms
        public static int delkaPipnutiCarka; //ms
        public static int delkaLomeno;
        public static int delkaMezera;
        public static int frekvencePipani;

        public static string prikazZpet = "\\back";

        public static void DefaultConfig()
        {
            ConfigWrite("true".ToString(), false);
            ConfigWrite(200.ToString(), true); //delka pipnuti tecky
            ConfigWrite(350.ToString(), true); //delka pipnuti carky
            ConfigWrite(400.ToString(), true); // delka lomeno
            ConfigWrite(600.ToString(), true); //delka mezery
            ConfigWrite(650.ToString(), true); //frekvence

            // ConfigWrite(.ToString(), true);

            ConfigLoad();
        }

        public static void ConfigLoad()
        {
            pipani = Convert.ToBoolean(ConfigRead(0));
            delkaPipnutiTecka = Convert.ToInt32(ConfigRead(1));
            delkaPipnutiCarka = Convert.ToInt32(ConfigRead(2));
            delkaLomeno = Convert.ToInt32(ConfigRead(3));
            delkaMezera = Convert.ToInt32(ConfigRead(4));
            frekvencePipani = Convert.ToInt32(ConfigRead(5));

        }


        public static void ConfigTest()
        {
            if (!File.Exists("Config.txt"))
            {
                DefaultConfig();
            }
        }


        public static void ConfigWrite(string txt, bool append)
        {
            using (StreamWriter sw = new StreamWriter("Config.txt", append))
            {
                sw.WriteLine(txt);
                sw.Flush();
            }
        }

        public static string ConfigRead(int line)
        {
            return File.ReadAllLines("Config.txt").Skip(line).Take(1).First();
        }




    }
}
