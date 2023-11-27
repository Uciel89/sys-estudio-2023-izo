Public Class frmExpedienteForm

    Private Sub llenarExpediente()
        Dim sql As String = "select 
                                cod_expediente,
                                caratula_expediente,
                                cod_estado,
                                cod_juicio,
                                cod_juzgado,
                                fecha_inicio
                            from expedientes"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Expedientes")
        adp.Fill(ds.Tables("Expedientes"))
        Me.dtvExpedientes.DataSource = ds.Tables("Expedientes")
    End Sub

    Private Sub nuevoExpediente()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into expedientes(
                                cod_expediente,
                                caratula_expediente,
                                cod_estado,
                                cod_juicio,
                                cod_juzgado,
                                fecha_inicio)  
                                values ('" & Me.txtCodExpediente.Text & "',
                                        '" & Me.txtCaratulaExpediente.Text & "',
                                        '" & Me.txtCodEstado.Text & "',
                                        '" & Me.txtCodJuicio.Text & "',
                                        '" & Me.txtCodJuzgado.Text & "',
                                        '" & Me.txtFechaInicio.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodExpediente.Text <> "" And Me.txtCaratulaExpediente.Text <> "" And Me.txtCodEstado.Text <> "" And Me.txtCodJuicio.Text <> "" And Me.txtCodJuzgado.Text <> "" And Me.txtFechaInicio.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarExpediente()
                Me.txtCodExpediente.Clear()
                Me.txtCaratulaExpediente.Clear()
                Me.txtCodEstado.Clear()
                Me.txtCodJuicio.Clear()
                Me.txtCodJuzgado.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodExpediente.Focus()
        End If
    End Sub

    Private Sub updateExpediente()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update expedientes set cod_expediente = '" & Me.txtCodExpediente.Text & "',
                                        caratula_expediente = '" & Me.txtCaratulaExpediente.Text & "',
                                        cod_estado ='" & Me.txtCodEstado.Text & "',
                                        cod_juicio = '" & Me.txtCodJuicio.Text & "',
                                        cod_juzgado = '" & Me.txtCodJuzgado.Text & "',
                                        fecha_inicio = '" & Me.txtFechaInicio.Text & "'
                                        WHERE cod_expediente = '" & cod_expediente_frm & "'"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodExpediente.Text <> "" And Me.txtCaratulaExpediente.Text <> "" And Me.txtCodEstado.Text <> "" And Me.txtCodJuicio.Text <> "" And Me.txtCodJuzgado.Text <> "" And Me.txtFechaInicio.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarExpediente()
                Me.txtCodExpediente.Clear()
                Me.txtCaratulaExpediente.Clear()
                Me.txtCodEstado.Clear()
                Me.txtCodJuicio.Clear()
                Me.txtCodJuzgado.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCodExpediente.Focus()
        End If

        flag_abm_expediente = 1

    End Sub

    Private Sub deleteExpediente()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete expedientes where cod_expediente = " & cod_expediente_frm & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarExpediente()
            Me.txtCodExpediente.Clear()
            Me.txtCaratulaExpediente.Clear()
            Me.txtCodEstado.Clear()
            Me.txtCodJuicio.Clear()
            Me.txtCodJuzgado.Clear()
        Catch ex As Exception
            MsgBox("El expediente está siendo utilizado", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmExpedienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaInicio.Format = DateTimePickerFormat.Custom
        txtFechaInicio.CustomFormat = "yyyy-MM-dd"
        llenarExpediente()
        flag_abm_expediente = 1
    End Sub

    Private Sub dtvJuzgados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvExpedientes.CellContentClick

    End Sub

    Private Sub btnOpenEstado_Click(sender As Object, e As EventArgs) Handles btnOpenEstado.Click
        flag_where = 1
        Dim frm As New frmEstados
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnOpenJuicio_Click(sender As Object, e As EventArgs) Handles btnOpenJuicio.Click
        flag_where = 1
        Dim frm As New frmJuicios
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnOpenJuzgado_Click(sender As Object, e As EventArgs) Handles btnOpenJuzgado.Click
        flag_where = 1
        Dim frm As New frmJuzgado
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnGuardarExpediente_Click(sender As Object, e As EventArgs) Handles btnGuardarExpediente.Click

        If flag_abm_expediente = 1 Then 'ALTA
            nuevoExpediente()
        ElseIf flag_abm_expediente = 2 Then 'UPDATE
            updateExpediente()
        End If

    End Sub

    Private Sub btnAddExpediente_Click(sender As Object, e As EventArgs) Handles btnAddLocalidad.Click
        flag_abm_expediente = 2 'UPDATE

        ' Carga de datos
        cod_expediente_frm = Me.dtvExpedientes.CurrentRow.Cells(0).Value.ToString


    End Sub

    Private Sub btnUpdateExpedientes_Click(sender As Object, e As EventArgs) Handles btnUpdateExpedientes.Click
        flag_abm_expediente = 2 'UPDATE

        ' Carga de datos
        cod_expediente_frm = Me.dtvExpedientes.CurrentRow.Cells(0).Value.ToString

        Me.txtCodExpediente.Text = Me.dtvExpedientes.CurrentRow.Cells(0).Value.ToString
        Me.txtCaratulaExpediente.Text = Me.dtvExpedientes.CurrentRow.Cells(1).Value.ToString
        Me.txtCodEstado.Text = Me.dtvExpedientes.CurrentRow.Cells(2).Value.ToString
        Me.txtCodJuicio.Text = Me.dtvExpedientes.CurrentRow.Cells(3).Value.ToString
        Me.txtCodJuzgado.Text = Me.dtvExpedientes.CurrentRow.Cells(4).Value.ToString
        Me.txtFechaInicio.Text = Me.dtvExpedientes.CurrentRow.Cells(5).Value.ToString
        Me.txtCodExpediente.Focus()

    End Sub

    Private Sub btnDeleteExpedientes_Click(sender As Object, e As EventArgs) Handles btnDeleteExpediente.Click
        flag_abm_expediente = 3 'DELETE

        ' Carga de datos
        cod_expediente_frm = Me.dtvExpedientes.CurrentRow.Cells(0).Value.ToString
        Dim AnswerYes As String

        AnswerYes = MsgBox("Desea eliminar este expediente ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteExpediente()
        End If
        flag_abm_expediente = 1
    End Sub


End Class