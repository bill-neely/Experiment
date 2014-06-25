Public Class BoostrapASP
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MyBase.OnLoad(e)
        Page.Header.DataBind()
    End Sub

End Class