userInput = input("Enter String: ").lower()
charIndex = int(input("Enter index of the character you want to replace [Index starts from 0]: "))
replacementChar = input(f"What do you want to replace '{userInput[charIndex]}' at Index {charIndex} with?: ")
newString = ""

count = 0
for x in userInput:
    if charIndex == 0:
        newString = newString + replacementChar
        charIndex = None
        count += 1
        continue
    elif count == charIndex:
        newString = newString + replacementChar
        count += 1
        continue
    newString += x
    count += 1

print(newString)
