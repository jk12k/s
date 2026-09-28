using System;

class Program
{
    static void Main()
    {
        // =========================
        // LOGIN
        // =========================
        string userBenar = "admin";
        string passBenar = "12345";

        Console.WriteLine("=================================");
        Console.WriteLine("       LOGIN WARUNG MADURA       ");
        Console.WriteLine("=================================");

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

        // =========================
        // KASIR
        // =========================
        double total = 0;
        string lanjut = "y";

        while (lanjut == "y")
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       WARUNG MADURA JAYA        ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Indomie       Rp3500");
            Console.WriteLine("2. Es Teh        Rp4000");
            Console.WriteLine("3. Kopi          Rp5000");
            Console.WriteLine("4. Rokok         Rp25000");
            Console.WriteLine("5. Beras 5 Kg    Rp75000");
            Console.WriteLine("=================================");

            Console.Write("Pilih barang (1-5): ");
            int pilihan = int.Parse(Console.ReadLine());

            string namaBarang = "";
            double harga = 0;

            switch (pilihan)
            {
                case 1:
                    namaBarang = "Indomie";
                    harga = 3500;
                    break;

                case 2:
                    namaBarang = "Es Teh";
                    harga = 4000;
                    break;

                case 3:
                    namaBarang = "Kopi";
                    harga = 5000;
                    break;

                case 4:
                    namaBarang = "Rokok";
                    harga = 25000;
                    break;

                case 5:
                    namaBarang = "Beras 5 Kg";
                    harga = 75000;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia!");
                    continue;
            }

            Console.Write("Jumlah beli: ");
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
            lanjut = Console.ReadLine().ToLower();
        }

        // =========================
        // DISKON
        // =========================
        double diskon = 0;

        if (total >= 100000)
        {
            diskon = total * 0.10;
        }

        double totalBayar = total - diskon;

        // =========================
        // STRUK
        // =========================
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("          STRUK BELANJA          ");
        Console.WriteLine("=================================");
        Console.WriteLine("Total       : Rp" + total);
        Console.WriteLine("Diskon      : Rp" + diskon);
        Console.WriteLine("Total Bayar : Rp" + totalBayar);
        Console.WriteLine("=================================");
        Console.WriteLine("         TERIMA KASIH            ");
        Console.WriteLine("=================================");
    }
}
