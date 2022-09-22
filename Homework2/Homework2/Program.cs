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
            double stoim, proc, cena;
            int k;
            Console.WriteLine("Введите стоимость одного товара:");
            Console.Write("стоимость=");
            stoim = double.Parse(Console.ReadLine());
            Console.Write("скидка=");
            proc = double.Parse(Console.ReadLine());
            Console.Write("количество=");
            k=int.Parse(Console.ReadLine());
            //рассчёт стоимости
            cena =(stoim*(100-proc)/100*k);
            //вывод результатов
            Console.WriteLine("цена:" + cena);
            Console.WriteLine("первоначальные данные:" + stoim + "руб." + proc + "%" + k + "шт.");
            Console.ReadLine();
            
        }
    }
}
