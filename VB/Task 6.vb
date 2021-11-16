Module Module1

    Sub Main()
        Console.WriteLine("Enter the number of Donuts you want: ")
        Dim donutCount As Integer = Console.ReadLine()

        Select Case donutCount
            Case Is < 10
                Console.WriteLine("Number of donuts: " & donutCount)
            Case Else
                Console.WriteLine("Number of donuts: Many")
        End Select

        Console.ReadKey()
    End Sub

End Module
