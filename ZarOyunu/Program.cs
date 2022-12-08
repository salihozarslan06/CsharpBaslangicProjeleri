using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tZar Oyununa Hoşgeldiniz.");
            Console.WriteLine(new string('-', 50) + "\n");
            Console.ForegroundColor = ConsoleColor.White;

            int zar_1, zar_2;
            int deneme = 1;

            Console.Write("Hangi Çifti İstiyorsunuz: ");

            int enter = Convert.ToInt32(Console.ReadLine());
            if (enter < 1 || enter > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Girdiğiniz çift 1-6 aralığında olmalı.\nProgram kapanıyor.");
                Sleep(2000);
                Environment.Exit(0);
            }
            while (true)
            {
                zar_1 = rand.Next(1, 7);
                zar_2 = rand.Next(1, 7);
                if (zar_1 == enter && zar_2 == enter)
                {
                    Console.WriteLine($"{deneme}. Deneme - **({zar_1},{zar_2})**");
                    break;
                }
                else
                {
                    Console.WriteLine($"{deneme}. Deneme - ({zar_1},{zar_2})");
                    Sleep(100);
                    deneme++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine($"{deneme}. Denemede - **({zar_1},{zar_2})** bulundu");
            Console.WriteLine(new string('-', 50));
            Console.ReadLine();
        }
    }
}
