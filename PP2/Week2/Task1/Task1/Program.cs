using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string a = Console.ReadLine();//input string//
            for (int i = 0; i<(a.Length/2); ++i)//next lines check the first half of the word with the rest//
            {
                if (a[i] == a[a.Length - i-1])//if the letter is not the same with the reverse letter n will increase//
                {
                }
                else
                {
                    n++;
                }
            }
            if (n > 0)//if there is at least 1 case of letters being not the same the word is not a palindrome and vise-versa//
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            Console.ReadKey();
        }
    }
}
