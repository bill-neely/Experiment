Public Class WordLookup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GetVersions()
        End If
    End Sub

    Private Sub btnGetDef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetDef.Click
        lblDefinition.Text = "'" & txtWord.Text & "' - " & Definitions.GetDefinition(txtWord.Text)
    End Sub

    Private Sub GetVersions()
        Dim version As New Text.StringBuilder

        Dim myVersion As Reflection.AssemblyName = Reflection.Assembly.GetExecutingAssembly.GetName()
        lblVersion.Text = myVersion.Name & " version: " & myVersion.Version.ToString

    End Sub
End Class