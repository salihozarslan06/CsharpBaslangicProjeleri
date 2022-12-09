using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
namespace vizeFinalHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize = 0;
            double final = 0;
            Console.WriteLine(new string('-', 50));
            EchoWriteLine("Vize - Final Hesaplama Uygulamasına Hoşgeldiniz.", ConsoleColor.Cyan);
            EchoWriteLine("Devam Etmek İçin Herhangi Bir Tuşa Çıkış Yapmak İçin 'Escape' Tuşuna Basınız.", ConsoleColor.Cyan);
            Console.WriteLine(new string('-', 50));

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine('\n' + new string('-', 50) + '\n');
                EchoWrite("Vize Notunuz: ", ConsoleColor.Magenta);
                try
                {
                    vize = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    EchoWriteLine("Hatalı bir giriş yapıldı. Çıkış Yapılıyor...\n", ConsoleColor.Red);
                    Console.WriteLine(e.Message);
                    Sleep(2000);
                    Environment.Exit(0);
                }
                EchoWrite("Final Notunuz: ", ConsoleColor.Magenta);
                try
                {
                    final = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    EchoWriteLine("Hatalı bir giriş yapıldı. Çıkış Yapılıyor...\n", ConsoleColor.Red);
                    Console.WriteLine(e.Message);
                    Sleep(2000);
                    Environment.Exit(0);
                }
                Hesaplaniyor("ORTALAMA HESAPLANIYOR");
                Console.WriteLine(new string('-', 50) + '\n');
                double ort = (vize * 0.40) + (final * 0.60);
                string text;
                ConsoleColor colorOrt;
                if (ort >= 50)
                {
                    text = "GEÇTİNİZ.";
                    colorOrt = ConsoleColor.Green;
                }
                else
                {
                    text = "KALDINIZ.";
                    colorOrt = ConsoleColor.Red;
                }
                EchoWriteLine($"\tVize notunuz: {vize} / Final Notunuz: {final} / Ortalamanız: {ort}\n\n\t{text}", colorOrt);
                Console.WriteLine('\n' + new string('-', 50));
                Console.ReadLine();
                EchoWriteLine("Devam Etmek İçin Herhangi Bir Tuşa Çıkış Yapmak İçin 'Escape' Tuşuna Basınız.", ConsoleColor.Cyan);
            }

            Console.Clear();
            EchoWriteLine("Çıkış Yapılıyor.", ConsoleColor.Red);
            Sleep(2000);
        }
        static void EchoWriteLine(string message, ConsoleColor color)
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
        static void Hesaplaniyor(string message)
        {
            Random rnd = new Random();
            Console.Clear();
            Console.CursorVisible = false;
            for (int i = 0; i < 121; i++)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                    if (consoleKey.Key == ConsoleKey.Enter)
                        break;
                }
                if (i < message.Length)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 6);
                    Console.Write(message[i]);
                    Sleep(40);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{message} - %{i - 21}");
                    Sleep(5);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
