Imports System.Threading
Imports System.Threading.Tasks

Module Module1

    Dim limit As Integer = 1000000
    Dim constant As Integer = 50

    Sub Main()

        para(limit)
        notPara(limit)

        Console.Write("Press Enter")
        Console.ReadLine()

    End Sub

    Private Sub notPara(ByVal limit As Integer)
        Dim builtDict As New Dictionary(Of String, Double)

        Console.WriteLine("Start not parallel")

        Dim sw As New Stopwatch
        sw.Start()

        For Each num As Integer In Enumerable.Range(1, limit)
            Dim result As Double = fact(constant)
            builtDict.Add(num.ToString, result)
            Dim res As Double = builtDict(num.ToString)
            'Console.WriteLine("Non Para result of " & num.ToString & " = " & result)
        Next

        sw.Stop()

        LogTime("Not Parallel ", builtDict, sw)

    End Sub

    Private Sub para(ByVal limit As Integer)
        Dim builtDict As New Concurrent.ConcurrentDictionary(Of String, Double)

        Console.WriteLine("Start parallel")

        Dim sw As New Stopwatch
        sw.Start()

        System.Threading.Tasks.Parallel.ForEach(Enumerable.Range(1, limit), Sub(num)
                                                                                Dim result As Double = fact(constant)
                                                                                builtDict.TryAdd(num.ToString, result)
                                                                                Dim res As Double = builtDict(num.ToString)
                                                                                'Console.WriteLine("Para result of " & num.ToString & " = " & result)
                                                                            End Sub)

        sw.Stop()

        LogTime("Parallel ", builtDict, sw)

    End Sub

    Private Sub LogTime(ByVal Tag As String, ByVal builtDict As Dictionary(Of String, Double), ByVal sw As Stopwatch)
        Console.WriteLine(Tag & " List of " & builtDict.Count.ToString & " items. Duration: " & sw.ElapsedMilliseconds.ToString & " milliseconds")
        Console.WriteLine()
    End Sub

    Private Sub LogTime(ByVal Tag As String, ByVal builtDict As Concurrent.ConcurrentDictionary(Of String, Double), ByVal sw As Stopwatch)
        Console.WriteLine(Tag & " List of " & builtDict.Count.ToString & " items. Duration: " & sw.ElapsedMilliseconds.ToString & " milliseconds")
        Console.WriteLine()
    End Sub

    Private Function fact(ByVal x As Integer) As Double

        'Thread.Sleep(1000)
        'Return x

        If x = 1 Then
            Return 1
        Else
            Return fact(x - 1) * x
        End If
    End Function
End Module
