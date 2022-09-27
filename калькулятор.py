print('введите действие("+"-сложение "-"-вычитание "*"-умножение "/"-деление "@"-квадратное уравнение')
deistvie = (input())#выбор действия
if deistvie == '@':
    print('введите а')#ввод переменных для квадратного уравнения
    a = int(input())
    print('введите b')
    b = int(input())
    print('введите с')
    c = int(input())
    dis = b ** 2 - 4 * c * a#решение квадратного уравнения
    x1 = (-b + dis ** (1 / 2)) / (2 * a)
    print("x1=" + str(x1))
    x2 = (-b - dis ** (1 / 2)) / (2 * a)
    print("x2=" + str(x2))
    exit()
print('введите первое число')#ввод переменных не для квадратного уравнения
num1 = int(input())
print('ввведите второе число')
num2 = int(input())
if deistvie == '+':#сложение
    d = num1 + num2
    print(str(num1) + '+' + str(num2) + '=' + str(d))
if deistvie == '-':#вычитание
    d = num1 - num2
    print(str(num1) + '-' + str(num2) + '=' + str(d))
if deistvie == '*':#умножение
    d = num1 * num2
    print(str(num1) + '*' + str(num2) + '=' + str(d))
if deistvie == '/':#деление
    d = num1 / num2
    print(str(num1) + '/' + str(num2) + '=' + str(d))


