<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROMEDIO
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.tb_C1 = New System.Windows.Forms.TextBox()
        Me.tb_C2 = New System.Windows.Forms.TextBox()
        Me.tb_C3 = New System.Windows.Forms.TextBox()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "promedios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "calificación 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "calificación 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "calificación 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reynaldo Tamez Vicencio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Matrícula: 2013116"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "N.L 22"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Grupo: 207 "
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_limpiar.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(176, 239)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(96, 29)
        Me.btn_limpiar.TabIndex = 8
        Me.btn_limpiar.Text = "limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.Gold
        Me.btn_volver.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(176, 270)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(96, 30)
        Me.btn_volver.TabIndex = 9
        Me.btn_volver.Text = "volver"
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.Cyan
        Me.btn_calcular.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(15, 163)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(131, 56)
        Me.btn_calcular.TabIndex = 10
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'tb_C1
        '
        Me.tb_C1.Location = New System.Drawing.Point(133, 47)
        Me.tb_C1.Name = "tb_C1"
        Me.tb_C1.Size = New System.Drawing.Size(43, 20)
        Me.tb_C1.TabIndex = 11
        '
        'tb_C2
        '
        Me.tb_C2.Location = New System.Drawing.Point(133, 83)
        Me.tb_C2.Name = "tb_C2"
        Me.tb_C2.Size = New System.Drawing.Size(43, 20)
        Me.tb_C2.TabIndex = 12
        '
        'tb_C3
        '
        Me.tb_C3.Location = New System.Drawing.Point(133, 119)
        Me.tb_C3.Name = "tb_C3"
        Me.tb_C3.Size = New System.Drawing.Size(43, 20)
        Me.tb_C3.TabIndex = 13
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.Location = New System.Drawing.Point(195, 187)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Resultado.TabIndex = 14
        '
        'PROMEDIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(284, 313)
        Me.Controls.Add(Me.lbl_Resultado)
        Me.Controls.Add(Me.tb_C3)
        Me.Controls.Add(Me.tb_C2)
        Me.Controls.Add(Me.tb_C1)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PROMEDIO"
        Me.Text = "PROMEDIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents tb_C1 As TextBox
    Friend WithEvents tb_C2 As TextBox
    Friend WithEvents tb_C3 As TextBox
    Friend WithEvents lbl_Resultado As Label
End Class
