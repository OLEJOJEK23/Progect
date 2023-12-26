#Билет N2

from random import randint
from colorama import Fore
list = [randint(7, 70) for i in range(31)]
k = 0
print(list)
print("Максимальная цена юаня: ", max(list))
print("Минимальная цена юаня: ", min(list))
rubles = int(input("Введите рубли: "))
print(f"{round(rubles / min(list), 2)} юаней по самому выгодному курсу")
average = sum(list) / 31
for i in range(31):
    if list[i] > average:
        print(Fore.RED + f"Курс в {i + 1} день больше среднего на {round(list[i] - average, 2)}")
        k += 1
    if list[i] < average:
        print(Fore.GREEN + f"Курс в {i + 1} день меньше среднего на {round(average - list[i], 2)}")
print(Fore.LIGHTWHITE_EX + f"Дней, когда курс был больше среднего: {k}")

