using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            int[,] m = new int[a, b];
            int min = int.MaxValue;
            int max = int.MinValue;

            m[0, 0] = 2;
            m[0, 1] = 7;
            m[0, 2] = 5;
            m[1, 0] = 4;
            m[1, 1] = 7;
            m[1, 2] = 8;
            m[2, 0] = 0;
            m[2, 1] = 21;
            m[2, 2] = 3;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (min > m[i, j])
                    {
                        min = m[i, j];
                    }
                    if (max < m[i, j])
                    {
                        max = m[i, j];
                    }
                }
            }
            Console.WriteLine("min=" + min);
            Console.WriteLine();
            Console.WriteLine("max=" + max);
        }
    }
}
