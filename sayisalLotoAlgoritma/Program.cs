using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayısalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] loto = new int[6];
            Random random = new Random();
            bool varMi = false;
            for (int i = 0; i < loto.Length; i++)
            {
                int sayi = random.Next(1, 7);
                for (int j = 0; j < loto.Length; j++)
                {
                    if (loto[j] == sayi)
                    {
                        varMi = true;
                        break;
                    }
                    else
                        varMi = false;
                }
                if (varMi)
                    i--;
                else
                    loto[i] = sayi;
            }
            for (int i = 0; i < loto.Length; i++)
            {
                Console.Write($"{loto[i]}\t");
            }
            Console.ReadLine();
        }
    }
}
