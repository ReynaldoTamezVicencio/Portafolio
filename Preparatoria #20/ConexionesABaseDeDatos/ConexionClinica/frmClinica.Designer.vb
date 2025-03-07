<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.BTN_Actualizar = New System.Windows.Forms.Button()
        Me.BTN_Borrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_IdMedico = New System.Windows.Forms.TextBox()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_Telefono = New System.Windows.Forms.TextBox()
        Me.TB_Cedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Buscar = New System.Windows.Forms.TextBox()
        Me.LBL_Registro = New System.Windows.Forms.Label()
        Me.DG_Datos = New System.Windows.Forms.DataGridView()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_VerTodos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.Location = New System.Drawing.Point(17, 22)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(96, 40)
        Me.BTN_Guardar.TabIndex = 0
        Me.BTN_Guardar.Text = "GUARDAR"
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'BTN_Actualizar
        '
        Me.BTN_Actualizar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Actualizar.Location = New System.Drawing.Point(124, 22)
        Me.BTN_Actualizar.Name = "BTN_Actualizar"
        Me.BTN_Actualizar.Size = New System.Drawing.Size(121, 40)
        Me.BTN_Actualizar.TabIndex = 1
        Me.BTN_Actualizar.Text = "ACTUALIZAR"
        Me.BTN_Actualizar.UseVisualStyleBackColor = True
        '
        'BTN_Borrar
        '
        Me.BTN_Borrar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Borrar.Location = New System.Drawing.Point(254, 22)
        Me.BTN_Borrar.Name = "BTN_Borrar"
        Me.BTN_Borrar.Size = New System.Drawing.Size(96, 40)
        Me.BTN_Borrar.TabIndex = 2
        Me.BTN_Borrar.Text = "BORRAR"
        Me.BTN_Borrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Cedula)
        Me.GroupBox1.Controls.Add(Me.TB_Telefono)
        Me.GroupBox1.Controls.Add(Me.TB_Direccion)
        Me.GroupBox1.Controls.Add(Me.TB_Nombre)
        Me.GroupBox1.Controls.Add(Me.TB_IdMedico)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 153)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS PERSONALES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_MÉDICO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELÉFONO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CÉDULA"
        '
        'TB_IdMedico
        '
        Me.TB_IdMedico.Location = New System.Drawing.Point(94, 26)
        Me.TB_IdMedico.Name = "TB_IdMedico"
        Me.TB_IdMedico.Size = New System.Drawing.Size(139, 22)
        Me.TB_IdMedico.TabIndex = 5
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(94, 52)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(139, 22)
        Me.TB_Nombre.TabIndex = 6
        '
        'TB_Direccion
        '
        Me.TB_Direccion.Location = New System.Drawing.Point(94, 77)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(139, 22)
        Me.TB_Direccion.TabIndex = 7
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Location = New System.Drawing.Point(94, 102)
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.Size = New System.Drawing.Size(139, 22)
        Me.TB_Telefono.TabIndex = 8
        '
        'TB_Cedula
        '
        Me.TB_Cedula.Location = New System.Drawing.Point(94, 128)
        Me.TB_Cedula.Name = "TB_Cedula"
        Me.TB_Cedula.Size = New System.Drawing.Size(139, 22)
        Me.TB_Cedula.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(309, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "BUSCAR"
        '
        'TB_Buscar
        '
        Me.TB_Buscar.Location = New System.Drawing.Point(377, 81)
        Me.TB_Buscar.Name = "TB_Buscar"
        Me.TB_Buscar.Size = New System.Drawing.Size(117, 20)
        Me.TB_Buscar.TabIndex = 5
        '
        'LBL_Registro
        '
        Me.LBL_Registro.AutoSize = True
        Me.LBL_Registro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Registro.Location = New System.Drawing.Point(500, 83)
        Me.LBL_Registro.Name = "LBL_Registro"
        Me.LBL_Registro.Size = New System.Drawing.Size(60, 16)
        Me.LBL_Registro.TabIndex = 6
        Me.LBL_Registro.Text = "Registro"
        '
        'DG_Datos
        '
        Me.DG_Datos.AllowUserToAddRows = False
        Me.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Datos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Datos.Location = New System.Drawing.Point(309, 105)
        Me.DG_Datos.Name = "DG_Datos"
        Me.DG_Datos.ReadOnly = True
        Me.DG_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Datos.Size = New System.Drawing.Size(542, 266)
        Me.DG_Datos.TabIndex = 7
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Salir.Location = New System.Drawing.Point(228, 335)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 35)
        Me.BTN_Salir.TabIndex = 8
        Me.BTN_Salir.Text = "SALIR"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 64)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Reynaldo Tamez Vicencio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matrícula: 2013116" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo 307" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N.L: 21"
        '
        'BTN_VerTodos
        '
        Me.BTN_VerTodos.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerTodos.Location = New System.Drawing.Point(584, 73)
        Me.BTN_VerTodos.Name = "BTN_VerTodos"
        Me.BTN_VerTodos.Size = New System.Drawing.Size(127, 28)
        Me.BTN_VerTodos.TabIndex = 10
        Me.BTN_VerTodos.Text = "VER TODOS"
        Me.BTN_VerTodos.UseVisualStyleBackColor = True
        '
        'frmClinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(857, 380)
        Me.Controls.Add(Me.BTN_VerTodos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.DG_Datos)
        Me.Controls.Add(Me.LBL_Registro)
        Me.Controls.Add(Me.TB_Buscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_Borrar)
        Me.Controls.Add(Me.BTN_Actualizar)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Name = "frmClinica"
        Me.Text = "RTV_CONEXIÓN A BASE DE DATOS DE CLÍNICA: TABLA MÉDICOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Guardar As Button
    Friend WithEvents BTN_Actualizar As Button
    Friend WithEvents BTN_Borrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Cedula As TextBox
    Friend WithEvents TB_Telefono As TextBox
    Friend WithEvents TB_Direccion As TextBox
    Friend WithEvents TB_Nombre As TextBox
    Friend WithEvents TB_IdMedico As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Buscar As TextBox
    Friend WithEvents LBL_Registro As Label
    Friend WithEvents DG_Datos As DataGridView
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_VerTodos As Button
End Class
