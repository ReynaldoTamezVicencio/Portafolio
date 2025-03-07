Partial Class CLÍNICA_VICENCIODataSet
    Partial Public Class MEDICOSDataTable
        Private Sub MEDICOSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ID_MédicoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
