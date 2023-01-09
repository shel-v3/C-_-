namespace LabWork7
{
    public static class Program
    {
        private static List<int> L;
        private static void Main()
        {
            L = new List<int>();
            List<int> NL = new List<int>
            {
                7,
                4,
                7,
                7,
                4,
                7,
                12,
                12,
                12
            };
            Duplicates(NL);

            int[] A = Array.Empty<int>();
            LA(L, A);
        }

        private static void Duplicates(List<int> IN)
        {
            int[] d = IN.Distinct().ToArray();
            for (int i = 0; i < d.Length; i++)
            {
                L.Add(0);
            }
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < IN.Count; j++)
                {
                    if (IN[j] == d[i])
                    {
                        L[i]++;
                    }
                }
            }
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i] + "=" + L[i]);
            }
        }

        private static void LA(List<int> IL, int[] IA)
        {
            IA = new int[IL.Count];
            int i = 0;

            for (int j = 0; j < IL.Count; j++)
            {
                int intNumber = IL[j];
                IA[i++] = intNumber;
            }

            for (int j = 0; j < IA.Length; j++)
            {
                int iN = IA[j];
                Console.WriteLine(iN);
            }
        }
    }
}