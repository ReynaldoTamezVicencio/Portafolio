Public Class Calificaciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_Comprobar_Click(sender As Object, e As EventArgs) Handles BTN_Comprobar.Click
        Dim E1, E2, E3, E4, PIA, PP, SP, MC, GL, PROM As Decimal
        Try
            E1 = TB_E1.Text
            E2 = TB_E2.Text
            E3 = TB_E3.Text
            E4 = TB_E4.Text
            PIA = TB_PIA.Text
            PP = TB_ExPP.Text
            MC = TB_ExMT.Text
            SP = TB_ExSP.Text
            GL = TB_ExG.Text
            PROM = (E1 * 0.1) + (E2 * 0.1) + (E3 * 0.1) + (E4 * 0.1) + (PIA * 0.1) + (PP * 0.1) + (MC * 0.15) + (SP * 0.1) + (GL * 0.15)

            If PROM > 70 Then
                LBL_Resultado.Text = ":) Felicidades, acreditaste la unidad de aprendizaje " + PROM.ToString()
            Else
                LBL_Resultado.Text = ":( No acreditaste la unidad de aprendizaje " + PROM.ToString()
            End If

        Catch ex As Exception
            LBL_Resultado.Text = "Revisa los valores proporcionados"
        End Try
    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class