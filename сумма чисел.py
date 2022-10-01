i=1
summpol = 0
summotr = 0
for i in range(15):
    print('Введите число')
    num = int(input())
    if num >= 0:
        summpol = summpol + num
    else:
        summotr = summotr + num
print ('Сумма положительных=' + str(summpol))
print ('Сумма отрицательных=' + str(summotr))