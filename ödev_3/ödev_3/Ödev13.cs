using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev13

    {
        public void calistir13()

        {

            {

                {
                    Console.Write("Başlangıç sayısını girin (x): ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bitiş sayısını girin (y): ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nÇarpım Tablosu:\n");

                    for (int i = x; i <= y; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine($"{i} x {j} = {i * j}");
                        }
                        Console.WriteLine();
                    }
                }
                            
            {
            
                }
            }
        }
    }

}