alphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]
x = input("Enter String: ").upper()

check = [False] * 26

for count in range(0,26):
    for i in x:
        if alphabet[count] == i:
            check[count] = True
            
for i in check:
    if i == False:
        print("This String is not a Pangram")
        exit()

print("This String is a pangram")