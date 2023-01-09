using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num3 = 1230;
            int a = 0;
            int b = 0;

            a = num3 % 100 / 10 + num3 % 10;
            b = num3 % 10000 / 1000 + num3 % 1000 / 100;
            if (a == b)
            {
                Console.WriteLine("good");
            }
            else
                Console.WriteLine("bad");
        }
    }
}