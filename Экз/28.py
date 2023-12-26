from random import randint
list = [[randint(1, 100) for i in range(5)] for j in range(5)]
sum = 0
for i in range(5):
    for j in range(5):
        print(list[i][j], end='\t')
        if i == j:
            if list[i][j] % 2 == 0:
                sum += list[i][j]
    print("")
print(sum)