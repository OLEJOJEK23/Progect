from colorama import Fore
from random import randint
height = int(input("Введите высоту елки: "))
tab = height
space = " "
star = "*"
for i in range(height):
    stroka = space * tab + star * (i + i + 1)
    tab -= 1
    listStroka = list(stroka)
    for item in range(len(listStroka)):
        if randint(0, 3) == 3 and listStroka[item] == "*":
            listStroka[item] = Fore.BLUE + "*"
        elif (randint(0, 3) == 0 or randint(0, 3) == 1 or randint(0, 3) == 2) and listStroka[item] == "*":
            listStroka[item] = Fore.GREEN + "*"
    print("".join(listStroka))