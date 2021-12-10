using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение длины окружности");
            Console.WriteLine();
            Circle.LineCircle();
            Console.WriteLine("Определение площади окружности");
            Console.WriteLine();
            Circle.PloshCircle();
            Console.WriteLine("Определение нахождения точки внутри окружности");
            Console.WriteLine();
            Circle.Paint();
            Console.ReadKey();
            
        }

    }

    static class Circle

    {              

        public static void LineCircle()
        {
            Console.WriteLine("Введите значения радиуса окружности");
             int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина окружности равна {0:f2}", (double)(2 * Math.PI * Math.Pow(r, 2)));
            Console.WriteLine();

        }
        public static void PloshCircle()
        {
            Console.WriteLine("Введите значения радиуса окружности");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь окружности равна {0:f2}", (double)( Math.PI * Math.Pow(r, 2)));
            Console.WriteLine();
        }

        public static void Paint()

        {
            Console.WriteLine("Введите введите координаты центра окружности");
            Console.Write("X0 ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y0 ");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения радиуса окружности");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  координаты точки");
            Console.Write("X1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1 ");
            int y1 = Convert.ToInt32(Console.ReadLine());

           
            if ((double)(Math.Sqrt(Math.Pow(x1-x0,2)+Math.Pow(y1-y0,2)))>r)
                Console.WriteLine("Точка вне окружности");
            else
            {
                Console.WriteLine("Точка внутри окружности");
            }

        }






    }
}
