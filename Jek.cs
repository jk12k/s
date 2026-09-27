using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENU BARANG =====");
        Console.WriteLine("1. Indomie  - Rp3.500");
        Console.WriteLine("2. Teh Botol - Rp5.000");
        Console.WriteLine("3. Roti      - Rp7.000");

        Console.Write("Pilih barang: ");
        int pilihan = int.Parse(Console.ReadLine());

        string namaBarang = "";
        int harga = 0;

        switch (pilihan)
        {
            case 1:
                namaBarang = "Indomie";
                harga = 3500;
                break;

            case 2:
                namaBarang = "Teh Botol";
                harga = 5000;
                break;

            case 3:
                namaBarang = "Roti";
                harga = 7000;
                break;

            default:
                Console.WriteLine("Pilihan tidak tersedia.");
                break;
        }

        Console.WriteLine("Barang : " + namaBarang);
        Console.WriteLine("Harga  : Rp" + harga);
    }
}
