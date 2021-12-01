String = input("Enter String: ")
maxCount = 0

for x in String:
    charCount = 0
    if x == " ":
        continue
    for y in String: 
        if x == y:
            charCount = charCount + 1
            if charCount > maxCount:
                maxCount = charCount
                highChar = x
            
print(f"The character that appears the most is: '{highChar}' and it appears: '{maxCount}' times.")