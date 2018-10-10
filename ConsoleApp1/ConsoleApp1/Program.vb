Imports System

Module Program
    Sub Main(args As String())
        ' Start.
        'Dim amaer As Int32
        'Dim softBank As Int32
        'Dim yingHua As Int32
        'Console.WriteLine("Enter a ")
        'amaer = Console.ReadLine()

        'Console.WriteLine("Enter b")
        'softBank = Console.ReadLine()

        'yingHua = amaer + softBank

        'Console.WriteLine("The answer is: {0}", yingHua)

        'If (yingHua > 10) Then
        '    Console.WriteLine("Pass")
        'Else
        '    Console.WriteLine("Fail")
        'End If

        'Console.WriteLine("Enter a hero name")
        'Dim heroName As String
        'heroName = Console.ReadLine()
        'If (heroName = "Amar") Then
        '    Console.WriteLine("Good. He is the best.")
        'Else
        '    If (heroName = "Superman") Then
        '        Console.WriteLine("He is ok but Amar is better")
        '    Else
        '        Console.WriteLine("SoftBank")
        '    End If
        'End If

        'Dim answer As String
        'Dim score As Int32
        'Console.WriteLine("1+1=?")
        'answer = Console.ReadLine()
        'If (answer = "2") Then
        '    score = score + 1
        'ElseIf 

        '    score = score - 1
        'End If
        'Console.WriteLine("1*1=?")
        'answer = Console.ReadLine()
        'If (answer = "1") Then
        '    score = score + 1
        'Else
        '    score = score - 1
        'End If
        'Console.WriteLine("1-1=?")
        'answer = Console.ReadLine()
        'If (answer = "0") Then
        '    score = score + 1
        'Else
        '    score = score - 1
        'End If
        'Console.WriteLine("2 - 1 =?")
        'answer = Console.ReadLine()
        'If (answer = "1") Then
        '    score = score + 1
        'Else
        '    score = score - 1
        'End If
        'Console.WriteLine("1*2=?")
        'answer = Console.ReadLine()
        'If (answer = "2") Then
        '    score = score + 1
        'Else
        '    score = score - 1
        'End If
        'Console.WriteLine("1 + 1 = ?")
        'answer = Console.ReadLine()
        'If (answer = "2") Then
        '    score = score + 1
        'ElseIf
        '        Console.WriteLine(" 1 - 1 = ?")

        'End If
        'Console.WriteLine("You got {0}, points", score)
        'Dim userInput As String
        'Dim i As Int32
        'Dim usrI As String
        '        Console.WriteLine("Choose a letter from A to c")
        '        userInput = Console.ReadLine()
        '        userInput = userInput.ToUpper
        '        Console.WriteLine("Choose a number you like(>0)")
        '        i = Console.ReadLine()
        '        If (userInput = "A") Then
        '            For i = 0 To i - 1
        '                Console.WriteLine("US")
        '            Next
        '        ElseIf (userInput = "B") Then
        '            For i = 0 To i - 1
        '                Console.WriteLine("UK")
        '            Next
        '        ElseIf (userInput = "C") Then
        '            For i = 0 To i - 1
        '                Console.WriteLine("CN")
        '            Next
        '        Else
        '            Console.WriteLine("Fail
        '")
        '        End If
        'Dim score As String
        'Console.WriteLine("Please type your score")
        'score = Console.ReadLine()
        'If (score > 90) Then
        '    Console.WriteLine("A*")
        'ElseIf (score > 80) Then
        '    Console.WriteLine("A")
        'ElseIf (score > 70) Then
        '    Console.WriteLine("B")
        'ElseIf (score > 60) Then
        '    Console.WriteLine("C")
        'End If
        'Console.ReadKey()
        'If (score > 90) Then
        '    Console.WriteLine("A")
        'Else
        '    If (score > 80) Then
        '        Console.WriteLine("B")
        '    End If
        'End If
        'End If
        'Dim stringA As String
        'Dim stringB As String
        'Console.WriteLine("Please enter string A")
        'stringA = Console.ReadLine()
        'Console.WriteLine("Please enter string B")
        'stringB = Console.ReadLine()
        ''If (numberA > numberB) Then

        ''    Console.WriteLine(numberB * numberA)
        ''Else
        ''    Console.WriteLine(numberA + numberB)

        ''End If
        'If (stringA.Length > stringB.Length) Then
        '    Console.WriteLine(stringA)
        'ElseIf (stringA.Length < stringB.Length) Then
        '    Console.WriteLine(stringB)
        'ElseIf (stringA.Length = stringB.Length) Then
        '    Console.WriteLine("same")
        'End If
        'Dim inputFruit As String
        'Dim Fruitlower As String
        'Console.WriteLine("Which fruit do you link? Apple, Orange, Bananas or Peach?")
        'inputFruit = Console.ReadLine()
        'Dim firstOutput As String = "You like " & inputFruit
        'Fruitlower = inputFruit.ToLower
        'Select Case Fruitlower
        '    Case "apple"
        '        Console.WriteLine(firstOutput & ". These are green and red")
        '    Case "orange"
        '        Console.WriteLine(firstOutput & ". These are orange... omg")
        '    Case "bananas"
        '        Console.WriteLine(firstOutput & ". Yellow, seriously")
        '    Case "peach"
        '        Console.WriteLine(firstOutput & ". Red on the outside but yellow inside")
        '    Case Else
        '        Console.WriteLine("Hey, you need to pick one.")
        'End Select

        'Dim input1 As String
        'Console.WriteLine("Ý”Èë A")
        'input1 = Console.ReadLine()
        'If input1 = "A" Then
        '    Console.WriteLine("Nice")
        'ElseIf input1 <> "A" Then

        '    Do
        '        Console.WriteLine("ÎÒ×ŒÄãÝ”Èë A")
        '        input1 = Console.ReadLine()
        '    Loop While input1 <> "A"
        '    Console.WriteLine("Nice")
        'End If
        ' A task
        ' In IF/THEN/ELSE
        'Dim inputName As String
        'Dim outputName As String = "His real name is "
        'Console.WriteLine("Input a hero name")
        'inputName = Console.ReadLine()
        'If inputName = "BATMAN" Then
        '    Console.WriteLine(outputName & "Bruce Wayne")
        'Else
        '    If inputName = "SUPERMAN" Then
        '        Console.WriteLine(outputName & "Kal El")
        '    Else
        '        If inputName = "IRON MAN" Then
        '            Console.WriteLine(outputName & "Tony Stark")
        '        Else
        '            If inputName = "FLASH" Then
        '                Console.WriteLine(outputName & "Barry Allen")
        '            Else
        '                Console.WriteLine("OMG, your hero is not on my list")
        '            End If
        '        End If
        '    End If
        'End If

        'Use elseif
        'Dim inputName As String
        'Dim outputName As String = "His real name is "
        'Console.WriteLine("Input a hero name")
        'inputName = Console.ReadLine()
        'If inputName = "BATMAN" Then
        '    Console.WriteLine(outputName & "Bruce Wayne")
        'ElseIf inputName = "SUPERMAN" Then
        '    Console.WriteLine(outputName & "Kal El")
        'ElseIf inputName = "IRON MAN" Then
        '    Console.WriteLine(outputName & "Tony Stark")
        'ElseIf inputName = "FLASH" Then
        '    Console.WriteLine(outputName & "Barry Allen")
        'Else
        '    Console.WriteLine("OMG, your hero is not on my list")
        'End If

        ' Use case
        'Dim inputName As String
        'Dim outputName As String = "His real name is "
        'Console.WriteLine("Input a hero name")
        'inputName = Console.ReadLine()
        'Select Case inputName
        '    Case "BATMAN"
        '        Console.WriteLine(outputName & "Bruce Wayne")
        '    Case "SUPERMAN"
        '        Console.WriteLine(outputName & "Kal El")
        '    Case "IRON MAN"
        '        Console.WriteLine(outputName & "Tony Stark")
        '    Case "FLASH"
        '        Console.WriteLine(outputName & "Barry Allen")
        '    Case Else
        '        Console.WriteLine("OMG, your hero is not on my list"
        'End Select

        ' Connecting Logical Operators
        ' fake Calculator
        'Dim numberA As Int32
        'Dim numberB As Int32
        'Dim numberC As Int32
        'Dim operators As String
        'Console.WriteLine("Input number A:")
        'numberA = Console.ReadLine()
        'Console.WriteLine("Input number B:")
        'numberB = Console.ReadLine()
        'Console.WriteLine("Input number C:")
        'numberC = Console.ReadLine()
        'Console.WriteLine("Please input the operator, +, -, * or /")
        'operators = Console.ReadLine()
        'Select Case operators
        '    Case "-"
        '        Console.WriteLine("Your result is {0}", numberA - numberB - numberC)
        '    Case "+"
        '        Console.WriteLine("Your result is {0}", numberA + numberB + numberC)
        '    Case "*"
        '        Console.WriteLine("Your result is {0}", numberA * numberB * numberC)
        '    Case "/"
        '        Console.WriteLine("Your result is {0}", numberA / numberB / numberC)
        'End Select

        ' result
        'Dim inputName As String
        'Dim inputScore As Int32
        'Dim inputTotalMark As Int32
        'Dim inputcontinue As String
        'Dim output As String = "{0} got a(n)"
        'Console.WriteLine("Please input the total posible mark")
        'inputTotalMark = Console.ReadLine()

        'Do
        '    Console.WriteLine("Please input the student name")
        '    inputName = Console.ReadLine()
        '    Console.WriteLine("Please input his/hers score")
        '    inputScore = Console.ReadLine()
        '    If (inputScore / inputTotalMark) > 0.95 Then
        '        Console.WriteLine(output & " A*", inputName)
        '    ElseIf (inputScore / inputTotalMark) > 0.8 And (inputScore / inputTotalMark) < 0.94 Then
        '        Console.WriteLine(output & " A", inputName)
        '    ElseIf (inputScore / inputTotalMark) > 0.6 And (inputScore / inputTotalMark) < 0.79 Then
        '        Console.WriteLine(output & " B", inputName)
        '    ElseIf (inputScore / inputTotalMark) < 0.6 Then
        '        Console.WriteLine(output & " C", inputName)
        '    End If
        '    Console.WriteLine("Do you want to do more?(Y/N)")
        '    inputcontinue = Console.ReadLine()
        'Loop While inputcontinue.ToLower = "y"
        'Dim inputmass As String
        'Dim inputtype As String
        'Console.WriteLine("input the mass")
        'inputmass = Console.ReadLine()
        'Console.WriteLine("input the transfer type(local or international)")
        'inputtype = Console.ReadLine()
        'If inputtype.ToLower = "local" And inputmass > 50 Then
        '    Console.WriteLine("invalid")
        'ElseIf inputtype = "local" And inputmass < 5 Then
        '    Console.WriteLine("$20")
        'ElseIf inputtype = "local" And inputmass > 5 And inputmass < 50 Then
        '    Console.WriteLine(20 + (inputmass - 5))
        'ElseIf inputtype = "international" And inputmass < 10 Then
        '    Console.WriteLine("$40")
        'Else
        '    Console.WriteLine("invalid")
        'End If

        ' real calculator
        'Dim inputnumberA As String
        'Dim inputnumberB As Int32
        'Dim resultCalculated As Int32
        'Dim continueProcess As String
        ''Do
        ''Console.WriteLine("input your first number")
        ''    inputnumberA = Console.ReadLine()
        ''    Console.WriteLine("input your s number")
        ''inputnumberA = Console.ReadLine()
        ''inputnumberB = inputnumberA
        ''formular_int = Convert.ToInt32(inputformular)
        ''formular_int = CInt(inputformular)
        ''formular_int = Convert.ToInt32(inputformular)        'Dim inputnumberA As String
        'Dim inputnumberB As Int32
        'Dim resultCalculated As Int32
        'Dim continueProcess As String
        ''Do
        ''Console.WriteLine("input your first number")
        ''    inputnumberA = Console.ReadLine()
        ''    Console.WriteLine("input your s number")
        ''inputnumberA = Console.ReadLine()
        ''inputnumberB = inputnumberA
        ''formular_int = Convert.ToInt32(inputformular)
        ''formular_int = CInt(inputformular)
        ''formular_int = Convert.ToInt32(inputformular)
        'Loop
        ' For
        'Dim i As Int32
        'Dim input As String
        'Console.WriteLine("Input your wordddddddddddddddddddddddddddddddddddddd")
        'input = Console.ReadLine()
        'For i = 1 To 10
        '    Console.WriteLine(input)
        'Next
        'Dim i As Integer = 1
        'Dim inputNumber As Integer
        'Console.WriteLine("enter a number")
        'inputNumber = Console.ReadLine()
        'For i = 0 To inputNumber
        '    Console.WriteLine((i + 1) * inputNumber)
        '    i = i + 1
        'Next
        'Dim inputLetter As String
        'Console.WriteLine("Enter a letter")
        'inputLetter = Console.ReadLine()
        'Select Case inputLetter.ToUpper
        '    Case "A"
        '        For i = 1 To 10
        '            Console.WriteLine("America")
        '        Next
        '    Case "B"
        '        For i = 1 To 10
        '            Console.WriteLine("Britain")
        '        Next
        '    Case "C"
        '        For i = 1 To 10
        '            Console.WriteLine("China")
        '        Next
        '    Case Else
        '        Console.WriteLine("failed")
        'End Select        'Dim inputLetter As String
        'Console.WriteLine("Enter a letter")
        'inputLetter = Console.ReadLine()
        'Select Case inputLetter.ToUpper
        '    Case "A"
        '        For i = 1 To 10
        '            Console.WriteLine("America")
        '        Next
        '    Case "B"
        '        For i = 1 To 10
        '            Console.WriteLine("Britain")
        '        Next
        '    Case "C"
        '        For i = 1 To 10
        '            Console.WriteLine("China")
        '        Next
        '    Case Else
        '        Console.WriteLine("failed")
        'End Select
        'Dim userChooseLoopInt As Int32
        'Dim userStartingNumberInt As Int32
        'Dim userEndingNumberInt As Int32
        'Console.WriteLine("Please type a number to choose your loop :(")
        'userChooseLoopInt = Console.ReadLine()
        'Console.WriteLine("Please type number 2 =_=")
        'userStartingNumberInt = Console.ReadLine()
        'Console.WriteLine("I know it's boring, but please enter a number QAQ. It need to be larger than the number 2")
        'userEndingNumberInt = Console.ReadLine()
        'Select Case userChooseLoopInt
        '    Case 1
        '        Do While userStartingNumberInt < userEndingNumberInt
        '            Console.WriteLine("QQ")
        '            userStartingNumberInt = userStartingNumberInt + 1
        '        Loop
        '    Case 2
        '        Do While Not userStartingNumberInt > userEndingNumberInt
        '            Console.WriteLine("QQ")
        '            userStartingNumberInt = userStartingNumberInt + 1
        '        Loop
        '    Case 3
        '        Do Until userStartingNumberInt = userEndingNumberInt
        '            Console.WriteLine("QQ")
        '            userStartingNumberInt = userStartingNumberInt + 1
        '        Loop
        '    Case 4
        '        For userStartingNumberInt = userStartingNumberInt To userEndingNumberInt - 1
        '            Console.WriteLine("QQ")
        '        Next
        '    Case Else
        '        Console.WriteLine("vgweyuirbfugeribfg")


        'End Select
        Console.ReadKey()

    End Sub
End Module
