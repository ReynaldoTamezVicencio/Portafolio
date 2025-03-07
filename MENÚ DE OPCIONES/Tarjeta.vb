Public Class TARJETA

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_SUMAR_Click(sender As Object, e As EventArgs) Handles btn_SUMAR.Click
        Dim CANT1, CANT2, CANT3, TOTAL As Decimal
        CANT1 = tb_CANT1.Text
        CANT2 = tb_CANT2.Text
        CANT3 = tb_CANT3.Text
        TOTAL = CANT1 + CANT2 + CANT3
        If TOTAL > 5000 Then
            lbl_RESULTADO.Text = "Tarjeta"

        Else
            lbl_RESULTADO.Text = "Efectivo"

        End If


    End Sub

    Private Sub Btn_SALIR_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        MENÚ1.Show()
        Me.Hide()
    End Sub

    Private Sub Lbl_RESULTADO_Click(sender As Object, e As EventArgs) Handles lbl_RESULTADO.Click

    End Sub


    Private Sub Lbl_RESULTADO_ClientSizeChanged(sender As Object, e As EventArgs) Handles lbl_RESULTADO.ClientSizeChanged

    End Sub

    Private Sub tb_CANT1_TextChanged(sender As Object, e As EventArgs) Handles tb_CANT1.TextChanged

    End Sub

    Private Sub btn_LIMPIAR_Click(sender As Object, e As EventArgs) Handles btn_LIMPIAR.Click
        tb_CANT1.Text = " "
        tb_CANT2.Text = " "
        tb_CANT3.Text = " "
        lbl_RESULTADO.Text = " "
    End Sub
End Class
