using System;
using System.Linq;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            string line1 = Console.ReadLine();
            int z = Convert.ToInt32(line1);
            string line2 = Console.ReadLine();
            string[] parts = line2.Split(new char[] { ' ', ',', '$' });
            int[] a = new int[z];
            for(int i = 0; i<parts.Length; ++i)
            {
                int x = int.Parse(parts[i]);
                if (IsPrime(x))
                {
                    k++;
                    a[i] = x;
                }
            }
            Console.WriteLine(k);
            int[] newArr = new int[a.Length];
            int c = 0;
            foreach (var v in a)
            {
                if (v != 0)
                {
                    newArr[c++] = v;
                }
            }
            a = newArr;
            for (int i = 0; i<k; ++i)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();

            bool IsPrime(int n)
            {
                if (n <= 1) return false;      // .. , -1, 0, 1
                if (n == 2) return true;        // 2
                if (n % 2 == 0) return false;    // 4, 6, 8, ...
                int sqrt = (int)Math.Sqrt(n); // largest possible factor        
                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
