using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ödev_23
{
    internal class Ödev11

    {
        public void calistir11()

        {


            {

                int attempts = 0;

                while (attempts < 3)
                {
                    Console.Write("Kullanıcı adınızı girin: ");
                    string username = Console.ReadLine();

                    Console.Write("Şifrenizi girin: ");
                    string password = Console.ReadLine();

                    if (int.TryParse(username, out int parsedUsername) && int.TryParse(password, out int parsedPassword))
                    {
                        if (parsedUsername == 12 && parsedPassword == 1234)
                        {
                            Console.WriteLine("Giriş başarılı!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
                            attempts++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş. Kullanıcı adı ve şifre tamsayı olmalıdır.");
                    }
                }
                if (attempts == 3)
                {
                    Console.WriteLine("Giriş başarısız. Maksimum deneme sayısına ulaşıldı.");
                }
            }
        }
    }




}






        




  
