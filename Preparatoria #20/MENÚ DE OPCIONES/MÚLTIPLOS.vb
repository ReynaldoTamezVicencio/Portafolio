Public Class MULTIPLOS
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        MENÚ1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_2.Text = " "
        tb_3.Text = " "
        tb_7.Text = " "
    End Sub

    Private Sub btn_Contar_Click(sender As Object, e As EventArgs) Handles btn_Contar.Click
        'DECLARACIÓN DE VARIABLES, IGUALADAS A 0'
        Dim i, Co2, Co3, Co7 As Integer
        i = 0
        Co2 = 0
        Co3 = 0
        Co7 = 0
        'SE DIVIDEN LOS NUMEROS i ENTRE EL NÚMERO AL QUE LE VAMOS A SACAR MÚLTIPLO, i SE SUMA +1 Y
        'CONTINUA EL PROCESO CON TODOS LOS CONTADORES'
        For i = 1 To 350
            If i Mod 2 = 0 Then
                Co2 = Co2 + 1
            End If

            If i Mod 3 = 0 Then
                Co3 = Co3 + 1
            End If

            If i Mod 7 = 0 Then
                Co7 = Co7 + 1
            End If
            'LUGAR DONDE SE COLOCARÁN LA CANTIDAD DE MÚLTIPLOS'
        Next
        tb_2.Text = Co2
        tb_3.Text = Co3
        tb_7.Text = Co7

    End Sub

    Private Sub MULTIPLOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
