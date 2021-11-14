Module Module1

    Sub Main()
        Console.WriteLine("Enter String: ")
        Dim input As String = Console.ReadLine()

        If Right(input, 3) = "ing" Then
            Console.WriteLine(input & "ly")
        ElseIf Len(input) >= 3 Then
            Console.WriteLine(input & "ing")
        Else
            Console.WriteLine(input)
        End If

        Console.ReadLine()
    End Sub

End Module
