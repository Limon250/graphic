/*
    Developed by Limon250
    Date: 29.13.2020
*/
using System;
using System.Threading;

namespace graphics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some values from your equation:");
            Console.WriteLine("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            double c = Double.Parse(Console.ReadLine());

            //
            // нули функции
            //
            double D = ((b*b) - (4*a*c));
            Console.WriteLine("Дискриминант равен {0}", D);

            if (D == 0)
            {
                double x = (-b)/(2*a);
                Console.WriteLine("Нули функции: x1 = {0}", x);
            }
            else if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            else
            {
                double x1 = (((-b) + Math.Sqrt(D)) / (2 * a));
                double x2 = (((-b) - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("Нули функци: x1 = {0}, x2 = {1}", x1, x2);
            }

            //
            // таблица чисел для построения графика
            //
            double x0 = -3;
            double x_1 = -2;
            double x_2 = -1;
            double x3 = 0;
            double x4 = 1;
            double x5 = 2;
            double x6 = 3;
            Console.WriteLine("Для уравнения вида ax^2+bx+c");
            double y0 = a * (x0*x0) + (b * x0) + c;
            Console.WriteLine("x = {0}, y = {1}", x0, y0);
            double y1 = a * (x_1*x_1) + (b * x_1) + c;
            Console.WriteLine("x = {0}, y = {1}", x_1, y1);
            double y2 = a * (x_2*x_2) + (b * x_2) + c;
            Console.WriteLine("x = {0}, y = {1}", x_2, y2);
            double y3 = a * (x3*x3) + (b * x3) + c;
            Console.WriteLine("x = {0}, y = {1}", x3, y3);
            double y4 = a * (x4*x4) + (b * x4) + c;
            Console.WriteLine("x = {0}, y = {1}", x4, y4);
            double y5 = a * (x5*x5) + (b * x5) + c;
            Console.WriteLine("x = {0}, y = {1}", x5, y5);
            double y6 = a * (x6*x6) + (b * x6) + c;
            Console.WriteLine("x = {0}, y = {1}", x6, y6);

            Console.WriteLine("Для уравнения вида ax^2-bx+c");
            double y_0 = a * (x0*x0) - (b * x0) + c;
            Console.WriteLine("x = {0}, y = {1}", x0, y0);
            double y_1 = a * (x_1*x_1) - (b * x_1) + c;
            Console.WriteLine("x = {0}, y = {1}", x_1, y1);
            double y_2 = a * (x_2*x_2) - (b * x_2) + c;
            Console.WriteLine("x = {0}, y = {1}", x_2, y2);
            double y_3 = a * (x3*x3) - (b * x3) + c;
            Console.WriteLine("x = {0}, y = {1}", x3, y_3);
            double y_4 = a * (x4*x4) - (b * x4) + c;
            Console.WriteLine("x = {0}, y = {1}", x4, y_4);
            double y_5 = a * (x5*x5) - (b * x5) + c;
            Console.WriteLine("x = {0}, y = {1}", x5, y_5);
            double y_6 = a * (x6*x6) - (b * x6) + c;
            Console.WriteLine("x = {0}, y = {1}", x6, y_6);
        }
    }
}
