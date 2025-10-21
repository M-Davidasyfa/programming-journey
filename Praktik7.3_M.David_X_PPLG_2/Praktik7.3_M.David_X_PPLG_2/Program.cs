using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._3_M.David_X_PPLG_2
{
    internal class Program
    {
        static int Tambah(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka pertama: ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua: ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = Tambah(angka1, angka2);
            Console.WriteLine("Hasil penjumlahan: " + hasil);
            Console.ReadKey();
        }
    }
}
