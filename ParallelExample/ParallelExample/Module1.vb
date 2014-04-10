Imports System.Threading
Imports System.Threading.Tasks

Module Module1

    Dim limit As Integer = 150

    Sub Main()
        Dim myList As New List(Of Integer)
        Dim count As Integer = 1
        Do While count <= limit
            myList.Add(count)
            count += 1
        Loop

        para(myList)
        notPara(myList)


        Console.Write("Press Enter")
        Console.ReadLine()

    End Sub

    Private Sub notPara(ByVal myList As List(Of Integer))
        Dim start As Date = Date.Now

        For Each num As Integer In myList
            Console.WriteLine("nonpara Factorial of " & num.ToString & " = " & fact(num))
        Next

        Dim finish As Date = Date.Now()
        LogTime("notPara", start, finish)

    End Sub

    Private Sub para(ByVal myList As List(Of Integer))
        Dim start As Date = Date.Now
        Console.WriteLine(start.ToString)

        System.Threading.Tasks.Parallel.ForEach(myList, Sub(num)
                                                            Console.WriteLine("Para Factorial of " & num.ToString & " = " & fact(num))
                                                        End Sub)


        Dim finish As Date = Date.Now()
        Console.WriteLine(finish.ToString)

        LogTime("para", start, finish)

    End Sub

    Private Sub LogTime(ByVal Tag As String, ByVal start As Date, ByVal finish As Date)
        Dim span As TimeSpan = finish - start
        Console.WriteLine(Tag & "Duration: " & span.TotalMilliseconds.ToString & " milliseconds")
    End Sub

    Private Function fact(ByVal x As Integer) As Double

        Thread.Sleep(1000)
        Return x

        If x = 1 Then
            Return 1
        Else
            Return fact(x - 1) * x
        End If
    End Function
End Module
