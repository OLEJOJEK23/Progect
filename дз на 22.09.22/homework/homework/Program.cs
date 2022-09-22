using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание case, считывание переменной d
            double d = 0;
            Console.WriteLine("Введите: 1-для сложения 2-х чисел, 2-для вычитания 2-х чисел, 3-для умножения 2-х чисел, 4-для деления 2-х чисел");
            int c;
            c = int.Parse(Console.ReadLine());
            int caseSwitch = (int)c;
            //считывание переменных a и b
            double a, b;
            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = double.Parse(Console.ReadLine());
            //блок case со сложением, вычитанием, умножением и делением
            switch (caseSwitch)
            {
                case 1:
                    //вычисление
                    d = a + b;
                    Console.Write($"{a}+{b}=" + d);
                    //вывод данных
                    Console.ReadKey();
                    break;
                case 2:
                    //вычисление
                    d = a - b;
                    Console.Write($"{a}-{b}=" + d);
                    //вывод данных
                    Console.ReadKey();
                    break;
                case 3:
                    //вычисление
                    d = a * b;
                    Console.Write($"{a}*{b}=" + d);
                    //вывод данных
                    Console.ReadKey();
                    break;
                case 4:
                    //вычисление
                    d = a / b;
                    //перевод числа в строку
                    string d1 = d.ToString("F2");
                    Console.Write($"{a}/{b}=" + d1);
                    //вывод данных
                    Console.ReadKey();
                    break;
                    

            }
            
        }
    }
}
