using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Назва ЛР: Структура консольного додатку C#");
            Console.WriteLine("Виконав: Маковський Максим Вiталiйович");
            Console.WriteLine("Група: ЕС-134Б, 171");
            Console.WriteLine("");
            double p = 3.14159;
            double x = 0.25;
            double y = Math.Sin(Math.Log(x + 2)) - Math.Cos(p * Math.Log(x + (5.0 / 3))) + x / 5.0;
            Console.WriteLine("x={0} \t y={1}", x, y);
            Console.WriteLine("");
            Console.WriteLine("Для завершення роботи програми натиснiть будь-яку клавiшу...");

            Console.ReadKey();
        }
    }
}
