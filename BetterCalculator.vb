'Justine Hoffa
'RCET0265
'Fall2020
'BetterCalculator
'https://github.com/justinehoffa/BetterCalculator

Option Strict On
Option Explicit On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim firstInput, secondInput, userInput As String
        Dim firstNumber, secondNumber As Double
        Dim goodData As Boolean

        Do
            Console.WriteLine("Please enter two numbers. Enter q at any time to exit." & vbNewLine)
            Do
                Try
                    Console.WriteLine("Choose a Number:")
                    firstInput = Console.ReadLine()
                    firstNumber = CDbl(firstInput)
                    Console.WriteLine("Choose another number:")
                    secondInput = Console.ReadLine()
                    secondNumber = CDbl(secondInput)
                    goodData = True
                Catch ex As Exception
                    If firstInput = "q" Or secondInput = "q" Then
                        Quit()
                        Exit Sub
                    End If

                    Console.WriteLine("I asked for numbers! You entered: " _
                    & firstInput & " " & "&" & " " & secondInput & ". Try again.")
                    goodData = False
                End Try

            Loop Until goodData = True

            Do
                Console.WriteLine("1. Add." & vbNewLine &
                                  "2. Subtract." & vbNewLine &
                                  "3. Multiply." & vbNewLine &
                                  "4. Divide." & vbNewLine)
                userInput = Console.ReadLine()
                If userInput = "q" Then
                    Quit()
                    Exit Sub

                ElseIf userInput = "add" Or userInput = "1" Then
                    Console.WriteLine(vbNewLine & firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)

                ElseIf userInput = "subtract" Or userInput = "2" Then
                    Console.WriteLine(vbNewLine & firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)

                ElseIf userInput = "multiply" Or userInput = "3" Then
                    Console.WriteLine(vbNewLine & firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)

                ElseIf userInput = "divide" Or userInput = "4" Then
                    Console.WriteLine(vbNewLine & firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)

                ElseIf userInput <> "multiply" _
                    And userInput <> "add" _
                    And userInput <> "divide" _
                    And userInput <> "Subtract" _
                    And userInput <> "1" _
                    And userInput <> "2" _
                    And userInput <> "3" _
                    And userInput <> "4" _
                    Then

                    Console.WriteLine(vbNewLine & "Only add, subtract, multiply or divide will work")
                    Console.WriteLine("Or 1, 2, 3, or 4")

                End If

            Loop Until userInput = "add" _
                    Or userInput = "multiply" _
                    Or userInput = "divide" _
                    Or userInput = "subtract" _
                    Or userInput = "1" _
                    Or userInput = "2" _
                    Or userInput = "3" _
                    Or userInput = "4"
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub

    Sub Quit()
        Console.WriteLine("You entered Q")
        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
