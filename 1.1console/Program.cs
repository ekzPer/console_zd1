using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("s= ");
            float s = float.Parse(Console.ReadLine());
            double r = Math.Sqrt(s / Math.PI);
            Console.WriteLine("r= Радиус окружности, длина которой равна единице составляет:{0:N4}", r);
            Console.WriteLine("Для продолжения нажмите на любую клавишу . . . ");
            Console.ReadKey(true);
        }
    }
}
