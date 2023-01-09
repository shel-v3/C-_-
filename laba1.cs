using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 3.14f;
            double g = 9.8f;
            double l;
            double T;
            Console.WriteLine("Write l");
            l = double.Parse(Console.ReadLine());

            T = 2 * P * Math.Sqrt(l / g);
            Console.WriteLine("T=" + T);
        }
    }
}