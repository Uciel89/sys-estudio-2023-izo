Public Class frmLocalidad

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarLocalidades()
        flag_abm_localidad = 1
    End Sub

    '-- OBTENER --'

    Private Sub llenarLocalidades()
        Dim sql As String = "select cp as CODICGO_POSTAL ,localidad as LOCALIDAD from localidades"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)


        ds.Tables.Add("localidades")
        adp.Fill(ds.Tables("localidades"))
        Me.dtvLocalidades.DataSource = ds.Tables("localidades")
    End Sub

    '-- NUEVA LOCALIDAD --'
    Private Sub nuevaLocalidad()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into localidades values (" & Me.txtCp.Text & ",'" & Me.txtLocalidades.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCp.Text <> "" Then
            If Me.txtLocalidades.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarLocalidades()
                    Me.txtCp.Clear()
                    Me.txtLocalidades.Clear()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtLocalidades.Focus()
            End If
        Else
            MsgBox("El campo CP no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCp.Focus()
        End If
    End Sub

    '-- ACTUALIZACIÓN LOCALIDAD --'
    Private Sub btnUpdateLocalidad_Click(sender As Object, e As EventArgs) Handles btnUpdateLocalidad.Click
        flag_abm_localidad = 2 'UPDATE
        wcp = Me.dtvLocalidades.CurrentRow.Cells(0).Value

        Me.txtCp.Text = wcp
        Me.txtLocalidades.Text = Me.dtvLocalidades.CurrentRow.Cells(1).Value.ToString
        Me.txtLocalidades.Focus()
    End Sub

    Private Sub updateLocalidades()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update localidades set localidad = '" & Me.txtLocalidades.Text & "' where cp = " & wcp & ""
        cmd.CommandText = sql
        'validacion
        If Me.txtLocalidades.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarLocalidades()
                Me.txtCp.Clear()
                Me.txtLocalidades.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo LOCALIDAD no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtLocalidades.Focus()
        End If
        flag_abm_localidad = 1
    End Sub

    '-- BORRAR LOCALIDAD --'
    Private Sub deleteLocalidades()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete localidades where cp = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarLocalidades()
            Me.txtCp.Clear()
        Catch ex As Exception
            MsgBox("La localidad esta utilizada", MsgBoxStyle.Critical, "Error")
        End Try
        flag_abm_localidad = 1
    End Sub

    Private Sub btnDeleteLocalidad_Click(sender As Object, e As EventArgs) Handles btnDeleteLocalidad.Click
        flag_abm_localidad = 3 'DELETE
        wcp = Me.dtvLocalidades.CurrentRow.Cells(0).Value
        Me.txtCp.Text = wcp
        Me.txtLocalidades.Text = Me.dtvLocalidades.CurrentRow.Cells(1).Value.ToString
        Dim AnswerYes As String

        AnswerYes = MsgBox("Desea eliminar esta localidad ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteLocalidades()
        End If
        flag_abm_localidad = 1
    End Sub

    Private Sub btnGuardarLocalidad_Click(sender As Object, e As EventArgs) Handles btnGuardarLocalidad.Click

        If flag_abm_localidad = 1 Then 'ALTA
            nuevaLocalidad()
        ElseIf flag_abm_localidad = 2 Then 'UPDATE
            updateLocalidades()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmJuzgado.ShowDialog()
    End Sub

    Private Sub dtvLocalidades_KeyDown(sender As Object, e As KeyEventArgs) Handles dtvLocalidades.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmJuzgado = CType(Owner, frmJuzgado)
                frm.txtCp.Text = Me.dtvLocalidades.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
        If flag_where = 4 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmClientes = CType(Owner, frmClientes)
                frm.txtCodPostal.Text = Me.dtvLocalidades.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
    End Sub

End Class
