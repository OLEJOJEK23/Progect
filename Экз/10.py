from random import randint
list = [[randint(2, 5) for i in range(5)] for j in range(25)]
sum2 = 0
maxPredmet = 0
minPredmet = 5
maxStud = 0
minStud = 5
for i in range(25):
    sum = 0
    for j in range(5):
        sum += list[i][j]
        print(list[i][j], end='\t')
    if maxStud < sum / 5:
        maxStud = sum / 5
    if minStud > sum / 5:
        minStud = sum / 5
    print(f"Средний балл студента: {sum / 5}")

for i in range(5):
    sum2 = 0
    for j in range(25):
        sum2 += list[j][i]
    if maxPredmet < sum2/25:
        maxPredmet = sum2 / 25
    if minPredmet > sum2/25:
        minPredmet = sum2 / 25
    print(f"Средний балл по предмету {i+1} = {sum2 / 25}")
print(f"Наивысший средний балл по предметам: {maxPredmet}")
print(f"Наименьший средний балл по предметам: {minPredmet}")
print(f"Наивысший средний балл студента: {maxStud}")
print(f"Наименьший средний балл студента: {minStud}")