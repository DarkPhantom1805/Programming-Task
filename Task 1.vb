Module Module1

    Sub Main()
        Dim check(26) As Boolean
        Dim alphabet As Char

        Console.Write("Enter string: ")
        Dim input As String = UCase(Console.ReadLine())

        For count = 1 To 26
            check(count) = False
        Next

        For count = 1 To Len(input)
            alphabet = Mid(input, count, 1)
            Select Case alphabet
                Case "A"
                    check(1) = True
                Case "B"
                    check(2) = True
                Case "C"
                    check(3) = True
                Case "D"
                    check(4) = True
                Case "E"
                    check(5) = True
                Case "F' "
                    check(6) = True
                Case "G"
                    check(7) = True
                Case "H"
                    check(8) = True
                Case "I"
                    check(9) = True
                Case "J"
                    check(10) = True
                Case "K"
                    check(11) = True
                Case "L"
                    check(12) = True
                Case "M"
                    check(13) = True
                Case "N"
                    check(14) = True
                Case "O"
                    check(15) = True
                Case "P"
                    check(16) = True
                Case "Q"
                    check(17) = True
                Case "R"
                    check(18) = True
                Case "S"
                    check(19) = True
                Case "T"
                    check(20) = True
                Case "U"
                    check(21) = True
                Case "V"
                    check(22) = True
                Case "W"
                    check(23) = True
                Case "X"
                    check(24) = True
                Case "Y"
                    check(25) = True
                Case "Z"
                    check(26) = True
            End Select
        Next

        check(0) = True

        For count = 1 To 26
            If check(count) = False Then
                check(0) = False
            End If
        Next

        If check(0) = True Then
            Console.WriteLine("This String is a Panagram.")
        Else
            Console.WriteLine("This String is not a Panagram.")
        End If

        Console.ReadKey()
    End Sub

End Module