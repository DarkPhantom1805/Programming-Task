Module Module1

    Sub Main()
        Console.WriteLine("Enter the number of Donuts you want: ")
        Dim donutCount As Integer = Console.ReadLine()

        If donutCount < 10 Then
            Console.WriteLine("Number of donuts: " & donutCount)
        Else
            Console.WriteLine("Number of donuts: Many")
        End If

        Console.ReadKey()
    End Sub

End Module
