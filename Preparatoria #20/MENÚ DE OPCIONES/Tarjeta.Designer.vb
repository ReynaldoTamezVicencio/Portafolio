<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TARJETA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_CANT1 = New System.Windows.Forms.TextBox()
        Me.tb_CANT2 = New System.Windows.Forms.TextBox()
        Me.tb_CANT3 = New System.Windows.Forms.TextBox()
        Me.btn_SUMAR = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_LIMPIAR = New System.Windows.Forms.Button()
        Me.lbl_RESULTADO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "suma de 3 cantidades para "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Star Jedi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame cant 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Star Jedi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dame cant 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Star Jedi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dame cant 3"
        '
        'tb_CANT1
        '
        Me.tb_CANT1.Location = New System.Drawing.Point(145, 61)
        Me.tb_CANT1.Name = "tb_CANT1"
        Me.tb_CANT1.Size = New System.Drawing.Size(100, 20)
        Me.tb_CANT1.TabIndex = 4
        '
        'tb_CANT2
        '
        Me.tb_CANT2.Location = New System.Drawing.Point(145, 90)
        Me.tb_CANT2.Name = "tb_CANT2"
        Me.tb_CANT2.Size = New System.Drawing.Size(100, 20)
        Me.tb_CANT2.TabIndex = 5
        '
        'tb_CANT3
        '
        Me.tb_CANT3.Location = New System.Drawing.Point(145, 117)
        Me.tb_CANT3.Name = "tb_CANT3"
        Me.tb_CANT3.Size = New System.Drawing.Size(100, 20)
        Me.tb_CANT3.TabIndex = 6
        '
        'btn_SUMAR
        '
        Me.btn_SUMAR.BackColor = System.Drawing.Color.Red
        Me.btn_SUMAR.Font = New System.Drawing.Font("Star Jedi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SUMAR.Location = New System.Drawing.Point(30, 138)
        Me.btn_SUMAR.Name = "btn_SUMAR"
        Me.btn_SUMAR.Size = New System.Drawing.Size(75, 23)
        Me.btn_SUMAR.TabIndex = 7
        Me.btn_SUMAR.Text = "sumar"
        Me.btn_SUMAR.UseVisualStyleBackColor = False
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.Yellow
        Me.btn_volver.Font = New System.Drawing.Font("Star Jedi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(145, 177)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "volver"
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'btn_LIMPIAR
        '
        Me.btn_LIMPIAR.BackColor = System.Drawing.Color.Lime
        Me.btn_LIMPIAR.Font = New System.Drawing.Font("Star Jedi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LIMPIAR.Location = New System.Drawing.Point(30, 177)
        Me.btn_LIMPIAR.Name = "btn_LIMPIAR"
        Me.btn_LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.btn_LIMPIAR.TabIndex = 9
        Me.btn_LIMPIAR.Text = "limpiar"
        Me.btn_LIMPIAR.UseVisualStyleBackColor = False
        '
        'lbl_RESULTADO
        '
        Me.lbl_RESULTADO.AutoSize = True
        Me.lbl_RESULTADO.Font = New System.Drawing.Font("Star Jedi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RESULTADO.Location = New System.Drawing.Point(171, 143)
        Me.lbl_RESULTADO.Name = "lbl_RESULTADO"
        Me.lbl_RESULTADO.Size = New System.Drawing.Size(17, 18)
        Me.lbl_RESULTADO.TabIndex = 10
        Me.lbl_RESULTADO.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(5, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "determinar forma de pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reynaldo Tamez Vicencio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Matrícula: 2013116"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "N.L 22"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Grupo: 207"
        '
        'TARJETA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(287, 291)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_RESULTADO)
        Me.Controls.Add(Me.btn_LIMPIAR)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_SUMAR)
        Me.Controls.Add(Me.tb_CANT3)
        Me.Controls.Add(Me.tb_CANT2)
        Me.Controls.Add(Me.tb_CANT1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TARJETA"
        Me.Text = "TARJETA O EFECTIVO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_CANT1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_CANT2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_CANT3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_SUMAR As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents lbl_RESULTADO As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
