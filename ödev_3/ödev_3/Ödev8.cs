using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace ödev_23
{
    internal class Ödev8

    {
        public void calistir8()

        {

            {
                Console.WriteLine("1.sayıyı giriniz:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.sayıyı giriniz:");
                int y= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("3.sayıyı giriniz:");
                int z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("4.sayıyı giriniz:");
                int q = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("5.sayıyı giriniz:");
                int w= Convert.ToInt32(Console.ReadLine());

                int toplam = x + y + z + q + w;
                int ortalama = (x + y + z + q + w) / 5;
              

                Console.WriteLine(toplam);
                Console.WriteLine(ortalama);

                
                
                if (x > y && x > z && x > q && x > w)
                {
                    int max = x;
                    Console.WriteLine("max sayı:"+max);  
                }
                else if (y > x && y > z && y > q && y > w)
                {
                    int max = y;
                    Console.WriteLine("max sayı:"+max);
                }
                else if (z > y && z > x && z > q && z > w)
                {
                    int max = z;
                    Console.WriteLine("max sayı:" + max);
                }
                else if (q > y && q > z && q > x && q > w)
                {
                    int max = q;
                    Console.WriteLine("max sayı:" + max);
                }
                else if (w > y && w > z && w > q && w > x)
                {
                    int max = w;
                    Console.WriteLine("max sayı:" + max);
                }
                if (x < y && x < z && x < q && x < w)
                {
                    int min = x;
                    Console.WriteLine("min sayı:" + min);
                }
                else if (y < x && y < z && y < q && y < w)
                {
                    int min = y;
                    Console.WriteLine("min sayı:" + min);
                }
                else if (z < y && z < x && z < q && z < w)
                {
                    int min = z;
                    Console.WriteLine("min sayı:" + min);
                }
                else if (q < y && q < z && q < x && q < w)
                {
                    int min = q;
                    Console.WriteLine("min sayı:" + min);
                }
                else if (w < y && w < z && w < q && w < x)
                {
                    int min = w;
                    Console.WriteLine("min sayı:" + min);
                }
            }






        }




    }

}