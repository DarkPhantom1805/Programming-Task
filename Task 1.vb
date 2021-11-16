Module Module1

    Sub Main()
        Dim check(25) As Boolean
        Dim alphabet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" _
            , "U", "V", "W", "X", "Y", "Z"}
        Dim inputChar As String

        Console.Write("Enter string: ")
        Dim input As String = UCase(Console.ReadLine())

        For count = 1 To Len(input)
            inputChar = Mid(input, count, 1)
            For count2 = 0 To 25
                If inputChar = alphabet(count2) Then
                    check(count2) = True
                End If
            Next
        Next

        For count = 0 To 25
            If check(count) = False Then
                Console.WriteLine("This String is not a Pangram.")
                Console.ReadKey()
                End
            End If
        Next

        Console.WriteLine("This String is a Pangram.")

        Console.ReadKey()
    End Sub

End Module
