using System;
using BaseDaAulaGenerics.Service;
namespace BaseDaAulaGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>(); 
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.addValue(x);
            }

            printService.print();
            Console.WriteLine();
            Console.WriteLine("First: " + printService.first());

        }
    }
}
