Module Module1

    Sub Main()
        Console.WriteLine("Enter String: ")
        Dim input As String = Console.ReadLine()

        Dim length, highcount(Len(input)), maxHigh As Integer
        Dim char1(Len(input)) As Char
        Dim char2(Len(input)) As Char

        For count = 1 To Len(input)
            char1(count) = Mid(input, count, 1)
            char2(count) = Mid(input, count, 1)
            length += 1
        Next

        Dim char3(length) As Char

        For count = 1 To length
            highcount(count) = 0
            If char1(count) = char2(count) Then
                char3(count) = char1(count)
            End If
        Next

        For count = 1 To length
            For count2 = 1 To length
                If char3(count) = Mid(input, count2, 1) Then
                    highcount(count) += 1
                End If
            Next
        Next

        For count = 1 To length
            If highcount(count) > maxHigh Then
                maxHigh = highcount(count)
            End If
        Next

        Console.WriteLine("The character that appears the most is: '" & char3(maxHigh) & "' it appears: '" & maxHigh & "' times.")

        Console.ReadLine()
    End Sub

End Module