abc = 1
while abc != 0:
    print("Введите: '-' для вычитания 2-ух переменных")
    print("Введите: '+' для сложения 2-ух переменных")
    print("Введите: '*' для умножения 2-ух переменных")
    print("Введите: '/' для деления 2-ух переменных")
    print("Введите: 'x' для решения квадратного уравнения")
    print("Введите: '^' для возведения числа в любую степень")
    def quadratic():
        a = float(input("Введите первый коэффицент: "))
        b = float(input("Введите второй коэффицент: "))
        c = float(input("Введите третий коэффицент: "))
        D = b ** 2 - 4 * a * c
        if D < 0:
            print("Корней нет")
        else:
            print("x1=" + str(round((-b + D ** 0.5) / (2 * a), 2)) + " " + "x2=" + str(round((-b - D ** 0.5) / (2 * a), 2)))
    def minus():
        a = float(input("Введите первую переменную: "))
        b = float(input("Введите вторую переменную: "))
        print(str(a) + "-" + str(b) + "=" + str(round((a - b), 3)))
    def plus():
        a = float(input("Введите первую переменную: "))
        b = float(input("Введите вторую переменную: "))
        print(str(a) + "+" + str(b) + "=" + str(a + b))
    def multiplication():
        a = float(input("Введите первую переменную: "))
        b = float(input("Введите вторую переменную: "))
        print(str(a) + "*" + str(b) + "=" + str(a * b))
    def division():
        a = float(input("Введите первую переменную: "))
        b = float(input("Введите вторую переменную: "))
        print(str(a) + "/" + str(b) + "=" + str(round((a / b), 2)))
    def involution():
        a = float(input("Введите число: "))
        b = float(input("Введите степень, в которую хотите возвести: "))
        print(str(a) + "^" + str(b) + "=" + str(round((a ** b), 2)))
    operation = ["-", "+", "*", "/", "x", "^"]
    choice = input()
    if choice == operation[4]:
        quadratic()
    if choice == operation[0]:
        minus()
    if choice == operation[1]:
        plus()
    if choice == operation[2]:
        multiplication()
    if choice == operation[3]:
        division()
    if choice == operation[5]:
        involution()
    print("Для выхода из программы введите 0, для продолжения любую другую цифру")
    abc = int(input())
