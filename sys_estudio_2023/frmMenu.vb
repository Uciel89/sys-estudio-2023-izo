Public Class frmMenu

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblUsuario.Text = name_usuario
    End Sub

    Private Sub hideSubmenu()
        PanelUsuario.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        showSubmenu(PanelUsuario)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        frmLocalidad.ShowDialog()
    End Sub

    Private Sub btnJuzgado_Click(sender As Object, e As EventArgs) Handles btnJuzgado.Click
        frmJuzgado.ShowDialog()
    End Sub

    Private Sub btnEstados_Click(sender As Object, e As EventArgs) Handles btnEstados.Click
        frmEstados.ShowDialog()
    End Sub

    Private Sub btnJuicios_Click(sender As Object, e As EventArgs) Handles btnJuicios.Click
        frmJuicios.ShowDialog()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        showSubmenu(PanelInformes)
    End Sub

    Private Sub btnExpedientes_Click(sender As Object, e As EventArgs) Handles btnExpedientes.Click
        frmListaExpedientes.ShowDialog()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles btnClientesExpedientes.Click
        frmClientesExpedientes.ShowDialog()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        showSubmenu(PanelClientes)
    End Sub

    Private Sub btnClientesFormulario_Click(sender As Object, e As EventArgs) Handles btnClientesFormulario.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub btnInfClientes_Click(sender As Object, e As EventArgs) Handles btnInfClientes.Click
        infClientes.ShowDialog()
    End Sub

    Private Sub btnInfJuazgados_Click(sender As Object, e As EventArgs) Handles btnInfJuazgados.Click
        infJuzgados.ShowDialog()
    End Sub
End Class