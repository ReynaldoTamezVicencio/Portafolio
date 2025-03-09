Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Public Class HoraServidor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Muestra la hora actual del servidor en horalabel'
        'horaLabel.Text = Now.ToLongTimeString'
    End Sub

    Protected Sub horaButton_Click(sender As Object, e As EventArgs) Handles horaButton.Click
        'muestra la hora actual del servidor en horaLabel'
        horaLabel.Text = Now.ToLongTimeString
    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class