using System;

namespace Тестовый
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запишите значение а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Запишите значение r");
            int r = int.Parse(Console.ReadLine());
            int s;
            s = a * 8 + r;
            int q;
            q = a * s;
            Console.WriteLine("Ответ:" + s) ;
            Console.WriteLine("Ответ2:" + q);
            Console.ReadKey();
        }
    }
}
