Public Class WordLookup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GetVersions()
        End If
    End Sub

    Private Sub btnGetDef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetDef.Click
        Dim defSvc As New Definitions()
        lblDefinition.Text = "'" & txtWord.Text & "' - " & defSvc.GetDefinition(txtWord.Text)
        defSvc = Nothing
    End Sub

    Private Sub GetVersions()
        Dim version As New Text.StringBuilder

        Dim myVersion As Reflection.AssemblyName = Reflection.Assembly.GetExecutingAssembly.GetName()
        version.AppendLine(myVersion.Name & " version: " & myVersion.Version.ToString)

        lblVersion.Text = version.ToString

    End Sub
End Class