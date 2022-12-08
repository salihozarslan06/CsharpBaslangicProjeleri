using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tHesap Makinesine Hoşgeldiniz.");
            Console.WriteLine(new string('-', 50) + "\n");

            Console.Write("Toplama (1) Çıkartma (2) Çarpma (3) Bölme (4): ");
            char enter = Console.ReadKey().KeyChar;

            Console.Write("\n\n1. Sayıyı Giriniz: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (enter)
            {
                case '1':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{num1} + {num2} = {num1+num2}"); 
                    break;

                case '2':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}"); 
                    break;

                case '3':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{num1} x {num2} = {num1 * num2}"); 
                    break;

                case '4':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}"); 
                    break;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı bir tuşlama yapıldı.\nÇıkış Yapılıyor.");
                    Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
