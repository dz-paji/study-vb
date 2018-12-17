dim i as Int32
' this is my counter

dim validationElement as Int32
' this is the variable used for validation.

dim inputNameArray(29) as String
' this is my array stores students' name

dim inputResult1Array(29) as Int32
' this is my array stores students first test results

dim inputResult2Array(29) as Int32
' this is my array stores students 2nd test results

dim inputResult3Array(29) as Int32
' this is my array stores students 3rd test results

dim inputResult as Int32
' this is the variable used for user inout their mark.

for i = 0 to 29 then
' this is the start of my for loop

    Console.WriteLine("Please enter your name XD")
    ' let user input their name

    inputNameArray(i) = Console.ReadLine()
    ' store their name in the array.

    Console.WriteLine("Please enter the first result of the test")
    inputResult = Console.ReadLine()

    

next
