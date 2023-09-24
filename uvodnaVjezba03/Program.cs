using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double z;
        vrati:
            Console.Write("Unesite dužinu x stranice : ");
            x = int.Parse(Console.ReadLine());
            if (x < 1)
            {
                Console.Write("Unesite dužinu x stranice opet");
                Console.WriteLine();
                x=0;
                goto vrati;
            }
            Console.Write("Unesite dužinu y stranice : ");
            y = int.Parse(Console.ReadLine());
            if (y<1)
            {
                Console.Write("Unesite dužinu y stranice opet");
                Console.WriteLine();
                y=0;
                goto vrati;
            }
            Console.Write("Unesite dužinu z stranice : ");
            z = int.Parse(Console.ReadLine());
            if (z<1) 
            {
                Console.Write("Unesite dužinu z stranice opet");
                Console.WriteLine();
                z=0;
                goto vrati;
            }

            if (x > y && x > z)
            {
                double sum = Math.Sqrt((y * y) + (z * z));

                if (x == sum)
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                }
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }
            }
            else if (y > x && y > z)
            {
                double sum = Math.Sqrt((x * x) + (z * z));

                if (y == sum)
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                }
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }
            }
            else
            {
                double sum = Math.Sqrt((x * x) + (y * y));

                if (z == sum)
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                }
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }

            }

            Console.ReadKey();
        }
    }
}
