using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    class Programs
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("While: ");
            while(i < 1000)
            {
                int a = i / 100; 
                int b = (i % 100) / 10; 
                int c = i % 10; 
                if ((a == b) || (a == c) || (b == c))
                    Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Do while: ");
            i = 100;
            do
            {
                int a = i / 100;
                int b = (i % 100) / 10;
                int c = i % 10;
                if ((a == b) || (a == c) || (b == c))
                    Console.Write(i + " ");
                i++;
            }
            while (i < 1000);
            Console.WriteLine();
            Console.WriteLine("For: ");
            for (i = 100; i < 1000; i++)
            {
                int a = i / 100; 
                int b = (i % 100) / 10; 
                int c = i % 10; 
                if ((a == b) || (a == c) || (b == c))
                      Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
