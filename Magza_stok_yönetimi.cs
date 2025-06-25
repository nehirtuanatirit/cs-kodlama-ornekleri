using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Kategori sayısını girin: ");
        int kategoriSayisi = int.Parse(Console.ReadLine());

        string[][] urunAdi;
        int[][] stokBilgileri = StokOlustur(kategoriSayisi, out urunAdi);

        Console.Write("Toplam stoğunu kontrol etmek istediğiniz kategori numarasını girin: ");
        int kategoriNo = int.Parse(Console.ReadLine());

        int kategoriStokToplami = KategoriStokToplami(stokBilgileri, kategoriNo);
        Console.WriteLine($"{kategoriNo}. kategorideki toplam stok miktarı: {kategoriStokToplami}");

        int genelStokToplami = GenelStokToplami(stokBilgileri);
        Console.WriteLine($"Tüm ürünlerin genel toplam stok miktarı: {genelStokToplami}");

        var enCokStokluUrun = EnCokStokluUrun(stokBilgileri, urunAdi);
        Console.WriteLine($"En çok stokta bulunan ürün: {enCokStokluUrun.urunIsmi}, Kategori: {enCokStokluUrun.kategoriNo}, Stok miktarı: {enCokStokluUrun.stok}");

        Console.Write("Stok miktarını güncellemek istediğiniz ürünün kategori numarasını girin: ");
        int guncellencekKategori = int.Parse(Console.ReadLine());
        Console.Write("Stok miktarını güncellemek istediğiniz ürünün numarasını girin: ");
        int guncellencekUrun = int.Parse(Console.ReadLine());
        Console.Write("Yeni stok miktarını girin: ");
        int yeniStok = int.Parse(Console.ReadLine());
        StokGuncelle(stokBilgileri, guncellencekKategori, guncellencekUrun, yeniStok);

       
        StokYazdir(stokBilgileri, urunAdi);
        Console.ReadKey();
    }
    public static int[][] StokOlustur(int kategoriSayisi, out string[][] urunAdi)
    {
        int[][] stokDizisi = new int[kategoriSayisi][];
        urunAdi = new string[kategoriSayisi][];

        for (int i = 0; i < kategoriSayisi; i++)
        {
            Console.Write($"{i + 1}. kategori için ürün miktarını girin: ");
            int urunSayisi = int.Parse(Console.ReadLine());
            stokDizisi[i] = new int[urunSayisi];
            urunAdi[i] = new string[urunSayisi];

            for (int j = 0; j < urunSayisi; j++)
            {
                Console.Write($"{i + 1}. kategorideki {j + 1}. ürünün adını girin: ");
                urunAdi[i][j] = Console.ReadLine();

                Console.Write($"{i + 1}. kategorideki {j + 1}. ürünün stok adedini girin: ");
                stokDizisi[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return stokDizisi;
    }
    public static int KategoriStokToplami(int[][] stoklar, int kategoriNo)
    {
        int toplam = 0;
        foreach(int stok in stoklar[kategoriNo - 1])
        {
            toplam += stok;
        }
        return toplam;
    }
    public static int GenelStokToplami(int[][] stoklar)
    {
        int toplam = 0;
        foreach(int[] kategori in stoklar)
        {
            foreach(int stok in kategori)
            {
                 toplam += stok;
            }
        }
        return toplam;
    }
    public static (int kategoriNo, string urunIsmi, int stok) EnCokStokluUrun(int[][] stoklar, string[][] urunAdi)
    {
        int maxStok = -1;
        int kategoriNo = -1;
        int urunNo = -1;
        string urunler = "";

        for(int i = 0; i < stoklar.Length; i++)
        {
            for(int j = 0; j < stoklar[i].Length; j++)
            {
                if (stoklar[i][j] > maxStok)
                {
                    maxStok = stoklar[i][j];
                    kategoriNo = i + 1;
                    urunNo = j + 1;
                    urunler = urunAdi[i][j];
                }
            }
        }
        return (kategoriNo, urunler , maxStok);
    }
    public static void StokGuncelle(int[][] stoklar, int kategoriNo, int urunNo, int yeniStok)
    {
        stoklar[kategoriNo - 1][urunNo - 1] = yeniStok;
    }
    public static void StokYazdir(int[][] stoklar, string[][] urunAdi)
    {
        for( int i = 0;i < stoklar.Length;i++)
        {
            Console.WriteLine($"Kategori {i + 1}:");
            for( int j = 0;j < stoklar[i].Length;j++)
            {
                Console.WriteLine($"  Ürün: {urunAdi[i][j]}, Stok: {stoklar[i][j]}");
            }
        }
    }
}
