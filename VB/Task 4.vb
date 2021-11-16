Module module1
    Sub main()
        Console.Write("Enter String: ")
        Dim Input As String = Console.ReadLine()

        Dim char1, highChar As Char
        Dim maxCount As Integer

        Dim highCount(Len(Input)) As Integer

        For count = 1 To Len(Input)
            char1 = Mid(Input, count, 1)
            highCount(count) = Input.Count(Function(x) LCase(x) = char1) 'this "Input.Count(Function(x) LCase(x) = char1)" is the only
            ' statement which i dont know how it works. I got the correct count for the most appeared character however my code would
            ' display the wrong character even while showing the correct repeat count. So I searched stack overflow for a solution and
            ' found this line which works perfectly. This is also the only help i've taken from the internet in all of my 11 codes
            If highCount(count) > maxCount Then
                maxCount = highCount(count)
                highChar = Mid(Input, count, 1)
            End If
        Next

        Console.WriteLine("The character that appears the most is: '" & highChar & "' and it appears: '" & maxCount & "' times.")

        Console.ReadLine()
    End Sub
End Module
