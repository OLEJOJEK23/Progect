using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод переменных
            Console.WriteLine("Введите значения координат:");
            Console.Write("x1=");
            double x1, x2, y1, y2,distance;
            x1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = double.Parse(Console.ReadLine());
            //рассчёт расстояния между точками
            distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            //вывод результатов
            string distance1 = distance.ToString("F2");
            Console.WriteLine("расстояние:" + distance1);
            //вывод введённых данных
            Console.WriteLine("исходные данные:" + "x1=" + x1 + ", " + "x2=" + x2+ ", " + "y1=" + y1 + ", " + "y2=" + y2 + ", ");
            Console.ReadKey();
        }
    }
}
