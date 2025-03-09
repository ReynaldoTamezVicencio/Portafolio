Public Class Hobbie
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class