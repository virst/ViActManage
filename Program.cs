using System;

namespace ViActManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                ActManager.Retry(() =>
                {
                    Console.Write("*");
                    int n = i - 5;
                    Console.Write(Math.Round((double)(4 / n)));
                });
                Console.WriteLine();
            }

        }
    }
}
