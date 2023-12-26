sum = float(input("Введите сумму вклада: "))
disc = float(input("Введите процент вклада: "))
mes = int(input("Введите срок вклада в месяцах: "))
disc = disc / 100 + 1
for i in range(mes):
    sum *= disc
print(sum)