Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        ' declear user input temperature array
        Dim usrMiddayTemperatureArray(29) As Double
        Dim usrMidnightTemperatureArray(29) As Double

        'declear trans variable
        Dim transMdTemp As Double
        Dim trnasMntemp As Double


        ' declear variables needed
        Dim sysMiddayTemperatureAverage As Double = 0
        Dim sysMidnightTemperatureAverage As Double = 0
        Dim sysHMiddayTemperature As Double = 0
        Dim sysHMidnightTemperature As Double = 0

        'declear counter
        Dim counter As Int32

        'using for loop to record data and add total temperature
        For counter = 1 To 30

            Console.WriteLine("Please enter the midday temperature for day {0}", counter)
            transMdTemp = Console.ReadLine()

            'validation
            If transMdTemp > 40 Or transMdTemp < -30 Then
                Console.WriteLine("invalid data")
            Else
                usrMiddayTemperatureArray(counter) = transMdTemp
            End If

            Console.WriteLine("Please enter the midnight temperature for day {0}", counter)
            trnasMntemp = Console.ReadLine()

            If trnasMntemp > 40 Or trnasMntemp < -30 Then
                Console.WriteLine("invalid data")
            Else
                usrMiddayTemperatureArray(counter) = trnasMntemp
            End If
            sysMiddayTemperatureAverage = sysMiddayTemperatureAverage + usrMiddayTemperatureArray(counter)
            sysMidnightTemperatureAverage = sysMidnightTemperatureAverage + usrMidnightTemperatureArray(counter)

            ' compare and decide the highest temperature
            If usrMiddayTemperatureArray(counter) > sysHMiddayTemperature Then
                sysHMiddayTemperature = usrMiddayTemperatureArray(counter)
            End If
            If usrMidnightTemperatureArray(counter) > sysHMidnightTemperature Then
                sysHMidnightTemperature = usrMidnightTemperatureArray(counter)
            End If

        Next

        'calculate average
        sysMiddayTemperatureAverage = sysMiddayTemperatureAverage / 30
        sysMidnightTemperatureAverage = sysMidnightTemperatureAverage / 30

        'output data
        Console.WriteLine("The average midday temperature is {0}", sysMiddayTemperatureAverage)
        Console.WriteLine("The average midnight temperature is {0}", sysMidnightTemperatureAverage)
        Console.WriteLine("The highest midday temperature is {0}", sysHMiddayTemperature)
        Console.WriteLine("The highest midnight temperature is {0}", sysHMidnightTemperature)
        Console.ReadKey()


    End Sub
End Module
