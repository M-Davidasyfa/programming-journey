using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7_Hitung_Luas_M.David_X_PPLG_2
{
    internal class Program
    {
        static double HitungLuasPersegi(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Luas Persegi Panjang");
            Console.Write("Masukkan Panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = HitungLuasPersegi(panjang, lebar);
            Console.WriteLine("Luas Persegi Panjang: " + luas);
            Console.ReadKey();

        }
    }
}
