import json

# Функция для чтения пользователей из файла
def read_users_from_file(filename):
    with open(filename, 'r') as file:
        users = json.load(file)
        for user in users:
            print(user)

# Функция для добавления нового пользователя в файл
def add_user_to_file(filename, user):
    with open(filename, 'r') as file:
        data = json.load(file)
        data.append(user)
    with open(filename, 'w') as file:
        json.dump(data, file, indent=4)

# Функция для удаления пользователя из файла
def remove_user_from_file(filename, user):
    with open(filename, 'r') as file:
        data = json.load(file)
        data = [x for x in data if x != user]
    with open(filename, 'w') as file:
        json.dump(data, file, indent=4)

# Функция для обновления дня рождения у определенного пользователя
def update_birthday(filename, firstname, lastname, new_birthday):
    with open(filename, 'r') as file:
        data = json.load(file)
        for user in data:
            if user['firstname'] == firstname and user['lastname'] == lastname:
                user['birthday'] = new_birthday
    with open(filename, 'w') as file:
        json.dump(data, file, indent=4)

# Пример использования функций
filename = 'users.json'

# Вывод всех пользователей на экран
print("Список пользователей:")
read_users_from_file(filename)

# Добавление нового пользователя
new_user = {'firstname': 'Иван', 'lastname': 'Иванов', 'birthday': '1990-01-01'}
add_user_to_file(filename, new_user)

# Удаление пользователя
user_to_remove = {'firstname': 'Петр', 'lastname': 'Петров', 'birthday': '1985-05-05'}
remove_user_from_file(filename, user_to_remove)

# Обновление дня рождения у определенного пользователя
update_birthday(filename, 'Мария', 'Сидорова', '1992-12-12')
