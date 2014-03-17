
Friend Class Definitions

    Friend Function GetDefinition(ByVal Word As String) As String
        If Word.ToLower = "get connection" Then
            Return EnvironmentConnection
        End If
        Return defs(Word)
    End Function

    Private Function defs(ByVal word As String) As String
        Dim myDictionary As New Dictionary(Of String, String)
        myDictionary.Add("test", "the trial of the quality of something - from hardcode")
        myDictionary.Add("hello", "used to express a greeting, answer a telephone, or attract attention - from hardcode")

        If myDictionary.ContainsKey(word.ToLower) Then
            Return myDictionary(word.ToLower)
        Else
            Return "I do not know what '" & word & "' means"
        End If
    End Function

    Public Sub New()

    End Sub

    'Private Function getDef(ByVal word As String) As String
    '    Dim def As String

    '    Dim sqlConn As MySqlConnection
    '    sqlConn = New MySqlConnection(Definitions.connection)
    '    sqlConn.Open()

    '    Dim sql As String = "select theDefinition from Words where theword = '" & word.ToLower.Trim & "'"
    '    Dim cmd = New MySqlCommand(sql, sqlConn)
    '    def = CStr(cmd.ExecuteScalar)
    '    cmd.Dispose()
    '    cmd = Nothing

    '    sqlConn.Close()
    '    sqlConn = Nothing

    '    If def = "" Then
    '        Return "I do not know what '" & word & "' means - from SQL attempt"
    '    Else
    '        Return def & " - from SQL attempt"
    '    End If

    'End Function

    Friend Shared ReadOnly Property EnvironmentConnection As String
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

    Friend Shared ReadOnly Property connection As String
        Get
            Return "server=aaboom5og2k1tp.ct7eyw7ikemp.us-east-1.rds.amazonaws.com;user=BillNeely;database=ebdb;port=3306;password=labattBillNeely;"
        End Get
    End Property


End Class
