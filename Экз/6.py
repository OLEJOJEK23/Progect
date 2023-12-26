from random import randint
list = [[randint(1, 15) for i in range(5)] for j in range(10)]
sum2 = 0
for i in range(10):
    sum = 0
    for j in range(5):

        sum += list[i][j]
        print(list[i][j], end='\t')
    print(f"Среднаяя оценка: {sum / 5}")
    if sum > sum2:
        sum2 = sum
        max = i
print(f"Спортсмен с наивысшей оценкой под номером {max + 1}")