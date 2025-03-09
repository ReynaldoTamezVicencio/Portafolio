Public Class PIAMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_BlocDeNotas_Click(sender As Object, e As EventArgs) Handles BTN_BlocDeNotas.Click
        Response.Redirect("BlocDeNotas.aspx")
    End Sub

    Protected Sub BTN_Nombre_Click(sender As Object, e As EventArgs) Handles BTN_Nombre.Click
        Response.Redirect("Nombre.aspx")
    End Sub

    Protected Sub BTN_Triangulo_Click(sender As Object, e As EventArgs) Handles BTN_Triangulo.Click
        Response.Redirect("Triangulo.aspx")
    End Sub

    Protected Sub BTN_Hobbie_Click(sender As Object, e As EventArgs) Handles BTN_Hobbie.Click
        Response.Redirect("Hobbie.aspx")
    End Sub

    Protected Sub BTN_HoraServidor_Click(sender As Object, e As EventArgs) Handles BTN_HoraServidor.Click
        Response.Redirect("HoraServidor.aspx")
    End Sub

    Protected Sub BTN_Calificaciones_Click(sender As Object, e As EventArgs) Handles BTN_Calificaciones.Click
        Response.Redirect("Calificaciones.aspx")
    End Sub

    Protected Sub BTN_Formulario_Click(sender As Object, e As EventArgs) Handles BTN_Formulario.Click
        Response.Redirect("Formulario.aspx")
    End Sub

    Protected Sub BTN_FormIdiomas_Click(sender As Object, e As EventArgs) Handles BTN_FormIdiomas.Click
        Response.Redirect("FormularioIdiomasDatos.aspx")
    End Sub

    Protected Sub BTN_GenerosMusicales_Click(sender As Object, e As EventArgs) Handles BTN_GenerosMusicales.Click
        Response.Redirect("GenerosMusicales.aspx")
    End Sub

    Protected Sub BTN_MultivistaInscripcion_Click(sender As Object, e As EventArgs) Handles BTN_MultivistaInscripcion.Click
        Response.Redirect("MultivistaInscripcion.aspx")
    End Sub
End Class