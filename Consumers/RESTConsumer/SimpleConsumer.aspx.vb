Imports System.Net

Public Class SimpleConsumer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub btnCallService_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCallService.Click
        lblJSONResponse.Text = CallService("json")
        lblXMLResponse.Text = CallService("xml")

    End Sub

    Private Function CallService(ByVal uri As String) As String
        Dim req As WebRequest
        Dim resp As WebResponse

        'req = WebRequest.Create("http://default-environment-zg2axpn3f3.elasticbeanstalk.com/RestService/xml/" & txtParm.Text)
        req = WebRequest.Create("http://localhost:8181/RestService/" & uri & "/" & txtParm.Text)
        resp = req.GetResponse()
        Dim respStream As System.IO.StreamReader = New System.IO.StreamReader(resp.GetResponseStream(), True)
        Return Server.HtmlEncode(respStream.ReadToEnd())
        
    End Function
End Class