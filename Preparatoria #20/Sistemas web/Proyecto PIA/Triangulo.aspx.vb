Public Class Triangulo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTNComprobar_Click(sender As Object, e As EventArgs) Handles BTNComprobar.Click
        Dim L1, L2, L3 As Integer
        Try
            L1 = TB_1.Text
            L2 = TB_2.Text
            L3 = TB_3.Text

            If L1 = L2 And L2 = L3 Then
                LBL1.Text = "Equilátero"
            ElseIf (L1 = L2 And L2 <> L3) Or (L1 <> L2 And L2 = L3) Or (L1 = L3 And L2 <> L3) Then
                LBL1.Text = "Isósceles"
            ElseIf (L1 <> L2 And L2 <> L3) Then
                LBL1.Text = "Escaleno"
            Else
                LBL1.Text = "Desconocido"
            End If
        Catch ex As Exception
            LBL1.Text = "Verifica las variables"
        End Try
    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class