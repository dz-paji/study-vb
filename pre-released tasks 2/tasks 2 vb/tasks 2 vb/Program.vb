Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        ' task 1
        Dim inputWeightArray(29) As Double
        ' declear an array called inputWeightArray that has a double data type
        Dim inputNameArray(29) As String
        ' declear an array called inputNameArray that has a string data type
        Dim systemValidationDouble As Double
        ' declear a variable called systemValidationDouble that has a double data type.
        Dim inputeWeightArrayEnd(29) As Double
        ' declear an array called systemWeightArrayEnd that has a double data type
        Dim inputNameArrayEnd(29) As String
        ' declear an array called inputNameArray that has a string data type
        Dim usrWeightChanges As Double
        ' drclear a variable called usrWeightChanges that has a double data type

        Dim i As Int32
        ' declear a counter which will be used in for loop.

        For i = 0 To 29
            'use for loop to let user input their data.

            Console.WriteLine("Please enter your name")
            ' let user enter their name

            inputNameArray(i) = Console.ReadLine()
            ' store thier input in the array.

            Console.WriteLine("Please enter your weight(in kg)")
            'let user enter their weight

            systemValidationDouble = Console.ReadLine()
            ' store their input in the transition variable

            ' validation
            If systemValidationDouble < 30 Or systemValidationDouble > 200 Then
                ' if the data is invalid, show something.
                Console.WriteLine("Wait... The data you entered seems invalid. Please check again.")
                Return
            Else
                ' id the data is valid, store it in the array.
                inputWeightArray(i) = systemValidationDouble
            End If

            ' output the data they entered.
            Console.WriteLine("Student {0}, has weight {1) kg", inputNameArray(i), inputWeightArray(i))

            ' end the loop, i ++
        Next

        For i = 0 To 29
            'use for loop to let user input their data.

            Console.WriteLine("Please enter your name")
            ' let user enter their name

            inputNameArrayEnd(i) = Console.ReadLine()
            ' store thier input in the array.

            Console.WriteLine("Please enter your weight(in kg)")
            'let user enter their weight on the last day of the school.

            systemValidationDouble = Console.ReadLine()
            ' store their input in the transition variable

            ' validation
            If systemValidationDouble < 30 Or systemValidationDouble > 200 Then
                ' if the data is invalid, show something.
                Console.WriteLine("Wait... The data you entered seems invalid. Please check again.")
            Else
                ' id the data is valid, store it in the array.
                inputeWeightArrayEnd(i) = systemValidationDouble
            End If

            If inputeWeightArrayEnd(i) > inputeWeightArrayEnd(i) Then
                'if the final wight is greater than the initial weight, calculate the weight changed.
                usrWeightChanges = inputeWeightArrayEnd(i) - inputNameArray(i)
            Else
                ' other wise, calculate the weight changed like this
                usrWeightChanges = inputNameArray(i) - inputNameArrayEnd(i)
            End If


            If usrWeightChanges > 2.5 Or usrWeightChanges < -2.5 Then
                ' check if the weight changed bigger than 2.5
                Console.WriteLine("{0}, your weight changed {1}kg, keep this in mind!", inputNameArrayEnd(i), usrWeightChanges)
                ' a suitable message
            End If

            Console.ReadKey()

            ' for loop ended, counter + 1
        Next


        ' 



    End Sub
End Module
