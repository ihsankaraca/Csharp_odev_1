using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev19

    {
        public void calistir19()

        {

            {
                Console.Write("Bir tamsayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                
                int carpim = 0;
                for (int i = 0; i < sayi; i++)
                {
                    carpim += sayi;
                }

                Console.WriteLine($"Girdiğiniz sayının kendisi ile çarpımı: {carpim}");
            }
        }
    }










}
        
    

