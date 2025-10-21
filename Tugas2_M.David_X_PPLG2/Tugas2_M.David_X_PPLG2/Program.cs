using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_M.David_X_PPLG2
{
    internal class Program
    {
        static double RataRata(double nilai1, double nilai2, double nilai3)
            {
            return (nilai1 + nilai2 + nilai3) / 3;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai pertama:   ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan nilai kedua: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan nilai ketiga:    ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            double rataRata = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Rata-rata nilai: " + rataRata);
        }
    }
}
