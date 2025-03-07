Imports System.Data.SqlClient
Public Class BDSQL_Farmacia
    'REYNALDO TAMEZ VICENCIO'
    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Dim conexion As String

        'Nombre del Servidor y Base de Datos'

        conexion = "Data Source = LAPTOP-6RVBHCGB\SQLEXPRESS01; Initial Catalog = FARMACIA_TAMEZ_VICENCIO; Integrated Security = True"

        Dim seleccion As String = "SELECT * FROM Productos"
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