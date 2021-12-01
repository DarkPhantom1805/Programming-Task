String = input("Enter String: ").lower()

for x in range(0, len(String)):
    for y in range(0, len(String)):
        if String[x:x+3] == "not" and String[y:y+3] == "bad":
            String = String[:x] + "good" + String[y+3:]

print(String)