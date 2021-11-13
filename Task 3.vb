Module Module1

    Sub Main()
        Dim lostCharCount, lowerCharCount, upperCharCount, otherCharCount, numCount As Integer
        Dim position As String
        Dim inputChar As Char

        Console.Write("Input String: ")
        Dim input As String = Console.ReadLine()

        Console.Write("Which Character's position do you want to find?")
        Dim lostChar As Char = Console.ReadLine()

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



        Console.ReadLine()
    End Sub

End Module
