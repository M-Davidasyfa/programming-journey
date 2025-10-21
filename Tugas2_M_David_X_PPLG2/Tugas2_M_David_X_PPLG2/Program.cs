using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_M_David_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menampilkan jumlah total dari 1-5:   ");

            int total = 0;
            int penambah = 1;

            Console.WriteLine("Nilai awal:  " + penambah);

            while (penambah <= 5)
            {
                total = total + penambah;
                penambah++;
                Console.WriteLine("Nilai bertambah:  " + penambah);
                total = total + penambah;
                penambah++;
                Console.WriteLine("Nilai bertambah:  " + penambah);
            }
        }
    }
}
