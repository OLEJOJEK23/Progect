task = int(input())
match(task):
    case 1:
        n = int(input())
        a = [[1] * n for i in range(n)]
        for i in range(n):
            for j in range(n):
                if n - i - 1 < j:
                    a[i][j] = 2
                elif n - j - 1 > i:
                    a[i][j] = 0
        for row in a:
            print(' '.join([str(elem) for elem in row]))
    case 2:
        n = int(input("Введите нечетное число: "))
        if n % 2 != 0:
            a = [["."] * n for i in range(n)]
            k = n // 2
            for i in range(n):
                for j in range(n):
                    if (i == j) or (i + j == n - 1):
                        a[i][j] = "*"
                    a[k][j] = "*"
                    a[i][k] = "*"
            for row in a:
                print(' '.join([str(elem) for elem in row]))
        else:
            print("НЕЧЕТНОЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
    case 3:
        n = int(input())
        a = [[0] * n for i in range(n)]
        for i in range(n):
            for j in range(n):
                if i < j:
                    a[i][j] = j - i
                if i > j:
                    a[i][j] = i - j
        for row in a:
            print(' '.join([str(elem) for elem in row]))