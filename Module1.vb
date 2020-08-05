Module Module1

    Sub Main()

        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        Dim temperature() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        Dim total, average As Integer

        Dim monthsabove As Integer = 0

        For i = 0 To 11

            Console.WriteLine("Please enter temperature for: " & months(i))

            temperature(i) = Console.ReadLine()

        Next

        For i = 0 To 11

            Console.WriteLine(months(i) & ":" & temperature(i))

            total = total + temperature(0)

        Next

        Console.WriteLine("Annual rainfall = " & total)

        average = Int(total / 12)

        Console.WriteLine("Average monthly rainfall = " & average)

        For i = 0 To 11

            If temperature(i) > average Then

                monthsabove = monthsabove + 1

            End If

        Next

        Console.WriteLine("Number of months above the average rainfall = " & monthsabove)

        Console.Read()

    End Sub

End Module
