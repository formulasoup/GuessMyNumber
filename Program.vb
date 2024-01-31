Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        'variables
        Dim mynumbers As Random = New Random()
        Dim secret As Integer = mynumbers.Next(1, 11)
        Dim guess As String
        Dim number As Integer
        Dim looping As Boolean = True


        Do
            'user input
            Console.WriteLine("Enter a guess between 1 and 10:")
            guess = Console.ReadLine

            'number checker
            Do Until Integer.TryParse(guess, number) AndAlso number >= 1 AndAlso number <= 10
                If IsNumeric(guess) = False Then
                    Console.WriteLine("please enter a number!")
                    guess = Console.ReadLine()
                Else
                    Console.WriteLine("please enter a number in the right range!")
                    guess = Console.ReadLine()
                End If
            Loop
            Convert.ToInt64(guess)

            'prosses
            If guess = secret Then
                looping = False
                Console.WriteLine("well done, you guessed correctly!")
            ElseIf guess < secret Then
                Console.WriteLine("higher!")
            Else
                Console.WriteLine("lower!")
            End If
            Console.WriteLine()
            number = number + 1
        Loop Until Not (looping)

        Console.WriteLine("It took you " & number & " tries!")
    End Sub
End Module
