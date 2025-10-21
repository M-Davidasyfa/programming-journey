using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7_kalkulator_M.David_X_PPLG2
{
    internal class Program
    {
        //Contoh penggunaan fungsi membuat program sederhana Kalkulator

        // Method Main adalah Titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pilihan user apakah ya/tidak

            // Perulangan do-while akan menjalankan blok kode setidaknya sekali
            // dan terus mengulang selama kondisi di while terpenuhi

            do
            {
                Console.Clear(); // Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("=== Kalkulator Sederhana ===");

                // Memanggil fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan Anda (1-4): ");
                string pilihan = Console.ReadLine(); // Membaca input pilihan user

                // Variabel untuk menyimpan angka dan hasil
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi untuk mengambil input angka dari user
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // Struktur kontrol switch-case untuk menentukan operasi berdasarkan pilihan user
                    switch (pilihan)
                    {
                        case "1": // Penjumlahan
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // Pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // Pembagian
                                    // Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            break;
                        default: // Jika pilihan tidak ada case 1-4
                            Console.WriteLine("Pilihan tidak valid. Silakan pilih antara 1-4.");
                            break;
                    }
                }
                // Menanyakan kepada user apakah ingin menghitung lagi
                Console.Write("\nApakah Anda ingin menghitung lagi? (y/n): ");
                hitungLagi = Console.ReadLine();
                // .ToLower() membuat input menjadi huruf kecil, jadi 'Y' atau 'y' sama saja
            }
            while (hitungLagi.ToLower() == "y");


            // Pesan penutup jika pengguna memilih untuk tidak menghitung lagi/keluar
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini. " +
                                "Tekan tombol apa saja untuk keluar");
            Console.ReadKey();
        }

        // --- FUNGSI-FUNGSI BANTUAN ---

        //Fungsi untuk menampilkan menu pilihan
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Pilih operasi (1-4): ");
        }

        // Fungsi untuk mengambil input angka dari pengguna
        // Menggunakan  'out' karena fungsi ini mengembalikan lebih dari satu nilai
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            // double.TryParse akan mencoba mengkonversi input ke double.
            // Jika gagal, return false.
            // Jika berhasil return true dan nilainya disimpan di variabel 'angka1'
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input tidak valid untuk angka pertama.");
                angka2 = 0; // Beri nilai default agar tidak error
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input tidak valid untuk angka kedua.");
                return false;
            }

            return true; // Jika kedua input valid
        }

        // Fungsi untuk penjumlahan
        static double Tambah(double a, double b)
        {
            return a + b;
        }

        // Fungsi untuk pengurangan
        static double Kurang(double a, double b)
        {
            return a - b;
        }

        // Fungsi untuk perkalian
        static double Kali(double a, double b)
        {
            return a * b;
        }

        // Fungsi untuk pembagian
        static double Bagi(double a, double b)
        {
            return a / b;
        }

         

    }
}
