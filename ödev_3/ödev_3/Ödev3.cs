using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ödev_23
{
    internal class Ödev3

    {
        public void calistir3()
        
            
            
            {
                Console.WriteLine("Bir sayı girin: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x > 0)
                {
                    Console.WriteLine("Girilen sayı pozitif.");
                }
                else if (x < 0)
                {
                    Console.WriteLine("Girilen sayı negatif.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı sıfırdır.");
                }
         }
     }



}


   
       
    

