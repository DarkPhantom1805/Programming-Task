Module module1
    Sub main()
        Console.Write("Enter String: ")
        Dim Input As String = Console.ReadLine()

        Dim char1, char2, highChar As Char
        Dim maxCount, charCount(len(input)), count, count2 As Integer
        
        maxCount = 0
        
        for count = 1 to len(input)
            char1 = Mid(Input, count, 1)
            for count2 = 1 to len(Input)
                char2 = Mid(input, count2, 1)
                if char2 = " " then
                continue for
                end if
                if char1 = char2
                    charCount(count2) += 1
                    If charCount(count2) > maxCount Then
                        maxCount = charCount(count2)
                        highChar = Mid(Input, count, 1)
                    End If
                End If
            Next
        Next

        Console.WriteLine("The character that appears the most is: '" & highChar & "' and it appears: '" & maxCount & "' times.")

        Console.ReadLine()
    End Sub
End Module
