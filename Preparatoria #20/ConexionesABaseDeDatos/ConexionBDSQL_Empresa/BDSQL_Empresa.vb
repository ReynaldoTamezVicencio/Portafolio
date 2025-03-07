Imports System.Data.SqlClient
Public Class BDSQL_Empresa
    'REYNALDO TAMEZ VICENCIO'
    Private Sub BTN_Mostrar_Click(sender As Object, e As EventArgs) Handles BTN_Mostrar.Click
        Dim conexion As String

        'Nombre del servidor en Data Source (Aparece en Object Explorer de SQL hasta arriba)'
        'Colocamos también el nombre de la BD en Initial Catalog´

        conexion = "Data Source = LAPTOP-6RVBHCGB\SQLEXPRESS01; Initial Catalog = BDEmpresa; Integrated Security = True"

        Dim seleccion As String = "SELECT * FROM clientes"
        Dim adaptadordedatos As SqlDataAdapter
        Dim tabladedatos As New DataTable

        Try
            adaptadordedatos = New SqlDataAdapter(seleccion, conexion)
            adaptadordedatos.Fill(tabladedatos)
            dgtabla.DataSource = tabladedatos

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub
End Class
