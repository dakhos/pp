using System;

namespace Task2
{
    class Student
    {
        static void Main(string[] args)
        {
            int id = 1;
            string[] arrn = new string[200];//to store info//
            int[] arry = new int[200];
            int n = Convert.ToInt32(Console.ReadLine());//number of students input//
            for (int i = 0; i < n; ++i)
            {
                arrn[i] = Console.ReadLine();
                int x = Convert.ToInt32(Console.ReadLine());
                arry[i] = x;//inputting the data//
            }
            for (int i = 0; i < n; i++)//outputting the data//
            {
                Console.WriteLine("id " + id);
                Console.WriteLine("name " + arrn[i]);
                Console.WriteLine("year " + arry[i]);
                id++;
            }
            Console.ReadKey();
        }
    }
}
