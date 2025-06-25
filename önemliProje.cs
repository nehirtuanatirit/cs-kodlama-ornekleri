using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace önemli_proje1
{
    internal class önemliProje
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin satır sayısını giriniz: ");
            int satir = int.Parse(Console.ReadLine());
            Console.Write("Matrisin sütun sayısını giriniz: ");
            int sutun = int.Parse(Console.ReadLine());

            int[,] matris = MatrisOlustur(satir, sutun);
            
            Console.Write("Kontrol edilecek sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            var konum = ElemanBul(matris, sayi);  

            if (konum.satir != -1 && konum.sutun != -1)
                Console.WriteLine($"Aradığın sayının konumu: [{konum.satir},{konum.sutun}]");
            else
                Console.WriteLine("Aradığın sayı matriste bulunmamaktadır");

            int toplam = ToplamHesapla(matris);
            Console.WriteLine($"Matristeki elemanların toplamı: {toplam}");

            Console.Write("kontrol etmek istediğiniz satır numarsını giriniz: ");
            int satirNo = int.Parse(Console.ReadLine());
            int enBuyukEleman = EnBuyukElemanSatir(matris, satirNo);
            Console.WriteLine($"Aradığınız satırdaki en büyük eleman: {enBuyukEleman}");
            MatrisYazdir(matris);

            Console.ReadKey();
        }
        public static int[,] MatrisOlustur(int satir, int sutun)
        {
            int[,] matris = new int[satir, sutun]; 
            for (int i = 0; i < satir; i++) 
            { 
                for (int j = 0; j < sutun; j++) 
                { 
                    Console.Write("Matrisin [" + i + "," + j + "] elemanını girin: ");
                    matris[i, j] = int.Parse(Console.ReadLine()); 
                } 
            }
            return matris;
        }
        public static (int satir, int sutun) ElemanBul(int[,] matris, int aranan)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0;j < matris.GetLength(1); j++)
                {
                    if(matris[i, j] == aranan)
                    {
                        return (i, j);
                    }
                }
            }
         return (-1,-1);
        }
        public static int ToplamHesapla(int[,] matris)
        {
            int toplam = 0;
            for( int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    toplam += matris[i, j];
                }
            }
            return toplam;
        }
        public static int EnBuyukElemanSatir(int[,] matris, int satirNo)
        {
            if (satirNo < 0 || satirNo >= matris.GetLength(0))
                Console.WriteLine("Geçersiz satır numarası!!");
            int enBuyuk = matris[satirNo, 0];
            for(int j = 1 ; j < matris.GetLength(1); j++)
            {
                if (matris[satirNo, j] > enBuyuk)
                {
                     enBuyuk = matris[satirNo, j];
                }
            }
            return enBuyuk;
        }
        public static void MatrisYazdir(int[,] matris)
        {
            Console.WriteLine("Matris: ");
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
