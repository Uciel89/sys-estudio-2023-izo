Public Class frmEstados
    Private Sub frmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarEstados()
    End Sub

    Private Sub llenarEstados()
        Dim sql As String = "select cod_estado, descripcion from Estados"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Estados")
        adp.Fill(ds.Tables("Estados"))
        Me.dtvEstados.DataSource = ds.Tables("Estados")
    End Sub

    Private Sub nuevaEstados()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into Estados(cod_estado, descripcion )  
                                values (" & Me.txtCodEstados.Text & ",
                                        '" & Me.txtDescEstados.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodEstados.Text <> "" And Me.txtDescEstados.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarEstados()
                Me.txtCodEstados.Clear()
                Me.txtDescEstados.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodEstados.Focus()
        End If
    End Sub

    ' Update Estado
    Private Sub btnUpdateEstados_Click(sender As Object, e As EventArgs) Handles btnUpdateEstados.Click
        flag_abm_estado = 2
        Me.Width = 511
        Me.txtCodEstados.Text = Me.dtvEstados.CurrentRow.Cells(0).Value.ToString
        Me.txtDescEstados.Text = Me.dtvEstados.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub updateEstado()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update Estados set cod_Estado = " & Me.txtCodEstados.Text & ",
                                        descripcion = '" & Me.txtDescEstados.Text & "'
                                        WHERE cod_Estado = '" & Me.txtCodEstados.Text & "'"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodEstados.Text <> "" And Me.txtDescEstados.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarEstados()
                Me.txtCodEstados.Clear()
                Me.txtDescEstados.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodEstados.Focus()
        End If
        flag_abm_estado = 1
    End Sub

    ' Delete Estado
    Private Sub btnDeleteEstudios_Click(sender As Object, e As EventArgs) Handles btnDeleteEstudios.Click
        wcp = Me.dtvEstados.CurrentRow.Cells(0).Value.ToString
        Dim AnswerYes As String
        AnswerYes = MsgBox("Desea eliminar esta Estado ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteEstado()
            flag_abm_estado = 1
        End If
        flag_abm_estado = 1
    End Sub

    Private Sub deleteEstado()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete Estados where cod_estado = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarEstados()
            Me.txtCodEstados.Clear()
        Catch ex As Exception
            MsgBox("La localidad esta utilizada", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub btnGuardarEstados_Click(sender As Object, e As EventArgs) Handles btnGuardarEstados.Click
        If flag_abm_estado = 1 Then 'ALTA
            nuevaEstados()
        ElseIf flag_abm_estado = 2 Then 'UPDATE
            updateEstado()
        End If
    End Sub

    Private Sub dtvEstados_KeyDown(sender As Object, e As KeyEventArgs) Handles dtvEstados.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmExpedienteForm = CType(Owner, frmExpedienteForm)
                frm.txtCodEstado.Text = Me.dtvEstados.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
    End Sub
End Class