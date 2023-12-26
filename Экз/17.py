import random

# Создаем двумерный массив 6x4 и заполняем его случайными числами от 20 до 50
array = [[random.randint(20, 50) for _ in range(4)] for _ in range(6)]

# Выводим массив на экран
print("Двумерный массив:")
for row in array:
    print(row)

# Находим и выводим сумму элементов в каждом столбце
column_sums = [sum(row[i] for row in array) for i in range(4)]
print("Сумма элементов в каждом столбце:", column_sums)

# Находим и выводим сумму элементов каждой строки
row_sums = [sum(row) for row in array]
print("Сумма элементов каждой строки:", row_sums)

# Находим сумму элементов в главной диагонали
diagonal_sum = sum(array[i][i] for i in range(6))
print("Сумма элементов в главной диагонали:", diagonal_sum)

# Функция для вычисления количества элементов в главной диагонали, которые меньше 10
def count_diagonal_elements_below_10(arr):
    count = sum(1 for i in range(6) if arr[i][i] < 10)
    return count

# Вызываем функцию и выводим результат
count_below_10 = count_diagonal_elements_below_10(array)
print("Количество элементов в главной диагонали, которые меньше 10:", count_below_10)
