using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace tasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(new string('-', 50));
            Echo("Taş - Kağıt - Makas Oyununa Hoşgeldiniz.", ConsoleColor.Red);
            Echo("Devam etmek için herhangi bir tuşa başınız.", ConsoleColor.Red);
            Echo("(Çıkış Yapmak için Escape)", ConsoleColor.Red);
            Console.WriteLine(new string('-', 50));

            int userPuan = 0;
            int computerPuan = 0;
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Clear();
                int computerSelection = rand.Next(1, 4);
                int userSelection = 0;
                EchoWrite("Taş (1) Kağıt (2) Makas (3): ", ConsoleColor.Cyan);
                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Echo($"Hatalı bir tuşlama yapıldı.\nÇıkış Yapılıyor.\n\nHata Sebebi: {e.Message}", ConsoleColor.Red);
                    Sleep(4000);
                    Environment.Exit(0);
                }
                if (userSelection == 1 && computerSelection == 1)
                    Echo("\nSenin seçimin: Taş\nBilgisayarın seçimi: Taş\nBERABERE", ConsoleColor.Yellow);
                else if(userSelection == 1 && computerSelection == 2)
                {
                    Echo("\nSenin seçimin: Taş\nBilgisayarın seçimi: Kağıt\nKAYBETTİNİZ", ConsoleColor.Red);
                    computerPuan++;
                }
                else if (userSelection == 1 && computerSelection == 3)
                {
                    Echo("\nSenin seçimin: Taş\nBilgisayarın seçimi: Makas\nKAZANDINIZ", ConsoleColor.Green);
                    userPuan++;
                }

                else if (userSelection == 2 && computerSelection == 2)
                    Echo("\nSenin seçimin: Kağıt\nBilgisayarın seçimi: Kağıt\nBERABERE", ConsoleColor.Yellow);
                else if (userSelection == 2 && computerSelection == 1)
                {
                    Echo("\nSenin seçimin: Kağıt\nBilgisayarın seçimi: Taş\nKAZANDINIZ", ConsoleColor.Green);
                    userPuan++;
                }
                else if (userSelection == 2 && computerSelection == 3)
                {
                    Echo("\nSenin seçimin: Kağıt\nBilgisayarın seçimi: Makas\nKAYBETTİNİZ", ConsoleColor.Red);
                    computerPuan++;
                }

                else if (userSelection == 3 && computerSelection == 3)
                    Echo("\nSenin seçimin: Makas\nBilgisayarın seçimi: Makas\nBERABERE", ConsoleColor.Yellow);
                else if (userSelection == 3 && computerSelection == 2)
                {
                    Echo("\nSenin seçimin: Makas\nBilgisayarın seçimi: Kağıt\nKAZANDINIZ", ConsoleColor.Green);
                    userPuan++;
                }
                else if (userSelection == 3 && computerSelection == 1)
                {
                    Echo("\nSenin seçimin: Makas\nBilgisayarın seçimi: Taş\nKAYBETTİNİZ", ConsoleColor.Red);
                    computerPuan++;
                }
                else
                {
                    Console.Clear();
                    Echo("Hatalı bir tuşlama yapıldı.\nÇıkış Yapılıyor.", ConsoleColor.Red);
                    Sleep(2000);
                    Environment.Exit(0);
                }

                Console.ReadLine();
                Console.Clear();

                if (userPuan > computerPuan)
                    Echo($"Senin Puanın: [{userPuan}]\nBilgisayarın Puanı: [{computerPuan}]\nÖndesin", ConsoleColor.Green);
                else if(userPuan < computerPuan)
                    Echo($"Senin Puanın: [{userPuan}]\nBilgisayarın Puanı: [{computerPuan}]\nGeridesin", ConsoleColor.Red);
                else
                    Echo($"Senin Puanın: [{userPuan}]\nBilgisayarın Puanı: [{computerPuan}]\nBERABERE", ConsoleColor.Cyan);

                Echo("Devam etmek için herhangi bir tuşa başınız.", ConsoleColor.Red);
            }
            Console.Clear();
            Echo("Çıkış Yapılıyor...", ConsoleColor.Red);
            if (DateTime.Now.Hour > 16 || DateTime.Now.Hour < 4) Echo("İyi Akşamlar", ConsoleColor.Red);
            else Echo("İyi Günler", ConsoleColor.Red);
            Sleep(2000);
        }

        static void Echo(string message, ConsoleColor color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void EchoWrite(string message, ConsoleColor color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
