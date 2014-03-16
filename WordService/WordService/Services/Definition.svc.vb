' NOTE: You can use the "Rename" command on the context menu to change the class name "Definition" in code, svc and config file together.
Public Class Definition
    Implements IDefinition

    Public Function GetDefintion(ByVal word As String) As String Implements IDefinition.GetDefinition
        Dim defSvc As New Definitions()
        Return defSvc.GetDefinition(word)
    End Function

End Class
