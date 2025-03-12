using System;
using System.Collections.Generic;

class KodeProduk
{
    private static Dictionary<string, String> kodeProdukDictionary = new Dictionary<string, String>
    {
        {"laptop", "E100" },
        {"smartphone", "E101" },
        {"tablet", "E102" },
        {"headset", "E103" },
        {"keyboard", "E104" },
        {"mouse", "E105" },
        {"printer", "E106" },
        {"monitor", "E107" },
        {"smartwatch", "E108" },
        {"kamera", "E109" }
    };

    public static string GetKodeProduk(string produk)
    {
        if (kodeProdukDictionary.TryGetValue(produk, out string KodeProduk))
        {
            return KodeProduk;
        }
        else
        {
            return "kode tidak ditemukan";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("masukan nama produk : ");
        string produk = Console.ReadLine();
        string KodeProduk = GetKodeProduk(produk);
        Console.WriteLine($"kode produk untuk {produk} adalah {KodeProduk}");
    }
}