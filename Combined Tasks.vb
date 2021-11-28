Module Module1

    Sub Main()
        'Final Project combining all the tasks from 1 to 11


        'Declarations
        Dim affirmation, input, input2, newString, position, firstSwap(2) As String
        Dim alphabets() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" _
            , "U", "V", "W", "X", "Y", "Z"}
        Dim cmd_input, lostCharCount, lowerCharCount, upperCharCount, otherCharCount, numCount, maxCount, aCount, eCount, iCount, oCount, uCount, donutcount As Integer
        Dim check(26) As Boolean
        Dim alphabet, inputChar, lostChar, char1, highChar, firstChar As Char


        '------------------------------Code------------------------------
        Do Until cmd_input > 0 And cmd_input < 12
            Console.WriteLine("--------------String Manipulation Homework--------------")
            Console.WriteLine("Which task do you want to go to?")
            Console.WriteLine("Task 1:  Pangram Checker")
            Console.WriteLine("Task 2:  Character Replacer")
            Console.WriteLine("Task 3:  Character Counter")
            Console.WriteLine("Task 4:  Most Repeated Character")
            Console.WriteLine("Task 5:  Vowel Counter")
            Console.WriteLine("Task 6:  Donuts")
            Console.WriteLine("Task 7:  Both Ends")
            Console.WriteLine("Task 8:  Fix Start")
            Console.WriteLine("Task 9:  Mix Up")
            Console.WriteLine("Task 10: Verbing")
            Console.WriteLine("Task 11: Not Bad")
            Console.WriteLine("")
            Console.Write("Enter Task Number: ")
            cmd_input = Console.ReadLine()
            Console.Clear()
        Loop

        '----------------------------Selection----------------------------

        Select Case cmd_input
            Case 1
                '----------------Task 1:  Panagram Checker----------------

                Console.WriteLine("Task 1:  Pangram Checker")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 1:  Pangram Checker")
                        Console.WriteLine("")
                        Console.WriteLine("This task checks if the entered String is a Pangram or not.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 1:  Pangram Checker")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter string: ")
                input = UCase(Console.ReadLine())

                For count = 1 To Len(input)
                    inputChar = Mid(input, count, 1)
                    For count2 = 0 To 25
                        If inputChar = alphabets(count2) Then
                            check(count2) = True
                        End If
                    Next
                Next

                For count = 0 To 25
                    If check(count) = False Then
                        Console.WriteLine("This String is not a Pangram.")
                        Console.ReadKey()
                        End
                    End If
                Next

                Console.WriteLine("This String is a Pangram.")
            Case 2
                '----------------Task 2: Character Replacer----------------

                Console.WriteLine("Task 2: Character Replacer")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 2: Character Replacer")
                        Console.WriteLine("")
                        Console.WriteLine("This task replaces a Character in the string with another Character of the User's choice.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 2: Character Replacer")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter String: ")
                input = Console.ReadLine()
                Console.WriteLine("")

                Console.WriteLine("                 Index: 123...")
                Console.WriteLine("The String you entered: " & input)
                Console.WriteLine("")

                Console.Write("Enter index of the Character you want to replace [Index starts at '1' from the Left]: ")
                Dim charIndex As Integer = Console.ReadLine()
                Console.WriteLine("")

                Console.Write("What do you want to replace '" & Mid(input, charIndex, 1) & "' at Index " & charIndex & " with?: ")
                Dim newChar As String = Console.ReadLine()
                Console.WriteLine("")

                For count = 1 To (Len(input) + 1)
                    If charIndex = 1 Then
                        newString += newChar
                        charIndex = 0
                        Continue For
                    ElseIf count = charIndex Then
                        newString += newChar
                        Continue For
                        If count = (Len(input) + 1) Then
                            Exit For
                        End If
                    End If
                    newString += Mid(input, count, 1)
                    Continue For
                Next

                Console.WriteLine("New String: ")
                Console.WriteLine(newString)

            Case 3
                '----------------Task 3:  Character Counter----------------

                Console.WriteLine("Task 3:  Character Counter")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 3:  Character Counter")
                        Console.WriteLine("")
                        Console.WriteLine("This task counts and outputs the number of times a Character appears in the String.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 3:  Character Counter")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Input String: ")
                input = Console.ReadLine()

                Console.WriteLine("")
                Console.Write("Which Character's position do you want to find?")
                lostChar = Console.ReadLine()

                For count = 1 To Len(input)
                    If Mid(input, count, 1) = lostChar Then
                        lostCharCount += 1
                        position += Str(count)
                    End If
                Next

                Console.WriteLine("")
                Console.WriteLine("The Character '" & lostChar & "' appears " & lostCharCount & " times at the Index/es: " & position)

                For count = 1 To Len(input)
                    inputChar = Mid(input, count, 1)
                    Select Case inputChar
                        Case "a" To "z"
                            lowerCharCount += 1
                        Case "A" To "Z"
                            upperCharCount += 1
                        Case Else
                            otherCharCount += 1
                    End Select
                    If IsNumeric(inputChar) = True Then
                        numCount += 1
                    End If
                Next

                Console.WriteLine("Upper Case Character Count = " & upperCharCount)
                Console.WriteLine("Lower Case Character Count = " & lowerCharCount)
                Console.WriteLine("Numeric Character Count = " & numCount)
                Console.WriteLine("Other / Special Character Count = " & (otherCharCount - numCount))

            Case 4
                '----------------Task 4:  Most Repeated Character----------------

                Console.WriteLine("Task 4:  Most Repeated Character")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 4:  Most Repeated Character")
                        Console.WriteLine("")
                        Console.WriteLine("This task outputs the Character that appears the most in the String.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 4:  Most Repeated Character")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter String: ")
                input = Console.ReadLine()

                Dim highCount(Len(input)) As Integer

                For count = 1 To Len(input)
                    char1 = Mid(input, count, 1)
                    highCount(count) = input.Count(Function(x) LCase(x) = char1)
                    If highCount(count) > maxCount Then
                        maxCount = highCount(count)
                        highChar = Mid(input, count, 1)
                    End If
                Next

                Console.WriteLine("The character that appears the most is: '" & highChar & "' and it appears: '" & maxCount & "' times.")

            Case 5
                '----------------Task 5:  Vowel Counter----------------

                Console.WriteLine("Task 5:  Vowel Counter")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 5:  Vowel Counter")
                        Console.WriteLine("")
                        Console.WriteLine("This task counts and outputs seperate Vowel counts present in the String.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 5:  Vowel Counter")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter String: ")
                input = Console.ReadLine()

                For count = 1 To Len(input)
                    alphabet = Mid(input, count, 1)

                    Select Case UCase(alphabet)
                        Case "A"
                            aCount += 1
                        Case "E"
                            eCount += 1
                        Case "I"
                            iCount += 1
                        Case "O"
                            oCount += 1
                        Case "U"
                            uCount += 1
                    End Select
                Next

                Console.WriteLine("")

                Console.WriteLine("The Vowel A appeared " & aCount & " times in the String.")
                Console.WriteLine("The Vowel E appeared " & eCount & " times in the String.")
                Console.WriteLine("The Vowel I appeared " & iCount & " times in the String.")
                Console.WriteLine("The Vowel O appeared " & oCount & " times in the String.")
                Console.WriteLine("The Vowel U appeared " & uCount & " times in the String.")

            Case 6
                '----------------Task 6:  Donuts----------------

                Console.WriteLine("Task 6:  Donuts")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 6:  Donuts")
                        Console.WriteLine("")
                        Console.WriteLine("This task outputs the number of Donuts entered.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 6:  Donuts")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter the number of Donuts you want: ")
                donutCount = Console.ReadLine()

                If donutCount < 10 Then
                    Console.WriteLine("Number of donuts: " & donutCount)
                Else
                    Console.WriteLine("Number of donuts: Many")
                End If

            Case 7
                '----------------Task 7:  Both Ends----------------

                Console.WriteLine("Task 7:  Both Ends")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 7:  Both Ends")
                        Console.WriteLine("")
                        Console.WriteLine("This task takes a String as an input and outputs another String containing First and Last2 letters of the original String.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 7:  Both Ends")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.WriteLine("Enter String: ")
                input = Console.ReadLine()

                If Len(input) <= 2 Then
                    Console.WriteLine(input)
                Else
                    Console.WriteLine(Left(input, 2) & Right(input, 2))
                End If
            Case 8
                '----------------Task 8:  Fix Start----------------

                Console.WriteLine("Task 8:  Fix Start")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 8:  Fix Start")
                        Console.WriteLine("")
                        Console.WriteLine("This task takes a String and turns all the occurences of its first letter into '*'.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 8:  Fix Start")
                        Console.WriteLine("")
                End Select
                '------------Code-------------

                Console.Write("Enter String: ")
                input = LCase(Console.ReadLine())

                firstChar = Left(input, 1)

                For count = 1 To Len(input)
                    If firstChar = Mid(input, count, 1) Then
                        Mid(input, count, 1) = "*"
                    End If
                Next
                Console.WriteLine(firstChar & Mid(input, 2, Len(input)))
            Case 9
                '----------------Task 9:  Mix Up----------------

                Console.WriteLine("Task 9:  Mix Up")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 9:  Mix Up")
                        Console.WriteLine("")
                        Console.WriteLine("This task takes 2 strings and replaces their first 2 letters with each other.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 9:  Mix Up")
                        Console.WriteLine("")
                End Select
                '------------Code-------------
                Console.WriteLine("Enter Strings 1 and 2: ")
                Console.WriteLine("")
                Console.Write("String 1: ")
                input = Console.ReadLine()
                Console.WriteLine("")
                Console.Write("String 2: ")
                input2 = Console.ReadLine()

                firstSwap(1) = Left(input, 2)
                firstSwap(2) = Left(input2, 2)

                Console.WriteLine("")
                Console.WriteLine(firstSwap(2) & Mid(input, 3, Len(input)) & " " & firstSwap(1) & Mid(input2, 3, Len(input2)))
            Case 10
                '----------------Task 10:  Verbing----------------

                Console.WriteLine("Task 10:  Verbing")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 10:  Verbing")
                        Console.WriteLine("")
                        Console.WriteLine("This task turns the last sentence of a string to a verb.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 10:  Verbing")
                        Console.WriteLine("")
                End Select
                '------------Code-------------
                Console.Write("Enter String: ")
                input = Console.ReadLine()

                If Right(input, 3) = "ing" Then
                    Console.WriteLine(input & "ly")
                ElseIf Len(input) >= 3 Then
                    Console.WriteLine(input & "ing")
                Else
                    Console.WriteLine(input)
                End If
            Case 11
                '----------------Task 11:  Not Bad----------------

                Console.WriteLine("Task 11:  Not Bad")
                Console.WriteLine("")
                Console.Write("Do you want more information on this Task? Y/N: ")
                affirmation = Console.ReadLine()

                Select Case affirmation
                    Case "Y", "y"
                        Console.Clear()
                        Console.WriteLine("Task 11:  Not Bad")
                        Console.WriteLine("")
                        Console.WriteLine("This task turns everything in between and including the words 'Not Bad' into good.")
                        Console.WriteLine("")
                    Case "N", "n"
                        Console.Clear()
                        Console.WriteLine("Task 11:  Not Bad")
                        Console.WriteLine("")
                End Select
                '------------Code-------------
                Console.WriteLine("Enter String: ")
                input = LCase(Console.ReadLine())

                For count = 1 To Len(input)
                    For count2 = 1 To Len(input)
                        If Mid(input, count, 3) = "not" And Mid(input, count2, 3) = "bad" Then
                            Dim charsToReplace As Integer = (count2 - count)
                            input = Left(input, (count - 1)) & "good" & Mid(input, (count2 + 3), (Len(input)))
                        End If
                    Next
                Next
                Console.WriteLine(input)
        End Select

        Console.ReadLine()
    End Sub
End Module