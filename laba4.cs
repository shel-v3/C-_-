using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 4;
            int[] array;
            array = new int[N];
            array[0] = 1;
            array[1] = 3;
            array[2] = 2;
            array[3] = 1;
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}