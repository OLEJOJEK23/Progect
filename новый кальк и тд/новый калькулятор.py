a = 1
c = 1
while a != 0:
    deistvie1 = (input('введите действие("@"-квадратное уравнение "."-Для других действий):' + " "))#выбор действия
    if deistvie1 == '@':
        a = int(input('введите a:' + " "))
        b = int(input('введите b:' + " "))
        c = int(input('введите с:' + " "))
        dis = b ** 2 - 4 * c * a
        if dis >= 0:
            print("x1=" + str(round(((-b + dis ** (1 / 2)) / (2 * a)), 3)))
            print("x2=" + str(round(((-b - dis ** (1 / 2)) / (2 * a)), 3)))
        else:
            print('Дискриминант меньше 0')
    elif deistvie1 == ".":
        d = int(input('Введите первое число:' + ' '))
        while c != 0:
            deistvie = (input('введите действие("+"-сложение "-"-вычитание "*"-умножение "/"-деление):' + " "))
            if deistvie == '+':#сложение
                num1 = int(input('введите второе число:' + " "))
                d = d + num1
                print(str(d) + '+' + str(num1) + '=' + str(d))
            if deistvie == '-':#вычитание
                num1 = int(input('введите второе число:' + " "))
                d = d - num1
                print(str(d) + '-' + str(num1) + '=' + str(d))
            if deistvie == '*':#умножение
                num1 = int(input('введите второе число:' + " "))
                d = d * num1
                print(str(d) + '*' + str(num1) + '=' + str(d))
            if deistvie == '/':#деление
                num1 = int(input('введите второе число:' + " "))
                d = d / num1
                print(str(d) + '/' + str(num1) + '=' + str(round((d), 3)))
            c = int(input('Для завершения введите 0:' + ' '))
    a = int(input("Для завершения введите 0:"+" "))