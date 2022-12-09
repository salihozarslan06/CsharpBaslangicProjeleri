using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
namespace sayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz.");
            Console.WriteLine("Devam etmek için herhangi bir tuşa Çıkış yapma için 'Escape' Tuşuna basınız.");
            Console.WriteLine(new string('-', 50));
            Random rand = new Random();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                int computerSelection = rand.Next(1, 100);
                App(computerSelection);
            }
        }

        static void App(int computerSelection)
        {
            int deneme = 1;
            Console.Write("1-100 arasında Tahmininizi Giriniz: ");
            int enter = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (enter > computerSelection)
                {
                    Console.WriteLine($"\n{deneme}. Deneme - Daha küçük bir sayı giriniz: ");
                    enter = Convert.ToInt32(Console.ReadLine());
                    deneme++;
                }
                else if (enter < computerSelection)
                {
                    Console.WriteLine($"\n{deneme}. Deneme - Daha büyük bir sayı giriniz: ");
                    enter = Convert.ToInt32(Console.ReadLine());
                    deneme++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Tahmininiz: {enter}\n{deneme}. Denemede buldunuz.");
                    Console.WriteLine("Devam etmek için herhangi bir tuşa Çıkış yapma için 'Escape' Tuşuna basınız.");
                    break;
                }
            }
        }
    }
}
