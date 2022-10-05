k=1     #ввод переменных
positive=0
negative=0
while k!=16:        #создание цикла со счётчиком
    number=float(input("Введите переменную: "))
    if number>0:        #сумма положительных
        positive+=number
    elif number<0:      #сумма отрицательных
        negative+=number
    k+=1
print("Сумма положительных чисел: ", positive)
print("Сумма отрицательных чисел: ", negative)