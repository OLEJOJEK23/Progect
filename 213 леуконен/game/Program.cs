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
            double health, health2, armor, armor2, percent, percent2, damage, damage2, real_damage, real_damage2;
            int password = 1234;
            Random rand = new Random();
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
            while (i != 0);
            if (i == 0)
                Environment.Exit(0);
            Console.WriteLine("Выберите уровень 1, 2, 3"); //уровень — это задания на оценку, то есть: удовлетворительно — 1, хорошо — 2, отлично — 3 
            Console.Write("Уровень: ");
            tasks = int.Parse(Console.ReadLine());
            switch (tasks)
            {
                case 1:
                    Console.Write("Health: ");
                    health = double.Parse(Console.ReadLine());
                    Console.Write("Armor: ");
                    armor = double.Parse(Console.ReadLine());
                    percent = armor / 4;
                    Console.Write($"Damage: ");
                    damage = rand.Next(1, 100);
                    Console.WriteLine(damage);
                    real_damage = damage * (1 - percent / 100);
                    Console.WriteLine($"Health: {Math.Round((health - real_damage), 0)}");
                    Console.ReadKey();
                    break;
                case 2:
                    health = rand.Next(1, 100);
                    Console.WriteLine($"The health of the first gladiator: {health}");
                    health2 = rand.Next(1, 100);
                    Console.WriteLine($"The health of the second gladiator: {health2}");
                    armor = rand.Next(1, 100);
                    Console.WriteLine($"The armor of the first gladiator: {armor}");
                    armor2 = rand.Next(1, 100);
                    Console.WriteLine($"The armor of the second gladiator: {armor2}");
                    damage = rand.Next(1, 100);
                    Console.WriteLine($"Damage on the first gladiator: {damage}");
                    damage2 = rand.Next(1, 100);
                    Console.WriteLine($"Damage on the second gladiator: {damage2}");
                    percent = armor / 4;
                    percent2 = armor2 / 4;
                    real_damage = damage * (1 - percent / 100);
                    real_damage2 = damage2 * (1 - percent2 / 100);
                    Console.WriteLine($"The health of the first gladiator: {Math.Round((health - real_damage), 0)}");
                    Console.WriteLine($"The health of the second gladiator: {Math.Round((health2 - real_damage2), 0)}");
                    break;
            }
            proverka = int.Parse(Console.ReadLine());
            Console.Write("aaaa");
            Console.ReadKey();
        }
    }
}