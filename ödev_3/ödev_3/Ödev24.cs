using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev24

    {
        public void calistir24()

        {

            {
                Console.Write("Birinci tamsayı girin: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci tamsayı girin: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int positive = 0;
                if (a > 0)
                    positive++;
                if (b > 0)
                    positive++;

                Console.WriteLine(positive);

            }
        }
    }

}
