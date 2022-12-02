using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехначное число");
            int x;
            String input = Console.ReadLine();
            int.TryParse(input, out x);
            int first = x / 100;
            int second = (x % 100) / 10;
            if (first < second)
                Console.WriteLine("Второе число больше");
            if (first > second)
                Console.WriteLine("Первое число больше");
            if (first == second)
                Console.WriteLine("Числа равны");
            Console.WriteLine("Для продолжения нажмите на любую клавишу . . . ");
            Console.ReadKey(true);
        }
    }
}
