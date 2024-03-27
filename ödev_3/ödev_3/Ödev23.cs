using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev23

    {
        public void calistir23()

        {

            {


                Console.WriteLine("1.sayıyı giriniz");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.sayıyı giriniz");
                int y = Convert.ToInt32(Console.ReadLine());


                if (x > 0)
                {
                    Console.WriteLine("1.sayı pozitiftir");

                }

                else if (x < 0)
                {
                    Console.WriteLine("1.sayı negatiftir");
                }

                if (y > 0)
                {
                    Console.WriteLine("2.sayı pozitiftir");

                }
                else if (y < 0)
                {
                    Console.WriteLine("2.sayı negatiftir");

                }

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("her iki sayı da pozitiftir");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("her iki sayı da negatiftir");
                }






            }
        }
    }

}
