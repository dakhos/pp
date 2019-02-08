using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();//first number input//
            string line2 = Console.ReadLine();//second numbers input//
            string[] parts = line2.Split(new char[] { ' ', ',', '$' });//split the second line//
            int[] b = new int[200];//new array that will be outputed//
            for (int i = 0; i < parts.Length; ++i)
            {
                int x = int.Parse(parts[i]);//x accepts the number from parts[i]//
                b[i * 2] = x;//the next lines are doubling the new array - each 2 elements keep the same x//
                b[i * 2 + 1] = x;
            }
            for (int i = 0; i < (parts.Length * 2); ++i)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
        }
    }
}
