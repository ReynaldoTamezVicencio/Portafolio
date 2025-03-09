Public Class FormularioIdiomasDatos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_Ingresar_Click(sender As Object, e As EventArgs) Handles BTN_Ingresar.Click
        If Me.IsPostBack Then
            Dim Nombre As String
            Dim Apellido As String
            Dim Telefono As String
            Dim Email As String
            Dim Direccion As String
            Dim FechaNacimiento As String
            Dim Genero As String
            Dim Ciudad As String
            Dim EstadoCivil As String

            Nombre = Convert.ToString(Request.Form("TB_Nombre"))
            Apellido = Convert.ToString(Request.Form("TB_Apellidos"))
            Telefono = Convert.ToString(Request.Form("TB_Teléfono"))
            Email = Convert.ToString(Request.Form("TB_Email"))
            Direccion = Convert.ToString(Request.Form("TB_Direccion"))
            FechaNacimiento = Convert.ToString(Request.Form("TB_FechaNaci"))
            Genero = Convert.ToString(Request.Form("RadBTNList_Genero"))
            Ciudad = Convert.ToString(Request.Form("DDL_Ciudad"))
            EstadoCivil = Convert.ToString(Request.Form("DDL_EstadoCivil"))

            InicioTab.Text = "<Table style = ""border: 1px solid black"">" +
                "<tr><th>Nombre</th><th>Apellido</th><th>Telefono</th><th>Email</th><th>Direccion</th><th>Nacimiento</th><th>Genero</th><th>Ciudad</th><th>Estado Civil</th></tr>"
            InfoTab.Text = InfoTab.Text +
                "<tr><td>" + Nombre + "</td><td>" + Apellido + "</td><td>" + Telefono + "</td><td>" + Email + "</td><td>" + Direccion + "</td><td>" + FechaNacimiento + "</td><td>" +
                 Genero + "</td><td>" + Ciudad + "</td><td>" + EstadoCivil + "</td><tr>"
            FinTab.Text = "</table>"
        End If
    End Sub

    Protected Sub BTN_Siguiente_Click(sender As Object, e As EventArgs) Handles BTN_Siguiente.Click
        Response.Redirect("FormularioSeleccionIdioma.aspx")
    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class