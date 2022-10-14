num1 = int(input("Введите первое число"))
num2 = int(input("Введите второе число"))
num3 = int(input("Введите третье число"))
min = num1
if min > num2:
    min = num2
if min > num3:
    min = num3
print('Наименьшее число:' + " " + str(min))