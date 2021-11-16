Module Module1

    Sub Main()
        Console.WriteLine("Enter String: ")
        Dim input As String = UCase(Console.ReadLine())

        Dim aCount, eCount, iCount, oCount, uCount As Integer

        For count = 1 To Len(input)
            Dim alphabet As Char = Mid(input, count, 1)

            Select Case alphabet
                Case "A"
                    aCount += 1
                Case "E"
                    eCount += 1
                Case "I"
                    iCount += 1
                Case "O"
                    oCount += 1
                Case "U"
                    uCount += 1
            End Select
        Next

        Console.WriteLine("")
        Console.WriteLine("The Vowel A appeared " & aCount & " times in the String.")
        Console.WriteLine("The Vowel E appeared " & eCount & " times in the String.")
        Console.WriteLine("The Vowel I appeared " & iCount & " times in the String.")
        Console.WriteLine("The Vowel O appeared " & oCount & " times in the String.")
        Console.WriteLine("The Vowel U appeared " & uCount & " times in the String.")

        Console.ReadLine()
    End Sub

End Module
