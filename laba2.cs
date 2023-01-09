using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;
            int k;
            double r = 0;

            do
            {
                Console.WriteLine("Write nn");
                nn = int.Parse(Console.ReadLine());
            }
            while (nn <= 0);

            do
            {
                Console.WriteLine("Write nk");
                nk = int.Parse(Console.ReadLine());
            }
            while (nk <= nn);

            for (k = nn; k < nk; k++)
            {
                r += Math.Pow(k, 2) - 3 / Math.Pow(-1, k) * Math.Pow(k, 2) + 5;
            }

            Console.WriteLine(r);
        }

    }
}