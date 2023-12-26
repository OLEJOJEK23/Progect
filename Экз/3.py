class BankAccount:
    def __init__(self, account_number, owner_name, balance=0):
        self.account_number = account_number
        self.owner_name = owner_name
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount

    def withdraw(self, amount):
        if amount <= self.balance:
            self.balance -= amount
        else:
            print("Недостаточно средств на счету")

    def get_balance(self):
        return self.balance

    def transfer(self, recipient_account, amount):
        if amount <= self.balance:
            self.balance -= amount
            recipient_account.deposit(amount)
        else:
            print("Недостаточно средств на счету")

# Создаем объект класса BankAccount
account1 = BankAccount("1234567890", "Иванов Иван Иванович", 1000)

# Меню для пользователя
while True:
    print("\nМеню:")
    print("1. Положить на счет")
    print("2. Снять со счета")
    print("3. Узнать баланс")
    print("4. Перевести на другой счет")
    print("5. Выйти")

    choice = input("Выберите действие: ")

    if choice == "1":
        amount = float(input("Введите сумму для пополнения: "))
        account1.deposit(amount)
        print("Операция выполнена успешно")

    elif choice == "2":
        amount = float(input("Введите сумму для снятия: "))
        account1.withdraw(amount)
        print("Операция выполнена успешно")

    elif choice == "3":
        print("Баланс на счету:", account1.get_balance())

    elif choice == "4":
        recipient_account = BankAccount("0987654321", "Петров Петр Петрович", 0)
        amount = float(input("Введите сумму для перевода: "))
        account1.transfer(recipient_account, amount)
        print("Операция выполнена успешно")

    elif choice == "5":
        break

# Записываем исходные и результирующие данные в файл
with open("bank_account_log.txt", "w") as file:
    file.write("Исходные данные:\n")
    file.write(f"Номер счета: {account1.account_number}\n")
    file.write(f"ФИО владельца: {account1.owner_name}\n")
    file.write(f"Сумма на счету: {account1.balance}\n\n")

    file.write("Результирующие данные:\n")
    file.write(f"Номер счета: {account1.account_number}\n")
    file.write(f"ФИО владельца: {account1.owner_name}\n")
    file.write(f"Сумма на счету: {account1.balance}\n")
