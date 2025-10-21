using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_M.David_X_PPLG2
{
    internal class Program
    {
        static double Hitungkali(double angka1, double angka2, double angka3)
        {
            double hasil = angka1 * angka2 * angka3;
            return hasil;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukan angka pertama:   ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka kedua: ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka ketiga:    ");
            int angka3 = Convert.ToInt32(Console.ReadLine());

            double hasil = Hitungkali(angka1, angka2, angka3);
            Console.WriteLine("Hasil kali dari ketiga angka tersebut adalah: " + hasil);
            Console.ReadKey();
        }
    }
}
