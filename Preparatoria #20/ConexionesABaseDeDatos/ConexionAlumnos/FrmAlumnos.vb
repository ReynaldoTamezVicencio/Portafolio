Public Class FrmAlumnos
    'REYNALDO TAMEZ VICENCIO'

    Private dt_datos As New Alumnos_307DataSet.Datos_AlumnosDataTable
    Private ta_datos As New Alumnos_307DataSetTableAdapters.Datos_AlumnosTableAdapter
    Private registro As Alumnos_307DataSet.Datos_AlumnosRow

    Private campollave As String
    Private editar As Boolean = False
    Private numeroregistro As String
    Private Sub FrmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dt_datos = Me.ta_datos.GetData()
        Dg_Datos.DataSource = Me.dt_datos
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        'Si la propiedad Editar está activa
        If (Me.editar) Then
            MsgBox(" Realizando Cambios ")
            registro = dt_datos.FindByMatrícula(Me.campollave)
            registro.Nombre = TB_Nombre.Text
            registro.Dirección = TB_Direccion.Text
            registro.Teléfono = TB_Telefono.Text
            registro.Especialidad = TB_Especialidad.Text



            'Actualizar la BD Original
            Try
                ta_datos.Update(dt_datos)
                MsgBox("Actualización Exitosa")
            Catch ex As Exception
                MsgBox("Error al Actualizar")
            End Try
            Me.editar = False
            Me.limpiarcajastexto()
        Else
            ' Código para Insertar un Nuevo Registro
            MsgBox(" Agregando un Nuevo Registro ")
            Me.registro = dt_datos.NewDatos_AlumnosRow()
            Me.registro.Matrícula = Val(TB_Matrícula.Text)
            Me.registro.Nombre = TB_Nombre.Text
            Me.registro.Dirección = TB_Direccion.Text
            Me.registro.Teléfono = TB_Telefono.Text
            Me.registro.Especialidad = Val(TB_Especialidad.Text)



            ' agregar registros al datatable
            dt_datos.AddDatos_AlumnosRow(Me.registro)
            ' actualizar la BD del tableadapter
            ta_datos.Update(dt_datos)



            Me.limpiarcajastexto()
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Me.editar = True
        cargardatosencajatexto()
    End Sub

    Private Sub cargardatosencajatexto()
        Me.campollave = Dg_Datos.CurrentRow.Cells.Item(0).Value.ToString
        Me.TB_Nombre.Text = Dg_Datos.CurrentRow.Cells.Item(1).Value.ToString
        Me.TB_Direccion.Text = Dg_Datos.CurrentRow.Cells.Item(2).Value.ToString
        Me.TB_Telefono.Text = Dg_Datos.CurrentRow.Cells.Item(3).Value.ToString
        Me.TB_Especialidad.Text = Dg_Datos.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

    Private Sub limpiarcajastexto()
        TB_Matrícula.Text = " "
        TB_Nombre.Text = " "
        TB_Direccion.Text = " "
        TB_Telefono.Text = " "
        TB_Especialidad.Text = " "
    End Sub

    Private Sub Dg_Datos_SelectionChanged(sender As Object, e As EventArgs) Handles Dg_Datos.SelectionChanged
        Lbl_Registro.Text = Dg_Datos.CurrentRow.Index.ToString
        Me.numeroregistro = Dg_Datos.CurrentRow.Index.ToString
    End Sub

    Private Sub Btn_Borrar_Click(sender As Object, e As EventArgs) Handles Btn_Borrar.Click
        MsgBox(" Eliminando Registro ")
        Me.registro = dt_datos.Rows(Me.numeroregistro)
        registro.Delete()
        ta_datos.Update(dt_datos)
    End Sub

    Private Sub Btn_VerTodos_Click(sender As Object, e As EventArgs) Handles Btn_VerTodos.Click
        Me.dt_datos = Me.ta_datos.GetData()
        Dg_Datos.DataSource = Me.dt_datos
    End Sub

    Private Sub Tb_Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Buscar.KeyPress
        dt_datos = ta_datos.GetDataByNombreAlumno(Tb_Buscar.Text)
        Dg_Datos.DataSource = dt_datos
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        End
    End Sub
End Class
