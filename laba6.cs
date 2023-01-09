using System;
using System.Collections.Generic;
using System.Linq;

namespace LabWork6
{
    public static class Program
    {
        static void Main()
        {
            //One();
            //Two();
            //Three();
            //Four();
            //Five();
            //Seven();
            //Eight();
        }

        static void One(string[] args)
        {

            Console.WriteLine("int= ");
            int a = int.Parse(Console.ReadLine());
            int r = 0;
            while (a != 0)
            {
                r += a % 10;
                a /= 10;
            }
            Console.WriteLine(r);
        }

        static void Two()
        {
            string a = "ABN";
            string r = "";
            for (int i = a.Length - 1; i > -1; i--)
            {
                r += a[i];
            }
            Console.WriteLine(r);
        }

        static void Three()
        {
            double a = 123.45;
            string[] array = a.ToString().Split(',');
            string r = "";

            int b;

            for (int j = 0; j < array.Length; j++)
            {
                b = int.Parse(array[j]);
                while (b != 0)
                {
                    r += b % 10;
                    b /= 10;
                }

                r += ",";
            }
            Console.WriteLine(r);

        }
        static void Four()
        {
            string a = "123.45";
            char d = '.';
            string[] array = a.Split(d);
            string r = "";
            for (int i = 0; i < array.Length; i++)
            {
                string s = array[i];
                string rr = string.Empty;
                for (int j = s.Length - 1; j > -1; j--)
                {
                    rr += s[j];
                }

                r += rr + d;
            }

            Console.WriteLine(r);
        }

        static void Five()
        {
            string[] array = new[]
            {
                "heya",
                "brsafasa",
                "afasdf",
                "hrdgfmk"
            };
            var array2 = array.Reverse();
            foreach (var a in array2)
            {
                Console.WriteLine(a);
            }
        }

        static void Seven()
        {
            string[] array = new[]
            {
                "heya",
                "brsafasa",
                "afasdf",
                "hrdgfmk"
            };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Eight()
        {
            int[] mas = new[]
            {
                1,
                2,
                3,
                4
            };
            Console.WriteLine("Array=" + mas.Length);
            Array.Resize(ref mas, 2);
            Console.WriteLine("Array=" + mas.Length);
        }
    }
}