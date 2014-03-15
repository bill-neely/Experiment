Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IDefinition" in both code and config file together.
<ServiceContract()>
Public Interface IDefinition

    <OperationContract()>
    Function GetDefinition(ByVal word As String) As String

End Interface
