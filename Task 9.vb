Module Module1

    Sub Main()
        Console.WriteLine("Enter Strings 1 and 2: ")
        Console.WriteLine("")
        Console.Write("String 1: ")
        Dim input1 As String = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("String 2: ")
        Dim input2 As String = Console.ReadLine()

        Dim firstSwap(2) As String
        firstSwap(1) = Left(input1, 2)
        firstSwap(2) = Left(input2, 2)

        Console.WriteLine("")
        Console.WriteLine(firstSwap(2) & Mid(input1, 3, Len(input1)) & " " & firstSwap(1) & Mid(input2, 3, Len(input2)))

        Console.ReadLine()
    End Sub

End Module
