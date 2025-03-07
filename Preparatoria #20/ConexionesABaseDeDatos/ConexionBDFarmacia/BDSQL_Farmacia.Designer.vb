<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BDSQL_Farmacia
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgtabla = New System.Windows.Forms.DataGridView()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(664, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conexión a una base de datos de sql Server: Farmacia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 51)
        Me.Panel1.TabIndex = 1
        '
        'dgtabla
        '
        Me.dgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtabla.Location = New System.Drawing.Point(83, 58)
        Me.dgtabla.Name = "dgtabla"
        Me.dgtabla.Size = New System.Drawing.Size(548, 273)
        Me.dgtabla.TabIndex = 2
        '
        'Mostrar
        '
        Me.Mostrar.BackColor = System.Drawing.Color.Orange
        Me.Mostrar.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mostrar.Location = New System.Drawing.Point(187, 337)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(342, 48)
        Me.Mostrar.TabIndex = 3
        Me.Mostrar.Text = "Mostrar datos de la bd de farmacia"
        Me.Mostrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 64)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reynaldo Tamez Vicencio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matrícula: 2013116" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo 307" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N.L. 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BDSQL_Farmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(718, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.dgtabla)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BDSQL_Farmacia"
        Me.Text = "RTV_Base de Datos de farmacia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgtabla As DataGridView
    Friend WithEvents Mostrar As Button
    Friend WithEvents Label2 As Label
End Class
