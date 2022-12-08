using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace dizilerOrnekProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tAraba Sistemine Hoşgeldiniz.");
            Console.WriteLine(new string('-', 50) + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            string[] cars = new string[0];
            while (true)
            {
                Console.Write("\nAraba Ekle (1) Arabaları Listele (2) / Çıkış (0): ");
                char enter = Console.ReadKey().KeyChar;

                if (enter == '1')
                {
                    string[] carsContainer = cars;
                    cars = new string[cars.Length + 1];
                    for (int i = 0; i < carsContainer.Length; i++)
                    {
                        cars[i] = carsContainer[i];
                    }
                    Console.Write($"\n\n{cars.Length}. Arabanın Modeli: ");
                    cars[cars.Length - 1] = Console.ReadLine();
                }
                else if(enter == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. Araba: {cars[i]}");
                    }
                    Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(enter == '0')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Çıkış Yapılıyor...");
                    if (DateTime.Now.Hour > 16 || DateTime.Now.Hour < 4) Console.WriteLine("İyi Akşamlar.");
                    else Console.WriteLine("İyi Günler.");
                    Sleep(2000);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Hatalı Bir Tuşlama Yapıldı Çıkış Yapılıyor.");
                    Sleep(2000);
                    break;
                }

            }
        }
    }
}
