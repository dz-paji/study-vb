Imports System

Module Program
    Sub Main(args As String())
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
        Dim inputFruit As String
        Dim Fruitlower As String
        Console.WriteLine("Which fruit do you link? Apple, Orange, Bananas or Peach?")
        inputFruit = Console.ReadLine()
        Dim firstOutput As String = "You like " & inputFruit
        Fruitlower = inputFruit.ToLower
        Select Case Fruitlower
            Case "apple"
                Console.WriteLine(firstOutput & ". These are green and red")
            Case "orange"
                Console.WriteLine(firstOutput & ". These are orange... omg")
            Case "bananas"
                Console.WriteLine(firstOutput & ". Yellow, seriously")
            Case "peach"
                Console.WriteLine(firstOutput & ". Red on the outside but yellow inside")
            Case Else
                Console.WriteLine("Hey, you need to pick one.")
        End Select

        Console.ReadKey()

    End Sub
End Module
