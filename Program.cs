using System;

namespace Nine_ninemultiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    var sum = i * j;
                    Console.Write($"{j}*{i}={sum}");
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
