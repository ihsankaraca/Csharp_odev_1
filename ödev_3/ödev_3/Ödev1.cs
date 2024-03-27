using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
   

namespace ödev_23
{
    internal class Ödev1
    {
        public void calistir()
        {
            Console.WriteLine("Birinci sayıyı giriniz :");

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapılacak işlemi seçiniz (+) ,(-) ,(x) ,(/) ");
            string vote = Console.ReadLine();


            Console.WriteLine("İkinci sayıyı giriniz :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (vote == "+")
            {
                int sum = number1 + number2;
                Console.WriteLine(sum);
            }
            if (vote == "-")
            {
                int extraction = number1 - number2;
                Console.WriteLine(extraction);
            }
            if (vote == "*")
            {
                int impact = number1 * number2;
                Console.WriteLine(impact);
            }
            if (vote == "/")
            {
                int divide = number1 / number2;
                Console.WriteLine(divide);
            }
            else if (vote == "%")
                Console.Write("Tanınmayan Karakter");
        }

    }
}









