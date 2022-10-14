n = int(input('Введите количество чисел'))
sum = 0
a = 1
for i in range(n):
    sum = a + sum
    a = a + 1
print(str(sum))