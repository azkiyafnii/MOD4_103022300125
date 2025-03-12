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

public class Fan
{
    enum State { QUIET, BALANCED, PERFORMANCE, TURBO };
    public static void Main()
    {
        State state = State.QUIET;
        string command = "";
        string[] screenName = { "QUIET", "BALANCED", "PERFORMANCE", "TURBO" };
        while (command != "EXIT")
        {
            Console.WriteLine(" ");
            Console.WriteLine(screenName[(int)state] + " SCREEN");
            Console.Write("Enter Command : ");

            command = Console.ReadLine();
            switch (state)
            {
                case State.QUIET:
                    if (command == "mode up quiet")
                        state = State.BALANCED;
                    else if (command == "turbo shortcut quiet")
                        state = State.TURBO;
                        Console.WriteLine("Fan Quiet Beubah Menjadi Turbo");
                    break;

                case State.BALANCED:
                    if (command == "mode down balanced")
                        state = State.QUIET;
                    else if (command == "mode up balanced")
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan Quiet berubah menjadi Balance");
                    break;

                case State.PERFORMANCE:
                    if (command == "mode down performance")
                        state = State.BALANCED;
                    else if (command == "mode up performance")
                        state = State.TURBO;
                    break;

                case State.TURBO:
                    if (command == "mode down turbo")
                        state = State.PERFORMANCE;
                    else if (command == "turbo shortcut turbo")
                        state = State.QUIET;
                    break;
            }
        }
        Console.WriteLine("EXIT SCREEN");
    }
}