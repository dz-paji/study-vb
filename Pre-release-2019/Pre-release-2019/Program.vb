Imports System

Module Program
    Sub Main(args As String())
        Dim itemName(9) As String
        ' declear a string array used to store all the name of each item

        Dim itemPrice(9) As String
        ' declear a string array used to store all the pricing of each item

        Dim itemdesc(9) As String
        ' declear a string array used to store all the description of each item

        Dim userInput As String
        ' declear a string variable used to store users' input

        Dim itemReservePrice(9) As String
        ' declear a string array used to store all the reserve pricing of each item

        Dim i As Integer
        ' declear an integer variable as counter

        Dim itemBid(9) As String
        ' declear a string array used to store the number of bids of each item

        Dim buyerNumber As Integer
        ' declear an integer variable used to store the buyer number

        Dim buyerBid(9) As String
        ' declear a string array used to store the bids of buyers

        Dim itemHBid(9) As String
        ' declear a string array used to store the highest bid of each item.

        For i = 0 To 9
            ' the for loop used to let all the sellers to enter information about their items

            Console.WriteLine("Please enter your item's name.")
            ' let the seller entering their item name

            itemName(i) = Console.ReadLine()
            ' seller enter the name, and stored in the array

            Console.WriteLine("Please enter the description for your item.")
            ' let the seller entering their item description

            itemdesc(i) = Console.ReadLine()
            ' seller enter the description, and stored in the array

            Console.WriteLine("Please enter the reserve price of your item")
            ' let the seller entering the reserve price of the item

            userInput = Console.ReadLine()
            ' seller enter the reserve price to a temporary variable, waiting validation

            Do While userInput < 0
                ' use do while loop to check if the price entered is valid

                Console.WriteLine("You can't have a reserve price lower than 0 !")
                ' if it is invalid, print out the error message
            Loop
            ' ending of the loop 

            itemReservePrice(i) = userInput
            ' store the valid price in the array

        Next
        ' end of the for loop 
    End Sub
End Module
