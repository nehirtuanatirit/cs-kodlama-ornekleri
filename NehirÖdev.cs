using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace yilbasi_odevi
{
    public delegate double Hesaplama(double sayi1, double sayi2);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bana işlem yapmak istediğin ilk sayiyi girer misin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayiyi girer misiniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi kısaca tanımlayınız: ");
            string secim = Console.ReadLine();

            Hesaplama islem;

            if (secim == "Toplama")
            {
                islem = Toplama;
            }
            else if (secim == "Carpma")
            {
                islem = Carpma;
            }
            else if (secim == "İlkSayi - İkinciSayi")
            {
                islem = İlkSayidanİkinciSayiyiCikart;
            }
            else if (secim == "İkinciSayi - İlkSayi")
            {
                islem = İkinciSayidanİlkSayiyiCikart;
            }
            else if (secim == "İlkSayi / İkinciSayi")
            {
                islem = İlkSayiyiİkinciSayiyaBol;
            }
            else if (secim == "İkinciSayi / İlkSayi")
            {
                islem = İkinciSayiyiİlkSayiyaBol;
            }
            else if (secim == "İlkSayi % İkinciSayi")
            {
                islem = İlkSayininİkinciSayiyaGoreModu;
            }
            else
            {
                islem = İkinciSayininİlkSayiyaGoreModu;
            }
            Console.WriteLine($"Sonuc: {islem(sayi1,sayi2)}");
        }

        static public double Toplama(double sayi1, double sayi2) => sayi1 + sayi2;
        static public double Carpma(double sayi1, double sayi2) => sayi1 * sayi2;
        static public double İlkSayidanİkinciSayiyiCikart(double sayi1, double sayi2) => sayi1 - sayi2;
        static public double İkinciSayidanİlkSayiyiCikart(double sayi1, double sayi2) => sayi2 - sayi1;
        static public double İlkSayiyiİkinciSayiyaBol(double sayi1, double sayi2)
        {
            if (sayi2 == 0)
            {
                return double.NaN;
            }
            return sayi1 / sayi2;
        }
        static public double İkinciSayiyiİlkSayiyaBol(double sayi1, double sayi2)
        {
            if (sayi1 == 0)
            {
                return double.NaN;
            }
            return sayi2 / sayi1;
        }
        static public double İlkSayininİkinciSayiyaGoreModu(double sayi1, double sayi2)
        {
            if (sayi2 == 0)
            {
                return double.NaN;
            }
            return sayi1 % sayi2;
        }
        static public double İkinciSayininİlkSayiyaGoreModu(double sayi1, double sayi2)
        {
            if (sayi1 == 0)
            {
                return double.NaN;
            }
            return sayi2 % sayi1;
        }
    }
}
