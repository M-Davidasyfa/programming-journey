using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._8_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangipilihan;

            do
            {
                // --- Blok proses yang akan diulang ---
                Console.WriteLine("--------------------------");
                Console.WriteLine("Masukan nama anda:   ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                // ------------------------------------------
                // Pertanyaan untuk mengulang proses
                Console.WriteLine("Apakah anda ingin mengulang proses? (ya/tidak)");
                ulangipilihan = Console.ReadLine().ToLower(); // Mengubah input menjadi huruf kecil

                Console.WriteLine(); // Baris kosong untuk pemisah

                // Kondisi untuk mengakhiri pengulangan jika input bukan "ya"
                } while (ulangipilihan == "ya");
            Console.WriteLine("Terima kasih! Program selesai.");
        }
    }
}
