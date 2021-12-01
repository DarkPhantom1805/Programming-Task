String1 = input("Enter String 1: ")
String2 = input("Enter String 2: ")

firstSwap = [""] * 2 

firstSwap[0] = String1[:2]
firstSwap[1] = String2[:2]

print(firstSwap[1] + String1[2:], firstSwap[0] + String2[2:])