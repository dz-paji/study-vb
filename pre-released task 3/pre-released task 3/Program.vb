Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        Dim i As Int32
        ' this is my counter

        Dim validationElement As Int32
        ' this is the variable used for validation.

        Dim inputNameArray(29) As String
        ' this is my array stores students' name

        Dim inputResult1Array(29) As Int32
        ' this is my array stores students first test results

        Dim inputResult2Array(29) As Int32
        ' this is my array stores students 2nd test results

        Dim inputResult3Array(29) As Int32
        ' this is my array stores students 3rd test results

        Dim inputResult As Int32
        ' this is the variable used for user to input their mark.

        Dim sysStudentTotalAverageArray(29) As Double
        ' this is the variable used to calculating the average mark of each students

        Dim sysClassTotalAverage As Double
        'this is the variable used to calculating the average mark of the whole class.

        Dim sysAverage As Double
        ' the temperate variable used for storing the avrage score of the class.

        Dim sysSAverage As Double
        ' the temperate variable used for storing the average score of each student

        For i = 0 To 29
            ' this is the start of my for loop

            Console.WriteLine("Please enter your name XD")
            ' let user input their name

            inputNameArray(i) = Console.ReadLine()
            ' store their name in the array.

            Console.WriteLine("Please enter the first result of the test")
            inputResult = Console.ReadLine()
            ' let them input the first result.

            Do While inputResult < 0 Or inputResult > 20
                ' validation check

                Console.WriteLine("invalid result. please enter again.")
                inputResult = Console.ReadLine()

            Loop

            sysAverage = sysAverage + inputResult
            ' store all the scores to the temperate variable

            inputResult1Array(i) = inputResult / 20
            ' store the their first result in the array.

            sysSAverage = inputResult + sysSAverage
            ' store the total mark of this student



            Console.WriteLine("Please enter the 2nd result of the test")
            inputResult = Console.ReadLine()
            ' let them input the 2nd result.

            Do While inputResult < 0 Or inputResult > 25
                ' validation check

                Console.WriteLine("invalid result. please enter again.")
                inputResult = Console.ReadLine()

            Loop

            sysAverage = sysAverage + inputResult
            ' store all the scores to the temperate variable

            inputResult2Array(i) = inputResult / 25
            ' store the their 2nd result in the array.

            sysSAverage = inputResult
            ' store the total mark of this student

            Console.WriteLine("Please enter the 3rd result of the test")
            inputResult = Console.ReadLine()
            ' let them input the 3rd result.

            Do While inputResult < 0 Or inputResult > 35
                ' validation check

                Console.WriteLine("invalid result. please enter again.")
                inputResult = Console.ReadLine()

            Loop

            sysAverage = sysAverage + inputResult
            ' store all the scores to the temperate variable


            inputResult3Array(i) = inputResult / 35
            ' store the their 3rd result in the array.

            sysSAverage = inputResult + sysSAverage
            ' store the total mark of this student

            sysAverage = sysSAverage / 30
            ' calculate the average total score of this student

            sysStudentTotalAverageArray(i) = sysAverage

        Next

        sysClassTotalAverage = sysAverage / 30

        For i = 0 To 29
            Console.WriteLine("Student name: {0} , their total score is {1}", inputNameArray, inputResult1Array(i) + inputResult2Array(i) + inputResult3Array(i))
            Console.WriteLine("Total average of the class is {0}", sysClassTotalAverage)
        Next

    End Sub
End Module
