Module Module1

    Sub Main()
        Dim newString As String
        Dim count As Integer
        count = 1
        newString = ""

        Console.Write("Enter String: ")
        Dim input As String = Console.ReadLine()

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

        Do
            If charIndex = 1 Then
                newString += newChar
                charIndex = 0
                count += 1
            else If count = charIndex Then
                newString += newChar
                count += 1
                If count = (Len(input) + 1) Then
                    Exit Do
                End If
            End If
            newString += Mid(input, count, 1)
            count += 1
        Loop Until count = (Len(input) + 1)


        Console.WriteLine("New String: ")
        Console.WriteLine(newString)

        Console.ReadKey()
    End Sub

End Module
