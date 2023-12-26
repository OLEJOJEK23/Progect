from random import randint

N = 100
a = []
b = []
for i in range(N):
    a.append(randint(1, 100))
    b.append(a[i])
print(a)

for i in range(N-1):
    for j in range(N-i-1):
        if a[j] > a[j+1]:
            a[j], a[j+1] = a[j+1], a[j]
        if b[j] < b[j+1]:
            b[j], b[j+1] = b[j+1], b[j]
print(a)
print(b)