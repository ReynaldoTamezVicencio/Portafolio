Public Class MENÚ1
    Private Sub btn_promedios_Click(sender As Object, e As EventArgs) Handles btn_promedios.Click
        PROMEDIO.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_Tabla_Click(sender As Object, e As EventArgs) Handles btn_Tabla.Click
        TABLAS.Show()
        Me.Hide()
    End Sub

    Private Sub btn_multiplos_Click(sender As Object, e As EventArgs) Handles btn_multiplos.Click
        MULTIPLOS.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tarjeta_Click(sender As Object, e As EventArgs) Handles btn_tarjeta.Click
        'DESPLEGAR PROGRAMA DE TARJETA O EFECTIVO'
        TARJETA.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub MENÚ1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
