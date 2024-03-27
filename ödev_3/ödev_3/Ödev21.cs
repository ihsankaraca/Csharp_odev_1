using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev21

    {
        public void calistir21()

        {

            {
                int kontrol = 0;
                Console.Write("Sayı Girin : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        kontrol++;
                }

                if (kontrol != 0)
                    Console.WriteLine("Girdiğiniz sayı asal değil.");
                else
                    Console.WriteLine("Girdiğiniz sayı asal.");
                Console.ReadKey();
            }
        }
    }
       
    

}  