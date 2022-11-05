using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Morse
{
    internal class Beeper
    {
        public static void Pipani(string kod)
        {
            int index = 0;


            do
            {

                if (kod[index] == '-')
                {
                    Console.Beep(Config.frekvencePipani, Config.delkaPipnutiCarka);
                }
                else if (kod[index] == '.')
                {
                    Console.Beep(Config.frekvencePipani, Config.delkaPipnutiTecka);
                }
                else
                {
                    if (index+1 != kod.Length)
                    {
                        if (kod[index + 1] == '/')
                        {
                            Thread.Sleep(Config.delkaMezera);
                        }
                        else
                        {
                            Thread.Sleep(Config.delkaLomeno);
                        }
                    }
                    else
                    {
                        Thread.Sleep(Config.delkaLomeno);
                    }


                }




                    index++;
                

            }while (index !=kod.Length);
        }






    }
}
