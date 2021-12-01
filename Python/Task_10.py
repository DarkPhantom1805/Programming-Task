String = input("Enter String: ").lower()

if String[-3:] == "ing":
    print(String + "ly")
elif len(String) > 2:
    print(String + "ing")
else:
    print(String)