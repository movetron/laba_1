using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 + 2 будет?");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Будет {0}", c);
            Console.ReadLine();
            
        }
    }
}
