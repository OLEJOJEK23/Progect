using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int password1, proverka, tasks;
            double health, armor, percent, damage, real_damage;
            int password = 1234;
            do
            {

                Console.WriteLine("Логин: Guest246");
                Console.Write("Пароль: ");
                password1 = int.Parse(Console.ReadLine());
                if (password == password1)
                {
                    Console.WriteLine("Вход выполнен");
                    break;
                }
                else
                {
                    i--;
                    Console.WriteLine($"Неверный пароль, осталось попыткок: {i}");
                }
            }   
            while (i!=0);
            if (i == 0)
                Environment.Exit(0);
            Console.WriteLine("Выберите уровень 1, 2, 3"); //уровень — это задания на оценку, то есть: удовлетворительно — 1, хорошо — 2, отлично — 3 
            Console.Write("Уровень: ");
            tasks = int.Parse(Console.ReadLine());
            switch(tasks)
            {
                case 1:
                    Console.Write("Health: ");
                    health = double.Parse(Console.ReadLine());
                    Console.Write("Armor: ");
                    armor = double.Parse(Console.ReadLine());
                    percent = armor / 4;
                    Console.Write("Damage: ");
                    damage = double.Parse(Console.ReadLine());
                    real_damage = damage * (1 - percent / 100);
                    Console.WriteLine(real_damage);
                    Console.WriteLine($"Health: {Math.Round((health - real_damage), 0)}");
                    Console.ReadKey();
                    break;
            }
            proverka = int.Parse(Console.ReadLine());
            Console.Write("aaaa");
            Console.ReadKey();
        }
    }
}
