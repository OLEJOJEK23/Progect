# Создаем файл number.txt и записываем в него произвольный набор цифр
with open('number.txt', 'w') as file:
    numbers = [3, 8, 12, 54, 46, 265, 879, 76, 1, 5]
    file.write(' '.join(map(str, numbers)))

# Читаем числа из файла
with open('number.txt', 'r') as file:
    data = file.read()
    numbers = list(map(int, data.split()))

# Выполняем преобразования
numbers = [x + 1 if x % 2 == 0 else x for x in numbers]  # увеличить все четные числа на 1
print(numbers)
numbers = [round(x * 0.3) for x in numbers]  # умножить все значения на 0.3 и округлить до ближайшего целого
print(numbers)
numbers = [x for x in numbers if x >= 5]  # удалить все значения меньше 5
print(numbers)

# Записываем полученный результат в новый файл
with open('result.txt', 'w') as file:
    file.write(' '.join(map(str, numbers)))
