<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Borrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Gpo_dp = New System.Windows.Forms.GroupBox()
        Me.TB_Especialidad = New System.Windows.Forms.TextBox()
        Me.TB_Telefono = New System.Windows.Forms.TextBox()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Matrícula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_Buscar = New System.Windows.Forms.TextBox()
        Me.LBL_Registro = New System.Windows.Forms.Label()
        Me.Dg_Datos = New System.Windows.Forms.DataGridView()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_VerTodos = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Gpo_dp.SuspendLayout()
        CType(Me.Dg_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(43, 25)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(133, 23)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(182, 25)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(150, 23)
        Me.Btn_Actualizar.TabIndex = 1
        Me.Btn_Actualizar.Text = "ACTUALIZAR"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Borrar
        '
        Me.Btn_Borrar.Location = New System.Drawing.Point(338, 25)
        Me.Btn_Borrar.Name = "Btn_Borrar"
        Me.Btn_Borrar.Size = New System.Drawing.Size(140, 23)
        Me.Btn_Borrar.TabIndex = 2
        Me.Btn_Borrar.Text = "BORRAR"
        Me.Btn_Borrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATRICULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DIRECCIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TELÉFONO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ESPECIALIDAD"
        '
        'Gpo_dp
        '
        Me.Gpo_dp.Controls.Add(Me.TB_Especialidad)
        Me.Gpo_dp.Controls.Add(Me.TB_Telefono)
        Me.Gpo_dp.Controls.Add(Me.TB_Direccion)
        Me.Gpo_dp.Controls.Add(Me.TB_Nombre)
        Me.Gpo_dp.Controls.Add(Me.TB_Matrícula)
        Me.Gpo_dp.Controls.Add(Me.Label1)
        Me.Gpo_dp.Controls.Add(Me.Label5)
        Me.Gpo_dp.Controls.Add(Me.Label2)
        Me.Gpo_dp.Controls.Add(Me.Label4)
        Me.Gpo_dp.Controls.Add(Me.Label3)
        Me.Gpo_dp.Location = New System.Drawing.Point(5, 78)
        Me.Gpo_dp.Name = "Gpo_dp"
        Me.Gpo_dp.Size = New System.Drawing.Size(240, 174)
        Me.Gpo_dp.TabIndex = 8
        Me.Gpo_dp.TabStop = False
        Me.Gpo_dp.Text = "Datos Personales"
        '
        'TB_Especialidad
        '
        Me.TB_Especialidad.Location = New System.Drawing.Point(93, 121)
        Me.TB_Especialidad.Name = "TB_Especialidad"
        Me.TB_Especialidad.Size = New System.Drawing.Size(126, 20)
        Me.TB_Especialidad.TabIndex = 12
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Location = New System.Drawing.Point(93, 95)
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.Size = New System.Drawing.Size(126, 20)
        Me.TB_Telefono.TabIndex = 11
        '
        'TB_Direccion
        '
        Me.TB_Direccion.Location = New System.Drawing.Point(93, 68)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(126, 20)
        Me.TB_Direccion.TabIndex = 10
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(93, 42)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(126, 20)
        Me.TB_Nombre.TabIndex = 9
        '
        'TB_Matrícula
        '
        Me.TB_Matrícula.Location = New System.Drawing.Point(93, 19)
        Me.TB_Matrícula.Name = "TB_Matrícula"
        Me.TB_Matrícula.Size = New System.Drawing.Size(126, 20)
        Me.TB_Matrícula.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "BUSCAR"
        '
        'Tb_Buscar
        '
        Me.Tb_Buscar.Location = New System.Drawing.Point(323, 94)
        Me.Tb_Buscar.Name = "Tb_Buscar"
        Me.Tb_Buscar.Size = New System.Drawing.Size(115, 20)
        Me.Tb_Buscar.TabIndex = 10
        '
        'LBL_Registro
        '
        Me.LBL_Registro.AutoSize = True
        Me.LBL_Registro.Location = New System.Drawing.Point(445, 96)
        Me.LBL_Registro.Name = "LBL_Registro"
        Me.LBL_Registro.Size = New System.Drawing.Size(63, 13)
        Me.LBL_Registro.TabIndex = 11
        Me.LBL_Registro.Text = "REGISTRO"
        '
        'Dg_Datos
        '
        Me.Dg_Datos.AllowUserToAddRows = False
        Me.Dg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Datos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Datos.Location = New System.Drawing.Point(251, 120)
        Me.Dg_Datos.Name = "Dg_Datos"
        Me.Dg_Datos.ReadOnly = True
        Me.Dg_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Datos.Size = New System.Drawing.Size(564, 260)
        Me.Dg_Datos.TabIndex = 12
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(170, 357)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 13
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_VerTodos
        '
        Me.Btn_VerTodos.Location = New System.Drawing.Point(708, 91)
        Me.Btn_VerTodos.Name = "Btn_VerTodos"
        Me.Btn_VerTodos.Size = New System.Drawing.Size(107, 23)
        Me.Btn_VerTodos.TabIndex = 14
        Me.Btn_VerTodos.Text = "VER TODOS"
        Me.Btn_VerTodos.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 52)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Reynaldo Tamez Vicencio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matrícula: 2013116" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo 307" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N.L. 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(827, 392)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_VerTodos)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Dg_Datos)
        Me.Controls.Add(Me.LBL_Registro)
        Me.Controls.Add(Me.Tb_Buscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Gpo_dp)
        Me.Controls.Add(Me.Btn_Borrar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Name = "FrmAlumnos"
        Me.Text = "RTV_Conexión alumnos con SQL"
        Me.Gpo_dp.ResumeLayout(False)
        Me.Gpo_dp.PerformLayout()
        CType(Me.Dg_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Borrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Gpo_dp As GroupBox
    Friend WithEvents TB_Especialidad As TextBox
    Friend WithEvents TB_Telefono As TextBox
    Friend WithEvents TB_Direccion As TextBox
    Friend WithEvents TB_Nombre As TextBox
    Friend WithEvents TB_Matrícula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_Buscar As TextBox
    Friend WithEvents LBL_Registro As Label
    Friend WithEvents Dg_Datos As DataGridView
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_VerTodos As Button
    Friend WithEvents Label8 As Label
End Class
