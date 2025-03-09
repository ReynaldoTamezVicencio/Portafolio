Public Class GenerosMusicales
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_Elegir_Click(sender As Object, e As EventArgs) Handles BTN_Elegir.Click
        Image1.ImageUrl = "~/Imagenes/" + DropDownList1.SelectedValue + ".jpg"
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If (DropDownList1.Items(0).Selected = True) Then
            PanelRock.Visible = True
        Else
            PanelRock.Visible = False
        End If

        If (DropDownList1.Items(1).Selected = True) Then
            PanelPop.Visible = True
        Else
            PanelPop.Visible = False
        End If

        If (DropDownList1.Items(2).Selected = True) Then
            PanelHipHop.Visible = True
        Else
            PanelHipHop.Visible = False
        End If

        If (DropDownList1.Items(3).Selected = True) Then
            PanelClasica.Visible = True
        Else
            PanelClasica.Visible = False
        End If

        If (DropDownList1.Items(4).Selected = True) Then
            PanelElectronica.Visible = True
        Else
            PanelElectronica.Visible = False
        End If

    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class