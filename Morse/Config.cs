using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    internal class Config
    { 
        public static bool pipani;
        public static int delkaPipnutiTecka; //ms
        public static int delkaPipnutiCarka; //ms
        


        public static void DefaultConfig() 
       {
            ConfigWrite("true".ToString(),false);
            ConfigWrite(200.ToString(),true);
            ConfigWrite(400.ToString(),true);


            ConfigLoad();
       }

       public static void ConfigLoad()
        {
            pipani =Convert.ToBoolean( ConfigRead(0));
            delkaPipnutiTecka=Convert.ToInt32( ConfigRead(1));
            delkaPipnutiCarka=Convert.ToInt32( ConfigRead(2));


        }


        public static void ConfigTest()
        {
            if (!File.Exists("Config.txt"))
            {
                DefaultConfig();
            }
        }


        public static void ConfigWrite(string txt,bool append)
        {
            using (StreamWriter sw = new StreamWriter("Config.txt", append))
            {
                sw.WriteLine(txt);
                sw.Flush();
            }
        }

        public static string ConfigRead(int line)
        {
          return  File.ReadAllLines("Config.txt").Skip(line).Take(1).First();
        }




    }
}
