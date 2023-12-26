palindrom = int(input())
if palindrom == int(str(palindrom)[::-1]):
    print("True")
else:
    print("False")