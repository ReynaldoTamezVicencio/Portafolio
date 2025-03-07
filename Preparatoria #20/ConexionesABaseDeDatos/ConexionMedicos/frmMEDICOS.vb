Public Class frmMEDICOS
    'REYNALDO TAMEZ VICENCIO'
    Private dtdatos As New CLÍNICA_VICENCIODataSet.MEDICOSDataTable
    Private tadatos As New CLÍNICA_VICENCIODataSetTableAdapters.MEDICOSTableAdapter
    Private registro As CLÍNICA_VICENCIODataSet.MEDICOSRow

    Private campollave As String
    Private editar As Boolean = False
    Private numeroregistro As String
    Private Sub frmMEDICOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtdatos = Me.tadatos.GetData()
        DG_Datos.DataSource = Me.dtdatos
    End Sub

    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        If (Me.editar) Then
            MsgBox("Realizando cambios")
            registro = dtdatos.Fin
            registro.Nombre = TB_Nombre.Text
            registro.Direccion = TB_Direccion.Text
            registro.Telefono = TB_Telefono.Text
            registro.Cedula = TB_Cedula.Text

            Try
                tadatos.Update(dtdatos)
                MsgBox("Actualización exitosa")
            Catch ex As Exception
                MsgBox("Error al actualizar")
            End Try
            Me.editar = False
            Me.limpiarcajastexto()

        Else
            MsgBox("Agregando un Nuevo Registro")
            Me.registro = dtdatos.NewMEDICOSRow()
            Me.registro.ID_Médico = Val(TB_Medico.Text)
            Me.registro.Nombre = TB_Nombre.Text
            Me.registro.Direccion = TB_Direccion.Text
            Me.registro.Telefono = TB_Telefono.Text
            Me.registro.Cedula = Val(TB_Cedula.Text)

            dtdatos.AddMEDICOSRow(Me.registro)
            tadatos.Update(dtdatos)
            Me.limpiarcajastexto()
        End If
    End Sub

    Private Sub BTN_Actualizar_Click(sender As Object, e As EventArgs) Handles BTN_Actualizar.Click
        Me.editar = True
        cargardatosencajatexto()
    End Sub

    Private Sub cargardatosencajatexto()
        Me.campollave = DG_Datos.CurrentRow.Cells.Item(0).Value.ToString
        Me.TB_Nombre.Text = DG_Datos.CurrentRow.Cells.Item(1).Value.ToString
        Me.TB_Direccion.Text = DG_Datos.CurrentRow.Cells.Item(2).Value.ToString
        Me.TB_Telefono.Text = DG_Datos.CurrentRow.Cells.Item(4).Value.ToString
        Me.TB_Cedula.Text = DG_Datos.CurrentRow.Cells.Item(5).Value.ToString
    End Sub

    Private Sub limpiarcajastexto()
        TB_Nombre.Text = " "
        TB_Direccion.Text = " "
        TB_Telefono.Text = " "
        TB_Cedula.Text = " "
    End Sub

    Private Sub DG_Datos_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Datos.SelectionChanged
        LBL_Registro.Text = DG_Datos.CurrentRow.Index.ToString
        Me.numeroregistro = DG_Datos.CurrentRow.Index.ToString
    End Sub

    Private Sub BTN_Borrar_Click(sender As Object, e As EventArgs) Handles BTN_Borrar.Click
        Me.registro = dtdatos.Rows(Me.numeroregistro)
        registro.Delete()
        tadatos.Update(dtdatos)
    End Sub

    Private Sub TB_Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Buscar.KeyPress
        dtdatos = tadatos.GetDataByNombreMedico(TB_Buscar.Text)
        DG_Datos.DataSource = dtdatos
    End Sub

    Private Sub BTN_VerTodos_Click(sender As Object, e As EventArgs) Handles BTN_VerTodos.Click
        Me.dtdatos = Me.tadatos.GetData()
        DG_Datos.DataSource = Me.dtdatos
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub
End Class

