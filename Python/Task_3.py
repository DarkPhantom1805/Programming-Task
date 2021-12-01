String = input("Enter String: ")
inputChar = input("Which character's position do you want to find?: ")
alphabets = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]

def find_char(userInput, lostChar):
    charCount = 0
    positions = ""
    count = 0
    for x in userInput:
        if x == lostChar:
            charCount += 1
            positions += str(count)
        count += 1
    return charCount, positions

def char_counter(userInput):
    upperCount = 0
    lowerCount = 0
    numCount = 0
    otherCount = 0
    for x in userInput:
        if x >= "A" and x <= "Z":
            upperCount += 1
        elif x >= "a" and x <= "z":
            lowerCount += 1
        elif x.isdigit() == True:
            numCount += 1
        else:
            otherCount += 1
    return upperCount, lowerCount, numCount, otherCount

Ucount, Lcount, Numcount, Othercount = char_counter(String)
charCount, positions = find_char(String, inputChar)

print(f"The character '{inputChar}' appears '{charCount}' times at the Index/es: {positions}")
print("")
print("Upper Case Character Count = ", Ucount)
print("Lower Case Character Count = ", Lcount )
print("Numeric Character Count = ", Numcount)
print("Other / Special Character Count = ", Othercount)
