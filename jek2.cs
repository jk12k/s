using System;

class Program
{
    static void Main()
    {
        string userBenar = "admin";
        string passBenar = "12345";

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
        Console.WriteLine("        KASIR SEDERHANA          ");
        Console.WriteLine("=================================");

        double total = 0;
        string lanjut = "y";

        while (lanjut == "y")
        {
            Console.WriteLine();

            Console.Write("Nama barang : ");
            string namaBarang = Console.ReadLine();

            Console.Write("Harga barang: ");
            double harga = double.Parse(Console.ReadLine());

            Console.Write("Jumlah beli : ");
            int jumlah = int.Parse(Console.ReadLine());

            double subtotal = harga * jumlah;

            total = total + subtotal;

            Console.WriteLine();
            Console.WriteLine("Barang   : " + namaBarang);
            Console.WriteLine("Harga    : Rp" + harga);
            Console.WriteLine("Jumlah   : " + jumlah);
            Console.WriteLine("Subtotal : Rp" + subtotal);

            Console.WriteLine();
            Console.Write("Tambah barang lagi? (y/n): ");
            lanjut = Console.ReadLine();
        }

        double diskon = 0;

        if (total >= 100000)
        {
            diskon = total * 0.1;
        }

        double bayar = total - diskon;

        Console.WriteLine();
        Console.WriteLine("========== STRUK BELANJA ==========");
        Console.WriteLine("Total       : Rp" + total);
        Console.WriteLine("Diskon      : Rp" + diskon);
        Console.WriteLine("Total Bayar : Rp" + bayar);
        Console.WriteLine("===================================");
        Console.WriteLine("Terima kasih!");
    }
}
