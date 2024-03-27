using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev16

    {
        public void calistir16()

        {

            {


                Console.Write("Bir pozitif tamsayı girin: ");
                int x= Convert.ToInt32(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir tamsayı girin.");
                }
                else
                {
                    int basamakSayisi = 0;
                    int tempSayi = x;

                    while (tempSayi > 0)
                    {
                        basamakSayisi++;
                        tempSayi /= 10;
                    }

                    Console.WriteLine($"Girdiğiniz sayının basamak sayısı: {basamakSayisi}");
                }
            }
        }
    }






}
       
