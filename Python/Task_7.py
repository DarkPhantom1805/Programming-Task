String = input("Enter String: ")

if len(String) <= 2:
    print(String)
else:
    print(f"{String[:2]}{String[-2::]}")