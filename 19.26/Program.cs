namespace _19._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 9 };
            List<int> b = new List<int> { 4, 8, 12, 6, 3, 87, 345, 1 };
            stampa(a);
            stampa(b);

            List<int> c = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    if (a[i] == b[j])
                    {
                        c.Add(a[i]);
                    }
                }
            }
            stampa(c);



            static void stampa(List<int> lista)
            {
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}
