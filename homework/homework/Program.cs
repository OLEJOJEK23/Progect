using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //считывание переменных
            double d = 0;
            Console.WriteLine("Введите: 1-для сложения 2-х чисел, 2-для вычитания 2-х чисел, 3-для умножения 2-х чисел, 4-для деления 2-х чисел ");
            int c;
            c = int.Parse(Console.ReadLine());
            int caseSwitch = (int)c;
            int a, b;
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    d = a + b;
                    Console.Write("a+b=" + d);
                    Console.ReadLine();
                    break;
                case 2:
                    d = a - b;
                    Console.Write("a-b=" + d);
                    Console.ReadLine();
                    break;
                case 3:
                    d = a * b;
                    Console.Write("a*b=" + d);
                    Console.ReadLine();
                    break;
                case 4:
                    d = a / b;
                    Console.Write("a/b=" + d);
                    Console.ReadLine();
                    break;
                    

            }
            
        }
    }
}
