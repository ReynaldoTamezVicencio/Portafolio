Public Class TABLAS
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        lbl_TABLA.Text = " "
        tb_TI.Text = " "
        tb_TF.Text = " "
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        MENÚ1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Desplegar_Click(sender As Object, e As EventArgs) Handles btn_Desplegar.Click
        'DECLARAR VARIABLES
        Dim i, j As Integer
        Dim valinicial, valfinal As Integer

        'ASIGNAR LOS VALORES DE LAS TABLAS (DADAS EN EL TEXTO) A MIS VARIABLES NUMÉRICAS'
        valinicial = tb_TI.Text
        valfinal = tb_TF.Text

        'CICLO i CONTROLA LAS TABLAS'
        For i = valinicial To valfinal

            'CICLO j CONTROLA EL DESPLIEGUE DE LA TABLA i'
            For j = 1 To 10
                lbl_TABLA.Text = lbl_TABLA.Text & i & "x" & j & "=" & i * j & vbCrLf

            Next j
            MsgBox("Se desplegó la tabla del" & " " & i & vbCrLf & "Enter para continuar")
            lbl_TABLA.Text = " "
        Next i
    End Sub
End Class
