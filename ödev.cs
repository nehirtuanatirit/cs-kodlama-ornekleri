using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzersiz_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Ödev 1
            Console.Write("Lütfen bir sıcaklık giriniz: ");
            int sicaklik = int.Parse(Console.ReadLine());

            if (sicaklik > 30)
            {
                Console.WriteLine("Çok sıcak!");
            }
            else if (sicaklik > 20 && sicaklik <= 30)
            {
                Console.WriteLine("Hava güzel.");
            }
            else if (sicaklik > 10 && sicaklik <= 20)
            {
                Console.WriteLine("Biraz serin.");
            }
            else
            {
                Console.WriteLine("Hava çok soğuk!");
            }
            #endregion

            #region  switch case egzersizleri

            Console.Write("Lütfen bir gün giriniz: ");
            string gun = Console.ReadLine();

            switch(gun)
            {
                case "Pazartesi":
                    Console.WriteLine("Haftanın ilk günü");
                    break;
                case "Cuma":
                    Console.WriteLine("Haftanın son günü");
                    break;
                case "Cumartesi":
                case "Pazar":
                    Console.WriteLine("Hafta Sonu");
                    break;
                default:
                    Console.WriteLine("normal gün");
                    break;
            }
            #endregion

            #region for döngüsü egzersizi
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region  break egzersizi

            for(int i = 0;i < 100; i++)
            {
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            #endregion  
            Console.ReadKey();
        }
    }
}
