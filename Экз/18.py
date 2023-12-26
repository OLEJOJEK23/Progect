def find_sum_indices(arr, target):
    for i in range(len(arr)):
        for j in range(i+1, len(arr)):
            if arr[i] + arr[j] == target:
                print(f"Индексы значений, дающих сумму {target}: {i}, {j}")
                return
    print("Не удалось найти значения, дающие заданную сумму.")

# Пример использования функции
arr = [1, 2, 3, 4, 5]
target = 9
find_sum_indices(arr, target)
