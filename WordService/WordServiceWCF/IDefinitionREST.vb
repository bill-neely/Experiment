Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IDefinitionREST" in both code and config file together.
<ServiceContract()>
Public Interface IDefinitionREST

  

    '<OperationContract()> _
    '<WebInvoke(Method:="GET", UriTemplate:="json/{word}", BodyStyle:=WebMessageBodyStyle.Bare, RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)> _
    'Function jsonData(ByVal word As String) As String

    '<OperationContract()> _
    '    <WebGet(UriTemplate:="json/{word}", BodyStyle:=WebMessageBodyStyle.Wrapped, RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)> _
    'Function jsonData(ByVal word As String) As String

    <OperationContract()> _
    <WebInvoke(Method:="GET", UriTemplate:="json/{word}", BodyStyle:=WebMessageBodyStyle.Wrapped, RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)> _
    Function jsonData(ByVal word As String) As String



End Interface
