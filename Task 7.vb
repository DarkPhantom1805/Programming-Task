Module Module1

    Sub Main()
        Console.WriteLine("Enter String: ")
        Dim input As String = Console.ReadLine()

        If Len(input) <= 2 Then
            Console.WriteLine(input)
        Else
            Console.WriteLine(Left(input, 2) & Right(input, 2))
        End If

        Console.ReadKey()
    End Sub

End Module
