using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._7_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                // Tampilan Menu
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah Data");
                Console.WriteLine("3. Hapus Data");
                Console.WriteLine("Masukan pilihan anda (1-3):  ");

                // baca pilihan user
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka antara 1-3.");
                    // Tetapkan nilai selain 3 agar loop terus berlanjut
                    pilihan = 0;
                    continue; // Lanjutkan ke iterasi berikutnya
                }

                // Proses pilihan pengguna
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data.");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah Data.");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan masukkan angka antara 1-3.");
                        break;
                }

            } while (pilihan != 3); // Loop terus menerus hingga pengguna memilih opsi "Keluar"
            Console.WriteLine("Terimakasih telah menggunakan aplikasi ini.");

        }
    }
}
