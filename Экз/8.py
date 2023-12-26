def calc():
    expression = ""
    
    with open("input.txt", "r") as exprTxt:
        expression = exprTxt.readline()
        # expression = input("Введите выражение: ")
    arr = expression.split()
    
    num1 = int(arr[0])
    action = arr[1]
    num2 = int(arr[2])
    
    res = 0
    
    if (action == "+"):
        res = num1 + num2
    elif (action == "-"):
        res = num1 - num2
    elif (action == "*"):
        res = num1 * num2
    elif (action == "/"):
        try:
            res = num1 / num2
        except:
            res = "на ноль делить нельзя!"
            
    print(f"\nРезультат: {res}")
    
    with open("output.txt", "w") as outputTxt:
        outputTxt.write(f"Результат: {res}")


calc()

"""
while True:
    calc()
    
    stopNum = int(input("\nВведите 0 для остановки выполнения: "))
    print()
    
    if stopNum == 0:
        exit(0)
"""