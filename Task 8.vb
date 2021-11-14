Module Module1

    Sub Main()
        Console.Write("Enter String: ")
        Dim input As String = Console.ReadLine()

        Dim firstChar As Char = Left(input, 1)

        For count = 1 To Len(input)
            If firstChar = Mid(input, count, 1) Then
                Mid(input, count, 1) = "*"
            End If
        Next
        Console.WriteLine(firstChar & Mid(input, 2, Len(input)))
        Console.ReadKey()
    End Sub

End Module
