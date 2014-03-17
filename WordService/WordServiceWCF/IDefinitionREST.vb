Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IDefinitionREST" in both code and config file together.
<ServiceContract()>
Public Interface IDefinitionREST

    '<OperationContract()>
    '    <WebInvoke()>
    'Function noParms(ByVal word As String) As String

    <OperationContract()> _
    <WebInvoke(Method:="GET", UriTemplate:="json/{id}", BodyStyle:=WebMessageBodyStyle.Bare, RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)> _
    Function jsonData(ByVal word As String) As String

    <OperationContract()> _
    <WebInvoke(Method:="get", UriTemplate:="xml/{id]", BodyStyle:=WebMessageBodyStyle.Bare, RequestFormat:=WebMessageFormat.Xml, ResponseFormat:=WebMessageFormat.Xml)> _
    Function xmlData(ByVal word As String) As String



End Interface
