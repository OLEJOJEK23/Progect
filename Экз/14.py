def search_and_replace(input_string, search_fragment, replacement_fragment):
    if search_fragment in input_string:
        corrected_string = input_string.replace(search_fragment, replacement_fragment, 1)
        print("Откорректированная строка:", corrected_string)
        with open('output.txt', 'w') as file:
            file.write(corrected_string)
    else:
        print("Искомый фрагмент не найден в исходной строке.")

def main():
    while True:
        input_string = input("Введите исходную строку: ")
        search_fragment = input("Введите фрагмент для поиска: ")
        replacement_fragment = input("Введите фрагмент для замены: ")
        search_and_replace(input_string, search_fragment, replacement_fragment)
        choice = input("Хотите ввести новую строку? (yes/no): ")
        if choice.lower() != 'yes':
            break

if __name__ == "__main__":
    main()
