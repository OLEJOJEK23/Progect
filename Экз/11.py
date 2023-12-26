from random import randint


rndNum = -1     # загаданное число
userNum = -1    # число пользователя


def guessTheNum():
    userNum = int(input("Введите число от 1 до 10: "))
    
    if userNum == rndNum:
        print("Вы угадали!")
    else:
        print("Вы не угадали\n")
        guessTheNum()   # рекурсия
    
    
def randomizeTheNum():
    global rndNum
    rndNum = randint(1, 10)
    print("-----" + str(rndNum) + "-----")

while True:
    randomizeTheNum()
    guessTheNum()
    
    if int(input("\nВведите 0 для выхода из программы: ")) == 0:
        exit()