using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_23
{
     internal class Ödev2

    {
        public void calistir2()
        {



            Console.WriteLine("Yapılacak işlemi seçin 1/toplama 2/çıkarma 3/çarpma 4/bölme");
            int process = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. sayıyı  giriniz :");
            int number1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("2. sayıyı giriniz :");
            int number2 = Convert.ToInt32(Console.ReadLine());


            int total = (number1 + number2);
            int extraction = (number1 - number2);
            int impact = (number1 * number2);
            int divide = (number1 / number2);


            switch (process)
            {
                case 1:
                    Console.WriteLine("toplama sonucu = " + total);
                    break;

                case 2:
                    Console.WriteLine("çıkarma sonucu = " + extraction);
                    break;

                case 3:
                    Console.WriteLine("çarpma sonucu = " + impact);
                    break;

                case 4:
                    Console.WriteLine("bölme sonucu = " + divide);
                    break;

                default:
                    Console.WriteLine("Tanımlanmayan Karakter");
                    break;
            }



        }
    }
}

