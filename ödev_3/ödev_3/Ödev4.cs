using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_23
{
    internal class Ödev4

    {
        public void calistir4()

         {


                {
                    Console.WriteLine("Üç sayıyı girin:");

                    
                    Console.Write("1. Sayı: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("2. Sayı: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.Write("3. Sayı: ");
                    int z = Convert.ToInt32(Console.ReadLine());


                    int enBuyuk = x;
                    if (y > enBuyuk)

                        enBuyuk = y;
                    if (z > enBuyuk)
                        enBuyuk = z;


                    Console.WriteLine("En büyük sayı: " + enBuyuk);

                    Console.ReadLine();
                }


        }
    }
}
