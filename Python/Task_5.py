String = input("Enter String: ").upper()

vowelCount = [0] * 5
vowels = ["A", "E", "I", "O","U"]

for x in String:
    if x == "A":
        vowelCount[0] +=  1
    if x == "E":
        vowelCount[1] +=  1
    if x == "I":
        vowelCount[2] += 1
    if x == "O":
        vowelCount[3] +=  1
    if x == "O":
        vowelCount[4] +=  1

for i in range(0, 5):
    print(f"The Vowel {vowels[i]} appeared {vowelCount[i]} times in the String.")