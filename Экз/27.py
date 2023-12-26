def factorial(n):
    if n <= 1:
        return 1
    else:
        return n * factorial(n - 1)
print("Факториал числа равен:", factorial(int(input("Введите число: "))))