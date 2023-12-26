import random

# Заполняем массив случайными данными
salaries = [random.randint(1000, 5000) for _ in range(12)]

# Выводим данные на экран
print("Зарплаты сотрудника по месяцам:", salaries)

# Расчет общей суммы выплат за год
total_annual_salary = sum(salaries)
print("Общая сумма выплат за год:", total_annual_salary, "$")

# Расчет средней зарплаты за год
average_annual_salary = total_annual_salary / 12
print("Средняя зарплата за год:", average_annual_salary, "$")

# Расчет суммы отчислений в пенсионный фонд по месяцам и общей за год (2% от зарплаты)
pension_contributions = [salary * 0.02 for salary in salaries]
total_annual_pension_contributions = sum(pension_contributions)
print("Сумма отчислений в пенсионный фонд за год:", total_annual_pension_contributions, "$")

# Отображение отклонений зарплаты каждого месяца от средней зарплаты за год
deviations = [salary - average_annual_salary for salary in salaries]
print("Отклонения зарплаты каждого месяца от средней зарплаты за год:", deviations)

# Определение максимальной и минимальной зарплаты и номеров месяцев, когда они были получены
max_salary = max(salaries)
min_salary = min(salaries)
max_salary_month = salaries.index(max_salary) + 1
min_salary_month = salaries.index(min_salary) + 1
print("Максимальная зарплата:", max_salary, "$, получена в месяце", max_salary_month)
print("Минимальная зарплата:", min_salary, "$, получена в месяце", min_salary_month)
