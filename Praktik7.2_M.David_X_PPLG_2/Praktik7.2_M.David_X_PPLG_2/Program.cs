using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._2_M.David_X_PPLG_2
{
    internal class Program
    {
        static void Sapanama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# dalam hari ini!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Sapanama(nama);
            Console.ReadKey();
        }
    }
}
