<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TABLAS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_TABLA = New System.Windows.Forms.Label()
        Me.tb_TI = New System.Windows.Forms.TextBox()
        Me.tb_TF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Desplegar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "elije de qué tabla "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De la:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "A la:"
        '
        'lbl_TABLA
        '
        Me.lbl_TABLA.AutoSize = True
        Me.lbl_TABLA.Location = New System.Drawing.Point(129, 172)
        Me.lbl_TABLA.Name = "lbl_TABLA"
        Me.lbl_TABLA.Size = New System.Drawing.Size(0, 13)
        Me.lbl_TABLA.TabIndex = 3
        '
        'tb_TI
        '
        Me.tb_TI.Location = New System.Drawing.Point(66, 81)
        Me.tb_TI.Name = "tb_TI"
        Me.tb_TI.Size = New System.Drawing.Size(58, 20)
        Me.tb_TI.TabIndex = 4
        '
        'tb_TF
        '
        Me.tb_TF.Location = New System.Drawing.Point(199, 81)
        Me.tb_TF.Name = "tb_TF"
        Me.tb_TF.Size = New System.Drawing.Size(58, 20)
        Me.tb_TF.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Star Jedi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 35)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "a qué tabla quieres"
        '
        'btn_Desplegar
        '
        Me.btn_Desplegar.BackColor = System.Drawing.Color.Aqua
        Me.btn_Desplegar.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Desplegar.Location = New System.Drawing.Point(89, 107)
        Me.btn_Desplegar.Name = "btn_Desplegar"
        Me.btn_Desplegar.Size = New System.Drawing.Size(128, 62)
        Me.btn_Desplegar.TabIndex = 7
        Me.btn_Desplegar.Text = "desplegar tabla"
        Me.btn_Desplegar.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Limpiar.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(185, 358)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(106, 33)
        Me.btn_Limpiar.TabIndex = 8
        Me.btn_Limpiar.Text = "limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.Yellow
        Me.btn_volver.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(185, 394)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(106, 33)
        Me.btn_volver.TabIndex = 9
        Me.btn_volver.Text = "volver"
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reynaldo Tamez Vicencio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Matrícula: 2013116"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "N.L 22"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Grupo: 207"
        '
        'TABLAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(290, 439)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Desplegar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_TF)
        Me.Controls.Add(Me.tb_TI)
        Me.Controls.Add(Me.lbl_TABLA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TABLAS"
        Me.Text = "TABLAS DE MULTIPLICAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_TABLA As Label
    Friend WithEvents tb_TI As TextBox
    Friend WithEvents tb_TF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Desplegar As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
