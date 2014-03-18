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



        req = WebRequest.Create("http://default-environment-zg2axpn3f3.elasticbeanstalk.com/RestService/" & uri & "/" & txtParm.Text)
        'req = WebRequest.Create("http://localhost:8181/RestService/" & uri & "/" & txtParm.Text)
        req.Proxy = New System.Net.WebProxy("72.37.249.115", 8080)
        resp = req.GetResponse()
        'Dim respStream As System.IO.StreamReader = New System.IO.StreamReader(resp.GetResponseStream(), True)
        Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
        Dim respStream As System.IO.StreamReader = New System.IO.StreamReader(resp.GetResponseStream(), enc)


        Return Server.HtmlEncode(respStream.ReadToEnd())
        
    End Function
End Class