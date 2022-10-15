def minimum():
    a = int(input("Введите первое число: "))
    b = int(input("Введите второе число: "))
    c = int(input("Введите третье число: "))
    if a < b and a < c:
        print("Минимум:", a)
    elif b < c and b < a:
        print("Минимум:", b)
    else:
        print("Минимум:", c)
def amount():
    amount = 0
    number = int(input("Введите число: "))
    real_number = abs(number)
    while real_number > 0:
        real_number = real_number // 10
        amount = amount + 1
    print("Количество цифр в числе:", amount)
def sum():
    sum = 0
    amount = int(input("Введите количество чисел: "))
    for i in range(amount):
        number = int(input("Введите число: "))
        sum = number + sum
    print("Сумма:", sum)
def factorial():
    n = 1
    number = int(input("Введите число, факториал которого хотите узнать: "))
    for i in range(1, number + 1):
        n = n * i
    print("Факториал:", n)
print("Введите: '1' для нахождения минимума трёх чисел")
print("Введите: '2' для нахождения количества цифр в числе")
print("Введите: '3' для нахождения суммы N чисел")
print("Введите: '4' для нахождения факториала числа")
choice = int(input())
if choice == 1:
    minimum()
if choice == 2:
    amount()
if choice == 3:
    sum()
if choice == 4:
    factorial()
