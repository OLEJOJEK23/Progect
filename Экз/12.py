Zodiac_ru = ["Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец"]

Zodiac_dates = [20.01, 18.02, 20.03, 20.04, 20.05, 21.06, 22.07, 23.08, 23.09, 23.10, 22.11, 21.12]

# китайские знаки
# AnimalyearСhina = ["Крысы", "Быка", "Тигра", "Кролика", "Дракона", "Змеи", "Лошади", "Овцы", "Обезьяны", "Петуха", "Собаки", "Свиньи"]

months =  {
    'янв': 1,
    'фев': 2,
    'март': 3,
    'апр': 4,
    'мая': 5,
    'июн': 6,
    'июл': 7,
    'авг': 8,
    'сен': 9,
    'окт': 10,
    'ноя': 11,
    'дек': 12
}


myDate = "8 марта"
arr = myDate.split()

dateZodiac = int(arr[0])
monthInMas = 0

ZodiacOutput = ""

for key, val in months.items():
    if key in arr[1]:
        monthInMas = val
        dateZodiac += val / 100.0


if dateZodiac - Zodiac_dates[monthInMas - 1] >= 1:
    ZodiacOutput = Zodiac_ru[monthInMas]
else:
    ZodiacOutput = Zodiac_ru[monthInMas - 1]
    # monthInMas -= 1
    
    
print(ZodiacOutput)

