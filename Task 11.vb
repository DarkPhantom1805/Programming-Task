Module Module1

    Sub Main()
        Console.WriteLine("Enter String: ")
        Dim input As String = Console.ReadLine()

        For count = 1 To Len(input)
            For count2 = 1 To Len(input)
                If LCase(Mid(input, count, 3)) = "not" And LCase(Mid(input, count2, 3)) = "bad" Then
                    Dim charsToReplace As Integer = (count2 - count)
                    input = Left(input, (count - 1)) & "good" & Mid(input, (count2 + 3), (Len(input) - (count2 + 2)))
                End If
            Next
        Next

        Console.WriteLine(input)

        Console.ReadLine()
    End Sub

End Module
