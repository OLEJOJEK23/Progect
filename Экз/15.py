import random

# Имеющиеся данные измерений температуры
temperature_data = [random.randint(20, 35) for _ in range(31)]
# Вывод данных на экран
print("Измерения температуры воздуха в течение месяца:", temperature_data)

# Расчет средней температуры за месяц
average_temperature = sum(temperature_data) / len(temperature_data)
print("Средняя температура за месяц:", average_temperature)

# Максимальная и минимальная температура за месяц
max_temperature = max(temperature_data)
min_temperature = min(temperature_data)
print("Максимальная температура за месяц:", max_temperature)
print("Минимальная температура за месяц:", min_temperature)

# Отклонения от средней температуры за месяц
deviations = [temp - average_temperature for temp in temperature_data]
print("Отклонения от средней температуры за месяц:", deviations)

# Запись полученных данных в текстовый файл
with open('temperature_analysis.txt', 'w') as file:
    file.write("Измерения температуры воздуха в течение месяца: " + str(temperature_data) + "\n")
    file.write("Средняя температура за месяц: " + str(average_temperature) + "\n")
    file.write("Максимальная температура за месяц: " + str(max_temperature) + "\n")
    file.write("Минимальная температура за месяц: " + str(min_temperature) + "\n")
    file.write("Отклонения от средней температуры за месяц: " + str(deviations) + "\n")

