Public Class PROMEDIO
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        tb_C1.Text = " "
        tb_C2.Text = " "
        tb_C3.Text = " "
        lbl_Resultado.Text = " "
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        MENÚ1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim C1, C2, C3, Resultado As Decimal
        C1 = tb_C1.Text
        C2 = tb_C2.Text
        C3 = tb_C3.Text
        Resultado = (C1 + C2 + C3) / 3
        lbl_Resultado.Text = Resultado


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
