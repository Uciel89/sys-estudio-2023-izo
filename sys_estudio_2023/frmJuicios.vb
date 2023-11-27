Public Class frmJuicios
    Private Sub updateJuicio()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update juicios set cod_juicio = " & Me.txtCodJuicio.Text & ",
                                        descripcion = '" & Me.txtDescJuicio.Text & "'
                                        WHERE cod_juicio = '" & Me.txtCodJuicio.Text & "'"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodJuicio.Text <> "" And Me.txtDescJuicio.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuicios()
                Me.txtCodJuicio.Clear()
                Me.txtDescJuicio.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodJuicio.Focus()
        End If
        flag_abm_juicios = 1
    End Sub

    Private Sub deleteJuicio()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete juicios where cod_juicio = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarJuicios()
            Me.txtCodJuicio.Clear()
        Catch ex As Exception
            MsgBox("La localidad esta utilizada", MsgBoxStyle.Critical, "Error")
        End Try
        flag_abm_juicios = 1
    End Sub

    Private Sub nuevaJuicio()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into juicios(cod_juicio, descripcion )  
                                values (" & Me.txtCodJuicio.Text & ",
                                        '" & Me.txtDescJuicio.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodJuicio.Text <> "" And Me.txtDescJuicio.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuicios()
                Me.txtCodJuicio.Clear()
                Me.txtDescJuicio.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodJuicio.Focus()
        End If
    End Sub

    Private Sub llenarJuicios()
        Dim sql As String = "select cod_juicio, descripcion from juicios"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("juicios")
        adp.Fill(ds.Tables("juicios"))
        Me.dtvJuicios.DataSource = ds.Tables("juicios")
    End Sub

    Private Sub btnAddJuicio_Click(sender As Object, e As EventArgs)
        flag_abm_juicios = 1
        txtCodJuicio.Clear()
        txtDescJuicio.Clear()
    End Sub

    Private Sub btnUpdateJuicio_Click(sender As Object, e As EventArgs) Handles btnUpdateJuicio.Click
        flag_abm_juicios = 2
        Me.txtCodJuicio.Text = Me.dtvJuicios.CurrentRow.Cells(0).Value.ToString
        Me.txtDescJuicio.Text = Me.dtvJuicios.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnDeleteJuicio_Click(sender As Object, e As EventArgs) Handles btnDeleteJuicio.Click
        wcp = Me.dtvJuicios.CurrentRow.Cells(0).Value.ToString
        Dim AnswerYes As String

        AnswerYes = MsgBox("Desea eliminar esta localidad ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteJuicio()
            flag_abm_juicios = 1
        End If
    End Sub

    Private Sub btnGuardarJuicio_Click(sender As Object, e As EventArgs) Handles btnGuardarJuicio.Click
        If flag_abm_juicios = 1 Then 'ALTA
            nuevaJuicio()
        ElseIf flag_abm_juicios = 2 Then 'UPDATE
            updateJuicio()
        End If
    End Sub

    Private Sub frmJuicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarJuicios()
    End Sub

    Private Sub dtvJuicios_KeyDown(sender As Object, e As KeyEventArgs) Handles dtvJuicios.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmExpedienteForm = CType(Owner, frmExpedienteForm)
                frm.txtCodJuicio.Text = Me.dtvJuicios.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If

    End Sub
End Class