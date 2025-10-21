using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._3_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Insialisasi variabel untuk menyimpan input
            string inputuser = "";

            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'Keluar'");

            // Pengulangan selama isi variabel inputuser TIDAK SAMA DENGAN "Keluar"
            while (inputuser.ToLower() != "Keluar")
            {
                Console.Write("\nketik sesuatu (atau 'Keluar' untuk berhenti): ");
                inputuser = Console.ReadLine(); // Membaca input dari user

                Console.WriteLine("Anda mengetik: " + inputuser);
            }
            Console.WriteLine("\nProgram selesai. Terima kasih!");
        }
    }
}
