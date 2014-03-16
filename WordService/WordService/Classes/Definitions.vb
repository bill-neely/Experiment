Imports MySql.Data.MySqlClient

Friend Class Definitions

    Friend Function GetDefinition(ByVal Word As String) As String
        Return getDef(Word)
    End Function

    Private Function defs(ByVal word As String) As String
        Dim myDictionary As New Dictionary(Of String, String)
        myDictionary.Add("test", "the trial of the quality of something")
        myDictionary.Add("hello", "used to express a greeting, answer a telephone, or attract attention")

        If myDictionary.ContainsKey(word.ToLower) Then
            Return myDictionary(word.ToLower)
        Else
            Return "I do not know what '" & word & "' means"
        End If
    End Function

    Public Sub New()

    End Sub

    Private Function getDef(ByVal word As String) As String
        Dim def As String

        Dim sqlConn As MySqlConnection
        sqlConn = New MySqlConnection(Definitions.connection)
        sqlConn.Open()

        Dim sql As String = "select theDefinition from Words where theword = '" & word.ToLower.Trim & "'"
        Dim cmd = New MySqlCommand(sql, sqlConn)
        def = CStr(cmd.ExecuteScalar)
        cmd.Dispose()
        cmd = Nothing

        sqlConn.Close()
        sqlConn = Nothing

        Return def
    End Function

    Friend Shared ReadOnly Property connection As String
        Get
            Dim cs As String = "None"
            Try
                Dim appConfig As NameValueCollection = ConfigurationManager.AppSettings
                Dim dbname As String = appConfig("RDS_DB_NAME")
                Dim username As String = appConfig("RDS_USERNAME")
                Dim password As String = appConfig("RDS_PASSWORD")
                Dim hostname As String = appConfig("RDS_HOSTNAME")
                Dim port As String = appConfig("RDS_PORT")
                cs = "server=" + hostname + ";user=" + username + ";database=" + dbname + ";port=" + port + ";password=" + password + ";"
            Catch ex As Exception
                cs = ex.Message
            End Try
            Return cs
        End Get
    End Property


End Class
