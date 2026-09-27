using System;

class Program
{
    static void Main()
    {
  
        Console.WriteLine("========== REGISTER ==========");
        Console.Write("Buat Username : ");
        string userBenar = Console.ReadLine();

        Console.Write("Buat Password : ");
        string passBenar = Console.ReadLine();

        Console.WriteLine("Akun berhasil dibuat!");
        Console.WriteLine();


        Console.WriteLine("========== LOGIN ==========");

        int percobaan = 0;
        bool berhasil = false;

        while (percobaan < 3 && berhasil == false)
        {
            Console.Write("Username: ");
            string user = Console.ReadLine();
            Console.Write("Password: ");
            string pass = Console.ReadLine();

            if (user == userBenar && pass == passBenar)
            {
                Console.WriteLine("Login berhasil!");
                berhasil = true;
            }
            else
            {
                percobaan++;
                Console.WriteLine("Login gagal. Percobaan ke-" + percobaan);
            }
        }

        if (berhasil == false)
        {
            Console.WriteLine("Akun terkunci, hubungi admin.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       KASIR SEDERHANA           ");
        Console.WriteLine("=================================");

        Console.Write("Nama barang : ");
        string nbarang = Console.ReadLine();
        Console.Write("Harga barang: ");
        double harga = double.Parse(Console.ReadLine());
        Console.Write("Jumlah beli : ");
        int jumlah = int.Parse(Console.ReadLine());

        double total = harga * jumlah;

        double diskon = 0;
        if (total >= 100000)
        {
            diskon = total * 0.1;
        }

        double bayar = total - diskon;

    
        Console.WriteLine();
        Console.WriteLine("========== STRUK BELANJA ==========");
        Console.WriteLine("Barang      : " + nbarang);
        Console.WriteLine("Harga       : " + harga);
        Console.WriteLine("Jumlah      : " + jumlah);
        Console.WriteLine("Total       : " + total);
        Console.WriteLine("Diskon      : " + diskon);
        Console.WriteLine("Total Bayar : " + bayar);
        Console.WriteLine("===================================");
        Console.WriteLine("Terima kasih!");
    }
}