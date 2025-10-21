using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_M.David_X_PPLG2
{
    internal class Program
    {
        /*Buat fungsi untukn mengubah suhu dari celcius ke fahrenhet dengan rumus:
         F = (9/5) * C + 32
         Dimana F adalah suhu dalam fahrenhet dan C adalah suhu dalam celcius
         Contoh:
         Input: 37
         Output: 98.6*/
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenhet = (celsius * 9 / 5) + 32;
            return fahrenhet;
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Program konvrensi suhu dari celsius ke fahernhet");
           Console.Write("Masukkan suhu dalam Celcius: ");
           double celsius = Convert.ToDouble(Console.ReadLine());
           double fahrenhet = ConvertCelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C = {fahrenhet}°F");
        }
    }
}
