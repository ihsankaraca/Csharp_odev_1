using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev22

    {
        public void calistir22()

        {

            {

                Console.WriteLine("ürünün fiyatını giriniz");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("verdiğiniz parayı giiriniz");
                int y = Convert.ToInt32(Console.ReadLine());

                int total = y - x;

                if (y > x)

                {
                    Console.WriteLine("paranızın üstü:" + total);
                }

                else
                {
                    Console.WriteLine("bu ürüne paranız yetmiyor");
                }



            }
        }
    }

}