import math

class Triangle:
    def __init__(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    def check_existence(self):
        return self.a + self.b > self.c and self.a + self.c > self.b and self.b + self.c > self.a

    def calculate_perimeter(self):
        return self.a + self.b + self.c

    def calculate_area(self):
        s = self.calculate_perimeter() / 2
        return math.sqrt(s * (s - self.a) * (s - self.b) * (s - self.c))

class Pyramid(Triangle):
    def __init__(self, a, b, c, height):
        super().__init__(a, b, c)
        self.height = height

    def calculate_area(self):
        base_area = super().calculate_area()
        return (base_area + 0.5 * (self.a + self.b + self.c) * self.height)

class TriangularPrism(Triangle):
    def __init__(self, a, b, c, height):
        super().__init__(a, b, c)
        self.height = height

    def calculate_area(self):
        base_area = super().calculate_area()
        return (base_area * 2 + self.calculate_perimeter() * self.height)

# Пример использования
triangle = Triangle(3, 4, 5)
print(triangle.check_existence())  # True
print(triangle.calculate_perimeter())  # 12
print(triangle.calculate_area())  # 6.0

pyramid = Pyramid(3, 4, 5, 6)
print(pyramid.calculate_area())  # 52.0

prism = TriangularPrism(3, 4, 5, 6)
print(prism.calculate_area())  # 72.0
