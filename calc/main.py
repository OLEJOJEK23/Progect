abc=1
while abc!=0:
    print("Введите: '-' для вычитания 2-ух переменных")
    print("Введите: '+' для сложения 2-ух переменных")
    print("Введите: '*' для умножения 2-ух переменных")
    print("Введите: '/' для деления 2-ух переменных")
    print("Введите: 'x' для решения квадратного уравнения")
    vibor=input()
    if vibor=='x':
        print('Введите первый коэффицент')
        a=int(input())
        print('Введите второй коэффицент')
        b=int(input())
        print('Введите третий коэффицент')
        c=int(input())
        D=b**2-4*a*c
        if D<0:
            print("Корней нет")
        else:
            print("x1=" + str(round((-b+D**0.5)/(2*a), 2)) + " " + "x2=" + str(round((-b-D**0.5)/(2*a), 2)))
    if vibor=='-':
        print("Введите первую переменную")
        a = float(input())
        print("Введите вторую переменную")
        b = float(input())
        print(str(a) + "-" + str(b) + "=" + str(round((a-b), 3)))
    if vibor=='+':
        print("Введите первую переменную")
        a = float(input())
        print("Введите вторую переменную")
        b = float(input())
        print(str(a) + "+" + str(b) + "=" + str(a+b))
    if vibor=='*':
        print("Введите первую переменную")
        a = float(input())
        print("Введите вторую переменную")
        b = float(input())
        print(str(a) + "*" + str(b) + "=" + str(a*b))
    if vibor=='/':
        print("Введите первую переменную")
        a = float(input())
        print("Введите вторую переменную")
        b = float(input())
        print(str(a) + "/" + str(b) + "=" + str(round((a/b), 2)))
    print("Для выхода из программы введите 0, для продолжения любую другую цифру")
    abc=int(input())