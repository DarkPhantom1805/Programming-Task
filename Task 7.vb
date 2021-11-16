Module Module1

    Sub Main()
        Console.Write("Enter String: ")
        Dim input As String = Console.ReadLine()

        If Len(input) <= 2 Then
            Console.WriteLine("")
            Console.WriteLine(input)
        Else
            Console.WriteLine("")
            Console.WriteLine(Left(input, 2) & Right(input, 2))
        End If

        Console.ReadKey()
    End Sub

End Module
