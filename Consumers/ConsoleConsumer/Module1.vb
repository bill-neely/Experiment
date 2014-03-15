Imports ConsoleConsumer.ServiceReference

Module Module1

    Sub Main()
        ' Use the 'client' variable to call operations on the service.
        Dim client As DefinitionClient = New DefinitionClient()
        Dim word As String
        Dim finished As Boolean = False

        Do While Not finished
            Console.Write("Enter a Word (blank to exit): ")
            word = Console.ReadLine()
            If word = "" Then
                finished = True
            Else
                Dim answer As String
                Try
                    answer = client.GetDefinition(word)
                    Console.WriteLine("'" & word & "' means - " & answer)
                Catch ex As Exception
                    Console.WriteLine("Error: " & ex.Message)
                End Try

                Console.WriteLine()
            End If
        Loop

        ' Always close the client.
        client.Close()
    End Sub

End Module
