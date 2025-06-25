using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace önemli_Proje_2
{
    internal class Televizyon
    {
        public string Model;
        public int ÜretimYılı;
        public string Renk;
        public int EkranBüyüklügü;
        public string Marka;

        public void KanalDegistir()
        {
            Console.WriteLine("Kanal değiştiriliyor");
        }
        public void SesAc()
        {
            Console.WriteLine("Ses açılıyor");
        }
        public void SesKıs()
        {
            Console.WriteLine("Ses kısılıyor");
        }
        public void Ekran()
        {
            Console.WriteLine("Ekran açılıyor");
        }
    }
}
