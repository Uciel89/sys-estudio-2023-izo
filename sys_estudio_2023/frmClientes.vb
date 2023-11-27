Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaNac.Format = DateTimePickerFormat.Custom
        txtFechaNac.CustomFormat = "yyyy-MM-dd"
        llenarClientes()
        Me.dtvClientes.Columns(10).Visible = False
        flag_abm_cliente = 1
    End Sub

    Private Sub llenarClientes()
        Dim sql As String = "select 
                                cod_cliente, 
                                tipo_documento, 
                                nro_documento, 
                                nombre_cliente, 
                                apellido_cliente, 
                                dom_cliente, 
                                tel_particular,
                                tel_celular, 
                                fecha_nacimiento, 
                                localidades.localidad,
                                clientes.cp
                            from clientes
                            inner join localidades
                            on localidades.cp = clientes.cp"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Clientes")
        adp.Fill(ds.Tables("Clientes"))
        Me.dtvClientes.DataSource = ds.Tables("Clientes")
    End Sub

    Private Sub nuevoCliente()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into Clientes(
                                cod_cliente,
                                tipo_documento, 
                                nro_documento, 
                                nombre_cliente, 
                                apellido_cliente, 
                                dom_cliente, 
                                tel_particular,
                                tel_celular, 
                                fecha_nacimiento, 
                                cp )  
                                values ('" & Me.txtCodClientes.Text & "',
                                         '" & Me.txtTipoDoc.Text & "',
                                        '" & Me.txtNumDoc.Text & "',
                                        '" & Me.txtNombre.Text & "',
                                        '" & Me.txtApellido.Text & "',
                                        '" & Me.txtDomicilio.Text & "',
                                        '" & Me.txtTelPart.Text & "',
                                        '" & Me.txtCelular.Text & "',
                                        '" & Me.txtFechaNac.Text & "',
                                        '" & Me.txtCodPostal.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtTipoDoc.Text <> "" And Me.txtNumDoc.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtDomicilio.Text <> "" And Me.txtTelPart.Text <> "" And Me.txtCelular.Text <> "" And Me.txtFechaNac.Text <> "" And Me.txtCodPostal.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarClientes()
                Me.txtTipoDoc.Clear()
                Me.txtNumDoc.Clear()
                Me.txtNombre.Clear()
                Me.txtApellido.Clear()
                Me.txtDomicilio.Clear()
                Me.txtTelPart.Clear()
                Me.txtCelular.Clear()
                Me.txtCodPostal.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtTipoDoc.Focus()
        End If
    End Sub

    Private Sub updateClientes()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update Clientes set tipo_documento = '" & Me.txtTipoDoc.Text & "', 
                                nro_documento = '" & Me.txtNumDoc.Text & "', 
                                nombre_cliente = '" & Me.txtNombre.Text & "', 
                                apellido_cliente = '" & Me.txtApellido.Text & "', 
                                dom_cliente = '" & Me.txtDomicilio.Text & "', 
                                tel_particular = '" & Me.txtTelPart.Text & "',
                                tel_celular = '" & Me.txtCelular.Text & "', 
                                fecha_nacimiento = '" & Me.txtFechaNac.Text & "', 
                                cp = '" & Me.txtCodPostal.Text & "' 
                                        WHERE cod_cliente = " & codCliente & ""
        cmd.CommandText = sql

        'validacion
        If Me.txtTipoDoc.Text <> "" And Me.txtNumDoc.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtDomicilio.Text <> "" And Me.txtTelPart.Text <> "" And Me.txtCelular.Text <> "" And Me.txtFechaNac.Text <> "" And Me.txtCodPostal.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarClientes()
                Me.txtTipoDoc.Clear()
                Me.txtNumDoc.Clear()
                Me.txtNombre.Clear()
                Me.txtApellido.Clear()
                Me.txtDomicilio.Clear()
                Me.txtTelPart.Clear()
                Me.txtCelular.Clear()
                Me.txtCodPostal.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.Critical, "Error")
            Me.txtTipoDoc.Focus()
        End If

    End Sub

    Private Sub deleteClientes()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete clientes where cod_cliente = " & codCliente & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarClientes()
            Me.txtTipoDoc.Clear()
            Me.txtNumDoc.Clear()
            Me.txtNombre.Clear()
            Me.txtApellido.Clear()
            Me.txtDomicilio.Clear()
            Me.txtTelPart.Clear()
            Me.txtCelular.Clear()
            Me.txtCodPostal.Clear()
        Catch ex As Exception
            MsgBox("La localidad esta utilizada", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnOpenLocalidad_Click(sender As Object, e As EventArgs) Handles btnOpenLocalidad.Click
        Dim last_flag_where As Integer
        flag_where = 4
        last_flag_where = flag_abm_cliente
        Dim frm As New frmLocalidad
        AddOwnedForm(frm)
        frm.ShowDialog()
        flag_abm_cliente = last_flag_where
    End Sub

    Private Sub btnUpdateClientes_Click(sender As Object, e As EventArgs) Handles btnUpdateClientes.Click
        flag_abm_cliente = 2 'UPDATE

        codCliente = Me.dtvClientes.CurrentRow.Cells(0).Value.ToString

        Me.txtCodClientes.Text = Me.dtvClientes.CurrentRow.Cells(0).Value.ToString
        Me.txtTipoDoc.Text = Me.dtvClientes.CurrentRow.Cells(1).Value.ToString
        Me.txtNumDoc.Text = Me.dtvClientes.CurrentRow.Cells(2).Value.ToString
        Me.txtNombre.Text = Me.dtvClientes.CurrentRow.Cells(3).Value.ToString
        Me.txtApellido.Text = Me.dtvClientes.CurrentRow.Cells(4).Value.ToString
        Me.txtDomicilio.Text = Me.dtvClientes.CurrentRow.Cells(5).Value.ToString
        Me.txtTelPart.Text = Me.dtvClientes.CurrentRow.Cells(6).Value.ToString
        Me.txtCelular.Text = Me.dtvClientes.CurrentRow.Cells(7).Value.ToString
        Me.txtFechaNac.Text = Me.dtvClientes.CurrentRow.Cells(8).Value.ToString
        Me.txtCodPostal.Text = Me.dtvClientes.CurrentRow.Cells(10).Value.ToString
        Me.txtTipoDoc.Focus()
    End Sub

    Private Sub btnDeleteClientes_Click(sender As Object, e As EventArgs) Handles btnDeleteClientes.Click
        flag_abm_cliente = 3 'UPDATE
        ' Carga de datos
        codCliente = Me.dtvClientes.CurrentRow.Cells(0).Value.ToString
        Dim AnswerYes As String

        AnswerYes = MsgBox("Desea eliminar este Cliente ?", vbQuestion + vbYesNo, "Eliminar")
        If AnswerYes = vbYes Then
            deleteClientes()
        End If
        flag_abm_cliente = 1
    End Sub

    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        If flag_abm_cliente = 1 Then 'ALTA
            nuevoCliente()
        ElseIf flag_abm_cliente = 2 Then 'UPDATE
            updateClientes()
            flag_abm_cliente = 1
        End If
    End Sub

End Class