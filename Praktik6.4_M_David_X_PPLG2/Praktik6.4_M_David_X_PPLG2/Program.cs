using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._4_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Inisialisasi variabel perhitungan(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur  :   ");
            //2.Perulangan 'while'
            // Kondisi selama nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                // Blok kode di dalam perulangan
                Console.WriteLine($"Hitungan :    {hitungan}");

                //3.Update variabel perhitungan(decrement/pengurangan)
                // Ini PENTING agar perulangan tidak menjadi loop tak terbatas(infinite loop)
                hitungan = hitungan - 1;
                // Atau bisa juga ditulis   : hitungan--;
            }
            // kode setelah perulangan selesai
            Console.WriteLine("Hitungan selesai!");
        }
    }
}
