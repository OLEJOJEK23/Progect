num=int(input('Введите число:' + " "))
kol = 0
while num != 0:
    num = num // 10
    kol = kol + 1
print('Количество цифр:' + ' ' + str(kol))