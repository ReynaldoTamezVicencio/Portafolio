<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BDSQL_Empresa
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
        Me.dgtabla = New System.Windows.Forms.DataGridView()
        Me.BTN_Mostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conexión a una base de datos de sql server (empresa)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgtabla
        '
        Me.dgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtabla.Location = New System.Drawing.Point(17, 45)
        Me.dgtabla.Name = "dgtabla"
        Me.dgtabla.Size = New System.Drawing.Size(546, 224)
        Me.dgtabla.TabIndex = 1
        '
        'BTN_Mostrar
        '
        Me.BTN_Mostrar.Font = New System.Drawing.Font("Star Jedi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Mostrar.Location = New System.Drawing.Point(177, 275)
        Me.BTN_Mostrar.Name = "BTN_Mostrar"
        Me.BTN_Mostrar.Size = New System.Drawing.Size(240, 36)
        Me.BTN_Mostrar.TabIndex = 2
        Me.BTN_Mostrar.Text = "Mostrar datos de tabla"
        Me.BTN_Mostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 60)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reynaldo Tamez Vicencio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matrícula: 2013116" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo: 307" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N.L. 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BDSQL_Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 382)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_Mostrar)
        Me.Controls.Add(Me.dgtabla)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BDSQL_Empresa"
        Me.Text = "RTV_Base de datos SQL (Empresa)"
        CType(Me.dgtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgtabla As DataGridView
    Friend WithEvents BTN_Mostrar As Button
    Friend WithEvents Label2 As Label
End Class
