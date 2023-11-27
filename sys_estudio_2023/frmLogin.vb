Imports System.Data.SqlClient

Public Class frmLogin

    Dim comando As New SqlCommand

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtUsuario.Text IsNot "" Then
                Login_us()
                labelError1.Visible = False
            Else
                labelError1.Visible = True
                txtUsuario.Clear()
            End If
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtContraseña.Text IsNot "" Then
                Login_pass()
                labelError2.Visible = False
            Else
                labelError2.Visible = True
                txtContraseña.Clear()
            End If
        End If
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Login_pass()
    End Sub

    Private Sub Login_us()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "SELECT id_usuario, usuario, contrasena FROM usuarios WHERE 
                            usuario = '" & Me.txtUsuario.Text & "'"

        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                dr.Read()
                Me.lblContraseña.Text = dr(2).ToString
                name_usuario = dr(1).ToString
                Me.txtContraseña.Focus()
                Me.btnAcceder.Enabled = True
            Else
                MsgBox("Usuario Inexistente", MsgBoxStyle.Exclamation, "Autenticación")
                Me.txtUsuario.Clear()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error de lectura: '" & ex.ToString & "'", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Login_pass()
        If Me.txtContraseña.Text = Me.lblContraseña.Text Then
            frmMenu.Show()
            Me.Close()
        Else
            MsgBox("Los datos ingresados son incorrectos", MsgBoxStyle.Critical, "Error de acceso")
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Focus()
            Me.txtContraseña.Text = ""
            Me.btnAcceder.Enabled = False
        End If
    End Sub
End Class