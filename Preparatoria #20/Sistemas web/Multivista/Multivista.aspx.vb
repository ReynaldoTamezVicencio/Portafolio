Public Class Multivista
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_ContinuarViewDatosAcademicos_Click(sender As Object, e As EventArgs) Handles BTN_ContinuarViewDatosAcademicos.Click
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub BTN_VolverViewDatosPersonales_Click(sender As Object, e As EventArgs) Handles BTN_VolverViewDatosPersonales.Click
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub BTN_ContinuarViewVistaPrevia_Click(sender As Object, e As EventArgs) Handles BTN_ContinuarViewVistaPrevia.Click
        LBL_Nombre.Text = TB_Nombre.Text
        LBL_Apellidos.Text = TB_Apellidos.Text
        LBL_Genero.Text = R_BTN_L_Genero.SelectedItem.Text
        LBL_Edad.Text = TB_Edad.Text
        LBL_EstudiosRealizados.Text = DDL_EstudiosRealizados.SelectedItem.Text
        LBL_Condicion.Text = DDL_Condicion.SelectedItem.Text

        MultiView1.ActiveViewIndex = 2
    End Sub

    Protected Sub BTN_VolverViewDatosAcademicos_Click(sender As Object, e As EventArgs) Handles BTN_VolverViewDatosAcademicos.Click
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub BTN_ConfirmarDatos_Click(sender As Object, e As EventArgs) Handles BTN_ConfirmarDatos.Click
        MsgBox("Información enviada con éxito")
    End Sub
End Class