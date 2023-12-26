def create_test_file(questions):
    with open("test_questions.txt", "w") as file:
        for i, question in enumerate(questions):
            file.write(f"Вопрос {i + 1}: {question['question']}\n")
            for j, option in enumerate(question['options']):
                file.write(f"{chr(65 + j)}. {option}\n")
            file.write(f"Правильный ответ: {chr(65 + question['correct_answer_index'])}\n\n")

def run_test():
    student_name = input("Введите ФИО студента: ")
    student_group = input("Введите номер группы: ")

    with open("test_questions.txt", "r") as file:
        lines = file.readlines()
    print(lines)
    
    questions = []
    current_question = {}
    for line in lines:
        if line.startswith("Вопрос"):
            if current_question:
                questions.append(current_question)
            current_question = {"question": line[len("Вопрос") + 1:].strip(), "options": [], "correct_answer_index": None}
        elif line.startswith("Правильный ответ"):
            current_question["correct_answer_index"] = ord(line[-1]) - 65
        elif line.startswith("A.") or line.startswith("B.") or line.startswith("C.") or line.startswith("D."):
            current_question["options"].append(line[3:].strip())

    if current_question:
        questions.append(current_question)

    score = 0
    total_questions = len(questions)

    print("Ответьте на вопросы:")
    for question in questions:
        print(question["question"])
        for i, option in enumerate(question["options"]):
            print(f"{chr(65 + i)}. {option}")
        user_answer = input("Введите букву правильного ответа: ").upper()
        if user_answer == chr(65 + question["correct_answer_index"]):
            score += 1

    result = f"ФИО студента: {student_name}\nГруппа: {student_group}\nРезультат: {score} из {total_questions}\n"

    with open("result.txt", "a") as file:
        file.write(result)

# Пример использования
test_questions = [
    {
        "question": "Сколько будет 2 + 2?",
        "options": ["3", "4", "5", "6"],
        "correct_answer_index": 1
    },
    {
        "question": "Какой год был провозглашен Годом космонавтики?",
        "options": ["1957", "1961", "1969", "1975"],
        "correct_answer_index": 1
    }
]

create_test_file(test_questions)
run_test()
