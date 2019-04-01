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

        Dim itemBid(999) As String
        ' declear a string array used to store the number of bids of each item

        Dim buyerNumber(999) As Integer
        ' declear an integer variable used to store the buyer number

        Dim buyerBid(999) As String
        ' declear a string array used to store the bids of buyers

        Dim itemHBid(999) As String
        ' declear a string array used to store the highest bid of each item.

        Dim isBid As Boolean
        ' declear a boolean variable used to check the state of buyer bids

        ' Dim result As String
        ' declear a variable used to store the array query result

        Dim isSold(999) As String
        ' declear a string array to store the sell status of an item

        Dim auctionFee(999) As String
        ' declear a string array to store the auction fee

        Dim feeCounter As Integer = 0
        ' declear a integer variable as the counter of the fee calculator loop

        Dim totalAuctionFee As Decimal = 0
        ' declear a integer variable to store the total auction fee

        Dim finalBid(999) As Integer
        ' declear an array variable to store the final bid of any item.

        Dim itemCounter As Integer
        ' declear an variable to be used as the counter

        Dim numberSold As Integer
        ' declear an variable to store the number of solden item(s)

        Dim totalNumberBid As Integer = 0
        ' declear an variable to store the total number of items has 0 bid

        Dim numberUnsold As Integer
        ' declear an variable used to store the status of the highest bid


        For itemCounter = 0 To 9
            ' the for loop used to let all the sellers to enter information about their items

            Console.WriteLine("Please enter your item's name.")
            ' let the seller entering their item name

            itemName(itemCounter) = Console.ReadLine()
            ' seller enter the name, and stored in the array

            Console.WriteLine("Please enter the description for your item.")
            ' let the seller entering their item description

            itemdesc(itemCounter) = Console.ReadLine()
            ' seller enter the description, and stored in the array

            Console.WriteLine("Please enter the reserve price of your item")
            ' let the seller entering the reserve price of the item

            userInput = Console.ReadLine()
            ' seller enter the reserve price to a temporary variable, waiting validation

            ' do until isnumric(userinput) = false
            If userInput < 0 Then
                ' use if to check if the price entered is valid

                Console.WriteLine("You can't have a reserve price lower than 0 !")
                ' if it is invalid, print out the error message

            Else
                ' when it's valid

                itemReservePrice(itemCounter) = userInput
                ' store the valid price in the array


            End If
            ' Ending of if.

        Next
        ' end of the for loop 

        isBid = True
        ' the the bid status to true so it can begin.

        i = 0
        ' initial variable i

        userInput = "Y"
        ' initial variable

        Do While userInput = "Y"
            ' do the loop when usr want to bid

            Console.WriteLine("Which item are you interested in? (Enter the item name)")
            ' let the buyer enter the item name they wish to bid

            userInput = Console.ReadLine()
            ' record user's inpput in userInput variable

            ' result = Enumerable.Range(0, itemName.Length).Where(Function(x) itemName(x).ToLower().Contains(userInput.ToLower()))

            If userInput > itemCounter Then
                ' validate the input

                Console.WriteLine("Sorry, this item currently not available.")
                ' error message

            Else
                'if no error detechted

                itemCounter = 0
                ' initial counter

                Do Until userInput = itemName(itemCounter)
                    ' use for loop to query the item



                    itemCounter = itemCounter + 1
                    ' counter + 1

                Loop

                ' query the array, find the item that maches with user's input and store that in variable result


                Do While itemHBid(itemCounter) Is Nothing
                    ' when the item doesn't have highest bid

                    itemHBid(itemCounter) = 0
                    ' set the highest bid to 0

                Loop
                ' end of the loop



                Console.WriteLine("The description of item {0} is {1}, and the current highest bid is {2}", itemCounter, itemdesc(itemCounter), itemHBid(itemCounter))
                ' output the descrption, item number and current highest bid.


            End If


            Console.WriteLine("Please enter your buyer id.")
            ' let the user enter their buyer id

            buyerNumber(i) = Console.ReadLine()
            ' store buyer number at buyerNumber variable

            Console.WriteLine("Please enter your bid. It must be higher than the current bid.")
            ' let the user enter their bid

            userInput = Console.ReadLine()
            ' store the bid in userInput variable

            finalBid(itemCounter) = userInput
            ' store the final bid of an item

            If finalBid(itemCounter) > itemHBid(itemCounter) Then
                ' if the bid that was entered whether higher than current highes

                buyerBid(itemCounter) = finalBid(itemCounter)
                ' store the bid that was entered

                itemHBid(itemCounter) = finalBid(itemCounter)
                ' store the highest bid for any item

                itemBid(itemCounter) = itemBid(itemCounter) + 1
                ' bid successful, so increase the number of bids of that item by 1 


            Else
                'otherwise

                Console.WriteLine("Sorry, the bid you enter must be higher than current highest bid")
                ' output error message

            End If
            ' end of if

            Console.WriteLine("Do you want to bid? Please enter Y if you'd like to, or N to exit this process")
            ' ask the buyer about whether to exit bids.

            userInput = Console.ReadLine().ToUpper
            ' record user's input in userInput variable

        Loop
        ' Continue the bid status untill the bid status was set to false

        For feeCounter = 0 To 1
            ' use for loop to calculate the fee

            If itemHBid(feeCounter) > itemReservePrice(feeCounter) Then
                ' if the highest item big is higher than the reserve price

                totalAuctionFee = totalAuctionFee + itemHBid(feeCounter) * 0.1
                ' calculate the action fee

                Console.WriteLine(totalAuctionFee)
                ' calculate the total auction fee

                numberSold = numberSold + 1
                Console.WriteLine(numberSold)

                'End If
                ' end of the if

                'If isSold(feeCounter) = True Then
                ' check if the item is sold

            Else

                Console.WriteLine("Item {0} didn't reach the reserve price. Its final bid is {1}", itemCounter, finalBid(itemCounter))
                ' output the item number, and final bid


                numberUnsold = numberUnsold + 1

            End If


        Next
        ' end of the for loop

        Console.WriteLine("The total auction fee is" & totalAuctionFee)
        ' output the total auction fee

        Console.WriteLine("Unsold itm: " & numberUnsold)

        For itemCounter = 0 To 9
            ' use for loop the display all unsole item info

            'If isSold(itemCounter) = "Y" Then
            '    ' the item is marked unsold

            '    Console.WriteLine("Item {0} didn't reach the reserve price. Its final bid is {1}", itemCounter, finalBid(itemCounter))
            '    ' output the item number, and final bid

            'Else
            '    ' otherwise

            '    numberSold = numberSold + 1
            '    ' increase solden item(s) by 1

            'End If
            'end of if

            If itemBid(itemCounter) = 0 Then
                ' check item(s) got zero bid

                Console.WriteLine("Item {0} didn't get any bid. ", itemCounter)
                ' returen their item number

                totalNumberBid = totalNumberBid + 1
                ' incrase the number of non bid items by 1

            End If
            ' end of that if


        Next
        ' end of the for loop

        Console.WriteLine("There's {0} item(s) not sold.", 10 - numberSold)
        ' output the number of non-sold item


        Console.WriteLine("There's total of {0} item(s) been sold", numberSold)
        ' output the total number of items been sold.
        Console.ReadKey()
    End Sub

End Module
