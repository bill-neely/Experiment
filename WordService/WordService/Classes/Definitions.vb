Friend Class Definitions


    Friend Shared Function GetDefinition(ByVal Word As String) As String
        Return defs(Word)
    End Function

    Private Shared Function defs(ByVal word As String) As String
        Dim myDictionary As New Dictionary(Of String, String)
        myDictionary.Add("test", "the trial of the quality of something")
        myDictionary.Add("hello", "used to express a greeting, answer a telephone, or attract attention")

        If myDictionary.ContainsKey(word.ToLower) Then
            Return myDictionary(word.ToLower)
        Else
            Return "I do not know what '" & word & "' means"
        End If
    End Function
End Class
