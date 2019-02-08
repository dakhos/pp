using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineA = Console.ReadLine();//number of strings//
            int a = int.Parse(lineA);//integer a accepts value from input//
            for (int i = 1; i <= a; i++)
            {
                string s = new string('*', i);//number of * outputed in the line//
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
