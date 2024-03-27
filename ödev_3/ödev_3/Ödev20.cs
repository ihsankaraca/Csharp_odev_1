using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev20

    {
        public void calistir20()

        {
            Console.WriteLine("bir sayı giriniz");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    y++;
                }

            }
            
            if (y == 0)
            {
                Console.WriteLine("Asal");
            }
             else
             {
                Console.WriteLine("Asal değil");
             }

          










            
        }
    }

}