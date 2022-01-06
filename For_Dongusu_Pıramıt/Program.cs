using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_Pıramıt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, sayi;
            Console.Write("Lütfen piramitin kaç basamaklı olacağını giriniz  : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            for (i = 1; i <= sayi; i++)
            {
                for (j = i; j <= sayi; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (i = sayi; i >= 1; i--)
            {

                for (k = sayi; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }  
}

