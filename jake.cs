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
        int pilihan = 0;

        while (pilihan != 4)
        {
            Console.WriteLine();
            Console.WriteLine("========== DAFTAR BARANG ==========");
            Console.WriteLine("1. Indomie   - Rp3500");
            Console.WriteLine("2. Teh Botol - Rp5000");
            Console.WriteLine("3. Roti      - Rp7000");
            Console.WriteLine("4. Selesai");
            Console.Write("Pilih barang: ");

            pilihan = int.Parse(Console.ReadLine());

            string namaBarang = "";
            double harga = 0;

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

                case 4:
                    Console.WriteLine("Selesai memilih barang.");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }

            if (pilihan >= 1 && pilihan <= 3)
            {
                Console.Write("Jumlah beli: ");
                int jumlah = int.Parse(Console.ReadLine());

                double subtotal = harga * jumlah;
                total = total + subtotal;

                Console.WriteLine("Barang  : " + namaBarang);
                Console.WriteLine("Jumlah  : " + jumlah);
                Console.WriteLine("Subtotal: Rp" + subtotal);
            }
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
