Public Class FormularioSeleccionIdioma
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ChkB_Todos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB_Todos.CheckedChanged
        If (ChkB_Todos.Checked = True) Then
            For i = 0 To (ChkBL_Idiomas.Items.Count - 1)
                ChkBL_Idiomas.Items(i).Selected = True
            Next
        Else
            For i = 0 To (ChkBL_Idiomas.Items.Count - 1)
                ChkBL_Idiomas.Items(i).Selected = False
            Next
        End If
    End Sub

    Protected Sub ChkBL_Idiomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkBL_Idiomas.SelectedIndexChanged
        If (ChkBL_Idiomas.Items(0).Selected = True) Then
            Panel_Ingles.Visible = True
        Else
            Panel_Ingles.Visible = False
        End If

        If (ChkBL_Idiomas.Items(1).Selected = True) Then
            Panel_Frances.Visible = True
        Else
            Panel_Frances.Visible = False
        End If

        If (ChkBL_Idiomas.Items(2).Selected = True) Then
            Panel_Aleman.Visible = True
        Else
            Panel_Aleman.Visible = False
        End If

        If (ChkBL_Idiomas.Items(3).Selected = True) Then
            Panel_Italiano.Visible = True
        Else
            Panel_Italiano.Visible = False
        End If


    End Sub

    Protected Sub BTN_Anterior_Click(sender As Object, e As EventArgs) Handles BTN_Anterior.Click
        Response.Redirect("FormularioIdiomasDatos.aspx")
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        MsgBox("Información enviada")
    End Sub

    Protected Sub BTN_Volver_Click(sender As Object, e As EventArgs) Handles BTN_Volver.Click
        Response.Redirect("PIAMenu.aspx")
    End Sub
End Class