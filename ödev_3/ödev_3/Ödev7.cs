using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev7

    {
        public void calistir7()

        {

            {
                
                {
                    int sayi, toplam = 0;
                    while (true)
                    {
                        Console.Write("Sayı Gir : ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi == 0)
                        {
                            break;
                        }
                        toplam += sayi;
                    }
                    Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + toplam);
                    Console.ReadKey();
                }



            }






        }




    }

}
