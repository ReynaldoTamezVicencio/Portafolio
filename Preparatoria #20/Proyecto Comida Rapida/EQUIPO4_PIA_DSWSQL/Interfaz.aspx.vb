Imports System.Data.SqlClient
Public Class Interfaz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Variable conexion SQL'
        Dim con As New SqlConnection
        con.ConnectionString = SQLDS.ConnectionString

        'Sentencias SQL a ejecutar'
        Dim cmd_agregar As New SqlCommand("INSERT INTO Pedidos (Nombre_Cliente, Orden, Notas, Total_Pago, Envio, Direccion, Estatus_del_Pedido, Fecha) VALUES (@nom, @ord, @Not, @TP, @Env, @Dir, @Est, @Fec)", con)
        Dim cmd_modificar As New SqlCommand("UPDATE Pedidos SET Nombre_Cliente = @nom, Orden = @ord, Notas = @Not, Total_Pago = @TP, Envio = @Env, Direccion = @Dir, Estatus_del_Pedido = @Est, Fecha = @Fec WHERE ID_Pedido = @id", con)
        Dim cmd_eliminar As New SqlCommand("DELETE FROM Pedidos WHERE ID_Pedido= @id", con)
        Dim cmd_SP_modificar_Estatus As New SqlCommand("Execute Cambiar_Estatus @Est, @id", con)

        ''
        Dim cant As Integer
        Using con
            If DropDownList1.Text = "Consultar" Then
                con.Open()
                GridView1.Visible = True
                GridView1.DataBind()
                con.Close()
            End If
            If DropDownList1.Text = "Agregar" Then
                cmd_agregar.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = Me.TB_Nombre.Text
                cmd_agregar.Parameters.AddWithValue("@ord", SqlDbType.VarChar).Value = Me.TB_Orden.Text
                cmd_agregar.Parameters.AddWithValue("@Not", SqlDbType.VarChar).Value = Me.TB_Notas.Text
                cmd_agregar.Parameters.AddWithValue("@TP", SqlDbType.Int).Value = Me.TB_TotalPago.Text
                cmd_agregar.Parameters.AddWithValue("@Env", SqlDbType.VarChar).Value = Me.TB_Envio.Text
                cmd_agregar.Parameters.AddWithValue("@Dir", SqlDbType.VarChar).Value = Me.TB_Direccion.Text
                cmd_agregar.Parameters.AddWithValue("@Est", SqlDbType.VarChar).Value = Me.TB_Estatus.Text
                cmd_agregar.Parameters.AddWithValue("@Fec", SqlDbType.Date).Value = Me.TB_Fecha.Text
                con.Open()
                cant = cmd_agregar.ExecuteNonQuery
                con.Close()
                Response.Redirect("Interfaz.aspx")
            End If

            If DropDownList1.Text = "Modificar" Then
                cmd_modificar.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = Me.TB_ID.Text
                cmd_modificar.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = Me.TB_Nombre.Text
                cmd_modificar.Parameters.AddWithValue("@ord", SqlDbType.VarChar).Value = Me.TB_Orden.Text
                cmd_modificar.Parameters.AddWithValue("@Not", SqlDbType.VarChar).Value = Me.TB_Notas.Text
                cmd_modificar.Parameters.AddWithValue("@TP", SqlDbType.VarChar).Value = Me.TB_TotalPago.Text
                cmd_modificar.Parameters.AddWithValue("@Env", SqlDbType.VarChar).Value = Me.TB_Envio.Text
                cmd_modificar.Parameters.AddWithValue("@Dir", SqlDbType.VarChar).Value = Me.TB_Direccion.Text
                cmd_modificar.Parameters.AddWithValue("@Est", SqlDbType.VarChar).Value = Me.TB_Estatus.Text
                cmd_modificar.Parameters.AddWithValue("@Fec", SqlDbType.VarChar).Value = Me.TB_Fecha.Text
                con.Open()
                cant = cmd_modificar.ExecuteNonQuery
                con.Close()
                Response.Redirect("Interfaz.aspx")
            End If

            If DropDownList1.Text = "Eliminar" Then
                cmd_eliminar.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = Me.TB_ID.Text
                con.Open()
                cant = cmd_eliminar.ExecuteNonQuery
                con.Close()
                Response.Redirect("Interfaz.aspx")
            End If

            If DropDownList1.Text = "Cambiar_Estatus" Then

                cmd_SP_modificar_Estatus.Parameters.AddWithValue("@Est", SqlDbType.VarChar).Value = Me.TB_Estatus.Text
                cmd_SP_modificar_Estatus.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Me.TB_ID.Text
                con.Open()
                cant = cmd_SP_modificar_Estatus.ExecuteNonQuery
                con.Close()
                Response.Redirect("Interfaz.aspx")
            End If

        End Using
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Select Case DropDownList1.Text
            Case Is = "Modificar"
                TB_ID.Enabled = True
                TB_Nombre.Enabled = True
                TB_Orden.Enabled = True
                TB_Notas.Enabled = True
                TB_TotalPago.Enabled = True
                TB_Envio.Enabled = True
                TB_Direccion.Enabled = True
                TB_Estatus.Enabled = True
                TB_Fecha.Enabled = True

            Case Is = "Eliminar"
                TB_ID.Enabled = True
                TB_Nombre.Enabled = False
                TB_Orden.Enabled = False
                TB_Notas.Enabled = False
                TB_TotalPago.Enabled = False
                TB_Envio.Enabled = False
                TB_Direccion.Enabled = False
                TB_Estatus.Enabled = False
                TB_Fecha.Enabled = False

            Case Is = "Agregar"
                TB_ID.Enabled = False
                TB_Nombre.Enabled = True
                TB_Orden.Enabled = True
                TB_Notas.Enabled = True
                TB_TotalPago.Enabled = True
                TB_Envio.Enabled = True
                TB_Direccion.Enabled = True
                TB_Estatus.Enabled = True
                TB_Fecha.Enabled = True

            Case Is = "Consultar"
                TB_ID.Enabled = False
                TB_Nombre.Enabled = False
                TB_Orden.Enabled = False
                TB_Notas.Enabled = False
                TB_TotalPago.Enabled = False
                TB_Envio.Enabled = False
                TB_Direccion.Enabled = False
                TB_Estatus.Enabled = False
                TB_Fecha.Enabled = False

            Case Is = "Cambiar_Estatus"
                TB_ID.Enabled = True
                TB_Nombre.Enabled = False
                TB_Orden.Enabled = False
                TB_Notas.Enabled = False
                TB_TotalPago.Enabled = False
                TB_Envio.Enabled = False
                TB_Direccion.Enabled = False
                TB_Estatus.Enabled = True
                TB_Fecha.Enabled = False
        End Select
    End Sub
End Class