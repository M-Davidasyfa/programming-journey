using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._5_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Inisialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20    :   ");

            // 2. Blok 'do-while' untuk menampilkan angka 1 sampai 20
            do
            {
                // Menampilkan angka saat ini
                Console.WriteLine(angka + " ");

                // Menambah nilai penghitung (counter) sebesar 1
                angka++;

            } while (angka <= 20); // Kondisi untuk melanjutkan loop
            Console.WriteLine("Selesai");
        }
    }
}
