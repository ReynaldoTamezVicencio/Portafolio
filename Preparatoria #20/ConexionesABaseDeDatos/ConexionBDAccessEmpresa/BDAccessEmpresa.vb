Imports System.Data.OleDb
Public Class BDAccessEmpresa
    Private Sub BTN_Mostrar_Click(sender As Object, e As EventArgs) Handles BTN_Mostrar.Click
        'REYNALDO TAMEZ VICENCIO'

        Dim conexion As String

        'Conexión a la BD de Access de la empresa'

        conexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & "C:\EJERCICIOS\RTV_BDEmpresas.mdb" & ";"

        Dim seleccion As String = "SELECT * FROM Clientes"
        Dim adaptadordedatos As OleDbDataAdapter
        Dim tabladedatos As New DataTable

        Try
            adaptadordedatos = New OleDbDataAdapter(seleccion, conexion)
            adaptadordedatos.Fill(tabladedatos)
            dgtabla.DataSource = tabladedatos
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub
End Class
