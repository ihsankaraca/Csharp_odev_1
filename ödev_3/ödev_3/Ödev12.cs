using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_23
{
    internal class Ödev12

    {
        public void calistir12()
        {

            Console.WriteLine("1.sayıyı  giriniz");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("sayı tam bölünür");
            }
            else
            {
                Console.WriteLine("bu sayı tam bölünmez");
            }
;
            Console.ReadKey();

 
        }



     }
}

