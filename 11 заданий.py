command = int(input("Выберите задание: "))
if command == 1:
    print((101+0)/3)
    print(3.0e-6 * 10000000.1)
    print(True & True)
    print(False & True)
    print((False & False) or (True & True))
    print((False or False) & (True & True))
elif command == 2:
    print('Введите 4 целых числа')
    a = int(input())
    b = int(input())
    c = int(input())
    d = int(input())
    if a==b==c==d:
        print('ravno')
    else:
        print('ne ravno')
elif command == 3:
    x = []
    n = int(input("Введите количество чисел массива"))
    i = 0
    for i in range(n):
        a=int(input("Введите число "))
        x.append(a)
    print(max (x), '- max число ')
elif command == 4:
    x = []
    n = int(input("Введите количество чисел массива"))
    i = 0
    for i in range(n):
        a=int(input("Введите число "))
        x.append(a)
    print(min (x), '- min число ')
elif command == 5:
    x = []
    n = int(input("Введите количество чисел массива"))
    i = 0
    g = 0
    for i in range(n):
        a=int(input("Введите число "))
        x.append(a)
    sr = sum(x) / n
    for g in range(n):
        if (x[g]) > sr:
            print((x[g]), '- больше среднего ')
elif command == 6:
    a=int(input("Введите первый множитель"))
    b = int(input('Введите второй множитель'))
    c = a
    b = b-1
    for i in range(b):
        a = a+c
    print (str(a))
elif command == 7:
    x = []
    n = int(input("Введите количество чисел массива"))
    i = 0
    for i in range(n):
        a=int(input("Введите число "))
        if a % 2 == 0:
            x.insert(0, a)
        else:
            x.append(a)
    print(x)
elif command == 8:
    f = int(input('Введите градусы по Фаренгейту' + ' '))
    C = 5 / 9 * (f - 32)
    print('Градусы по Цельсию=' + str(round((C), 2)))
elif command == 9:
    Ves = int(input('Введите вес'))
    Rost = int(input('Введите рост'))
    print("ИМТ= ",Ves / ((Rost/100) ** 2))
elif command == 10:
    num = int(input("Введите число "))
    two = num ** 2
    three = num ** 3
    four = num ** 4
    print("Вторая степень:" + " " + str(two) + " " + "Третья степень:" + " " + str(three) + " " + "Четвертая степень" + " " + str(four))
elif command == 11:
    a = int(input("Введите первую сторону "))
    b = int(input("Введите вторую сторону "))
    c = int(input("Введите третью "))
    ab = a + b
    ac = a + c
    bc = b + c
    if c < ab and b < ac and a < bc:
        print("треугольник существует")
    else:
        print("треугольник не существует")
else:
    print("такого задания не было")