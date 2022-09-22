using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ввод переменных
            double cost, percent, price;
            int k;
            Console.WriteLine("Введите стоимость одного товара:");
            Console.Write("стоимость=");
            cost = double.Parse(Console.ReadLine());
            Console.Write("скидка=");
            percent = double.Parse(Console.ReadLine());
            Console.Write("количество=");
            k=int.Parse(Console.ReadLine());
            //рассчёт стоимости
            price =(cost*(100-percent)/100*k);
            //вывод результатов
            string price1 = price.ToString("C2");
            Console.WriteLine("цена:" + price1);
            Console.ReadKey();
            
        }
    }
}
