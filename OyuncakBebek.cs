using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace önemli_Proje_2
{
    internal class OyuncakBebek
    {
        public string Adi;
        public int Yasi;
        public string SacRengi;
        
        public void Konus()
        {
            Console.WriteLine("Bebek konuşuyor");
        }
        public void SagaDon()
        {
            Console.WriteLine("Bebek sağa doğru yürüyor");
        }
        public void SolaDon()
        {
            Console.WriteLine("Bebek sola doğru yürüyor");
        }
        public void IlerıGıt()
        {
            Console.WriteLine("Bebek ileri ilerledi");
        }
        public void GerıDon()
        {
            Console.WriteLine("Bebek geri döndü");
        }
    }
       
}
