Imports System.Reflection.Emit

Public Class frmJuzgado

    '-- MOSTRAR JUZGADOS --'
    Private Sub frmJuzgado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaAlta.Format = DateTimePickerFormat.Custom
        txtFechaAlta.CustomFormat = "yyyy-MM-dd"
        llenarJuzgados()
        flag_abm_juzgado = 1
    End Sub

    Private Sub llenarJuzgados()
        Dim sql As String = "select j.cod_juzgado as COD_JUZGADO,
                            j.nombre_juez_tramite as NOMBRE_JUEZ_TRAMITE,
                            j.nombre_secretario as NOMBRE_SECRETARIO,
                            j.telefono as TELEFONO, 
                            j.fecha_alta as FECHA_ALTA, 
                            l.localidad as LOCALIDAD,
                            j.cp as CP
                            from juzgados as j
                            INNER JOIN localidades as l
                            ON l.cp = j.cp"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("juzgados")
        adp.Fill(ds.Tables("juzgados"))
        Me.dtvJuzgados.DataSource = ds.Tables("juzgados")
        Me.dtvJuzgados.Columns("CP").Visible = False
    End Sub

    Private Sub dtvJuzgados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvJuzgados.CellContentClick
        Me.dtvJuzgados.Columns("CP").Visible = False
    End Sub

    '-- AGREGAR JUZGADO --'

    Private Sub nuevaJuzgado()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into juzgados(cp, nombre_juez_tramite, nombre_secretario, telefono, fecha_alta, cod_juzgado )  
                                values (" & Me.txtCp.Text & ",
                                        '" & Me.txtNombreJuez.Text & "',
                                        '" & Me.txtNombreSecretario.Text & "',
                                        '" & Me.txtTelefono.Text & "',
                                        '" & Me.txtFechaAlta.Text & "',
                                        '" & Me.txtCodJuzgado.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCp.Text <> "" And Me.txtNombreJuez.Text <> "" And Me.txtNombreSecretario.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtFechaAlta.Text <> "" And Me.txtCodJuzgado.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuzgados()
                Me.txtCp.Clear()
                Me.txtCodJuzgado.Clear()
                Me.txtNombreJuez.Clear()
                Me.txtNombreSecretario.Clear()
                Me.txtTelefono.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCp.Focus()
        End If
    End Sub

    '-- ACTUALIZAR JUZGADO --'
    Private Sub btnUpdateLocalidad_Click(sender As Object, e As EventArgs) Handles btnUpdateLocalidad.Click
        flag_abm_juzgado = 2 'UPDATE

        ' Carga de datos
        Me.txtCodJuzgado.Text = Me.dtvJuzgados.CurrentRow.Cells(0).Value.ToString
        Me.txtNombreJuez.Text = Me.dtvJuzgados.CurrentRow.Cells(1).Value.ToString
        Me.txtNombreSecretario.Text = Me.dtvJuzgados.CurrentRow.Cells(2).Value.ToString
        Me.txtTelefono.Text = Me.dtvJuzgados.CurrentRow.Cells(3).Value.ToString
        Me.txtFechaAlta.Text = Me.dtvJuzgados.CurrentRow.Cells(4).Value.ToString
        Me.txtCp.Text = Me.dtvJuzgados.CurrentRow.Cells(6).Value.ToString
        Me.txtNombreJuez.Focus()

    End Sub

    Private Sub updateJuzgado()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update juzgados set cp = " & Me.txtCp.Text & ",
                                        nombre_juez_tramite = '" & Me.txtNombreJuez.Text & "',
                                        nombre_secretario = '" & Me.txtNombreSecretario.Text & "',
                                        telefono = '" & Me.txtTelefono.Text & "',
                                        fecha_alta = '" & Me.txtFechaAlta.Text & "'
                                        WHERE cod_juzgado = '" & Me.txtCodJuzgado.Text & "'"
        cmd.CommandText = sql

        'validacion
        If Me.txtCp.Text <> "" And Me.txtNombreJuez.Text <> "" And Me.txtNombreSecretario.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtFechaAlta.Text <> "" And Me.txtCodJuzgado.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuzgados()
                Me.txtCp.Clear()
                Me.txtCodJuzgado.Clear()
                Me.txtNombreJuez.Clear()
                Me.txtNombreSecretario.Clear()
                Me.txtTelefono.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtCp.Focus()
        End If

    End Sub

    Private Sub btnGuardarJuzgado_Click(sender As Object, e As EventArgs) Handles btnGuardarJuzgado.Click

        If flag_abm_juzgado = 1 Then 'ALTA
            nuevaJuzgado()
        ElseIf flag_abm_juzgado = 2 Then 'UPDATE
            updateJuzgado()
            flag_abm_juzgado = 1
        End If
        flag_abm_juzgado = 1
    End Sub

    '-- BORRA JUZGADO --'
    Private Sub btnDeleteJuzgado_Click(sender As Object, e As EventArgs) Handles btnDeleteJuzgado.Click
        wcp = Me.dtvJuzgados.CurrentRow.Cells(0).Value.ToString
        Dim AnswerYes As String

        AnswerYes = MsgBox("Desea eliminar esta localidad ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteJuzgado()
        End If
        flag_abm_juzgado = 1
    End Sub

    Private Sub deleteJuzgado()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete juzgados where cod_juzgado = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarJuzgados()
            Me.txtCp.Clear()
        Catch ex As Exception
            MsgBox("La localidad esta utilizada", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '-- VISUALIZAR LOCALIDADES --'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLocalidad.Click
        flag_where = 1
        Dim frm As New frmLocalidad
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub dtvJuzgados_KeyDown(sender As Object, e As KeyEventArgs) Handles dtvJuzgados.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmExpedienteForm = CType(Owner, frmExpedienteForm)
                frm.txtCodJuzgado.Text = Me.dtvJuzgados.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
    End Sub
End Class