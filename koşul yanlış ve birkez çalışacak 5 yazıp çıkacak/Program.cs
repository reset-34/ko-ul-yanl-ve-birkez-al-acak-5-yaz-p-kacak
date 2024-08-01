using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koşul_yanlış_ve_birkez_çalışacak_5_yazıp_çıkacak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 4);
            Console.ReadLine();
        }
    }
}
