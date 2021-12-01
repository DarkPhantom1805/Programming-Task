String = input("Enter String: ").lower()
firstChar = String[0]
newString = String[0]

for x in String[1:]:   
    if x == firstChar:
        newString += "*"
    else:
        newString += x
        
print(newString)
 