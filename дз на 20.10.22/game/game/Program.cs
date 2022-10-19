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
        {                       // ввод переменных
            int i = 3;
            int k = 0;
            int password, tasks;
            double health, health2, armor, armor2, percent, percent2, damage, damage2, real_damage, real_damage2;
            int real_password = 1234;
            Random rand = new Random();
            do                              // создание пароля для входа в игру с 3 попытками ввода
            {

                Console.WriteLine("Логин: Guest246");
                Console.Write("Пароль: ");
                password = int.Parse(Console.ReadLine());
                if (real_password == password)
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
                Environment.Exit(0);                // выход из программы
            Console.WriteLine("Выберите уровень 1, 2, 3"); // уровень — это задания на оценку, то есть: удовлетворительно — 1, хорошо — 2, отлично — 3 
            Console.Write("Уровень: ");
            tasks = int.Parse(Console.ReadLine());      // создание уровней
            switch (tasks)
            {
                case 1:                                // задание на 3
                    Console.Write("HP гладиатора: ");
                    health = double.Parse(Console.ReadLine());
                    if (health > 100 || health <= 0)            // проверка на то, чтобы хп были в диапазоне от 1 до 100
                    {
                        Console.WriteLine("Некорректное значение, HP может быть только от 1 до 100");
                        Environment.Exit(0);                    // выход из программы
                    }
                    Console.Write("Броня гладиатора: ");
                    armor = double.Parse(Console.ReadLine());
                    if (armor > 100 || armor <= 0)              // проверка на то, чтобы броня была в диапазоне от 1 до 100
                    {
                        Console.WriteLine("Некорректное значение, броня может быть только от 1 до 100");
                        Environment.Exit(0);                    // выход из программы
                    }
                    percent = armor / 4;                        // 25 процентов от числа
                    damage = rand.Next(1, 100);
                    real_damage = damage * (1 - percent / 100); // формула поглощения урона бронёй
                    Console.WriteLine($"Урон по гладиатору: {Math.Round(real_damage, 0)}");
                    if (health < real_damage)                   // проверка хп на то, чтобы хп было больше 0
                        Console.WriteLine("HP гладиатора: 0");
                    else
                        Console.WriteLine($"HP гладиатора: {Math.Round(health - real_damage, 0)}"); // округление хп
                    break;
                case 2:                                             // задание на 4
                    health = rand.Next(1, 100);
                    Console.WriteLine($"HP первого гладиатора: {health}");      // случайные числа от 1 до 100
                    health2 = rand.Next(1, 100);
                    Console.WriteLine($"HP второго гладиатора: {health2}");
                    armor = rand.Next(1, 100);
                    Console.WriteLine($"Броня первого гладиатора: {armor}");
                    armor2 = rand.Next(1, 100);
                    Console.WriteLine($"Броня второго гладиатора: {armor2}");
                    damage = rand.Next(1, 100);
                    percent = armor / 4;                                    // 25 процентов от числа 
                    real_damage = damage * (1 - percent / 100);             // формула поглощения урона бронёй
                    health = health - real_damage;
                    Console.WriteLine($"Урон по первому гладиатору: {Math.Round(real_damage, 0)}");         // округление урона
                    damage2 = rand.Next(1, 100);
                    percent2 = armor2 / 4;
                    real_damage2 = damage2 * (1 - percent2 / 100);
                    health2 = health2 - real_damage2;
                    Console.WriteLine($"Урон по второму гладиатору: {Math.Round(real_damage2, 0)}");                // вывод хп первого и второго гладиаторов с условиями
                    if (health > 0 && health2 > 0)
                    {
                        Console.WriteLine($"Оба гладиатора выжили, у первого гладиатора осталось {Math.Round(health, 0)} HP, у второго гладиатора осталось {Math.Round(health2, 0)} HP");
                        break;
                    }
                    if (health > 0 && health > health2)
                        Console.WriteLine($"Победил первый гладиатор, у него осталось {Math.Round(health, 0)} HP");
                    else if (health2 > 0 && health2 > health)
                        Console.WriteLine($"Победил второй гладиатор, у него осталось {Math.Round(health2, 0)} HP");
                    else
                        Console.WriteLine($"Оба гладиатора пали");
                    break;
                case 3:                         // задание на 5
                    health = rand.Next(1, 100);
                    Console.WriteLine($"HP первого гладиатора: {health}");          //случайные числа от 1 до 100
                    health2 = rand.Next(1, 100);
                    Console.WriteLine($"HP второго гладиатора: {health2}");
                    armor = rand.Next(1, 100);
                    Console.WriteLine($"Броня первого гладиатора: {armor}");
                    armor2 = rand.Next(1, 100);
                    Console.WriteLine($"Броня второго гладиатора: {armor2}");
                    percent = armor / 4;                                // 25 процентов от числа
                    percent2 = armor2 / 4;
                    while (health > 0 && health2 > 0)                      // цикл получения урона
                    {
                        damage = rand.Next(1, 100);
                        damage2 = rand.Next(1, 100);
                        real_damage = damage * (1 - percent / 100);             // формула полгощения урона бронёй
                        real_damage2 = damage2 * (1 - percent2 / 100);
                        k++;
                        health = health - real_damage;              // хп первого и второго гладиаторов после получения урона
                        health2 = health2 - real_damage2;
                    }
                    if (health > 0 && health > health2)                                                             // вывод хп первого и второго гладиаторов с условиями
                        Console.WriteLine($"Победил первый гладиатор, совершив серий ударов: {k}, у него осталось {Math.Round(health, 0)} HP");
                    else if (health2 > 0 && health2 > health)
                        Console.WriteLine($"Победил второй гладиатор, совершив серий ударов: {k}, у него осталось {Math.Round(health2, 0)} HP");
                    else
                        Console.WriteLine($"Оба гладиатора пали, совершив серий ударов: {k}");
                    break;
            }
        }
    }
}