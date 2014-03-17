' NOTE: You can use the "Rename" command on the context menu to change the class name "DefinitionREST" in code, svc and config file together.
Public Class DefinitionREST
    Implements IDefinitionREST

    Public Function jsonData(ByVal word As String) As String Implements IDefinitionREST.jsonData
        Return "From the jsonData function"
    End Function

    'Public Function xmlData(ByVal word As String) As String Implements IDefinitionREST.xmlData
    '    Return "From the xmlData function"
    'End Function

    'Public Function noParm(ByVal word As String) As String Implements IDefinitionREST.noParms
    '    Return "From the noParms function"
    'End Function

End Class
