Public Class frmClientesExpedientes
    Private Sub frmClientesExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarClientes()
        llenarExpedientes()

    End Sub

    Private Sub llenarClientes()
        Dim sql As String = "select 
                                cli.cod_cliente as COD_CLIENTE,
                                cli.tipo_documento AS TIPO_DOCUMENTO,
                                cli.nro_documento AS NRO_DOCUMENTO,
                                cli.nombre_cliente AS NOMBRE_CLIENTE,
                                cli.apellido_cliente AS APELLIDO_CLIENTE,
                                cli.dom_cliente AS DIR_CLIENTE,
                                cli.tel_particular AS TEL_PARTICULAR,
                                cli.tel_celular AS TEL_CELULAR,
                                cli.fecha_nacimiento AS FECHA_NACIMIENTO,
                                l.localidad AS LOCALIDAD
                            from clientes as cli
                            INNER JOIN localidades as l
                            ON l.cp = cli.cp"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("clientes")
        adp.Fill(ds.Tables("clientes"))
        Me.dgvClientes.DataSource = ds.Tables("clientes")
        'Me.dgvClientes.Columns("CP").Visible = False
    End Sub

    Private Sub llenarExpedientes()
        Dim sql

        sql = "select 
                                exp.cod_expediente AS COD_EXPEDIENTE,
                                exp.caratula_expediente AS CARATURA_EXPEDIENTE,
                                est.descripcion AS ESTADO,
                                jco.descripcion AS TIPO_JUICIO,
                                exp.cod_juzgado AS COD_JUZGADO,
                                fecha_inicio as FECHA_INICIO
                            from expedientes as exp
                            INNER JOIN estados as est
                            ON exp.cod_estado = est.cod_estado
                            INNER JOIN juicios as jco
                            ON jco.cod_juicio = exp.cod_juicio
                            WHERE NOT EXISTS(SELECT * FROM clientes_expedientes WHERE cod_expediente = exp.cod_expediente)"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("expedientes")
        adp.Fill(ds.Tables("expedientes"))
        Me.dgvExpedientes.DataSource = ds.Tables("expedientes")
        'Me.dgvExpedientes.Columns("CP").Visible = False
    End Sub

    Private Sub nuevoClienteExpediente()
        Dim cod_expediente
        cod_expediente = Me.dgvExpedientes.CurrentRow.Cells(0).Value

        Dim cod_cliente
        cod_cliente = Me.dgvClientes.CurrentRow.Cells(0).Value

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into clientes_expedientes values (" & cod_cliente & ",'" & cod_expediente & "', '" & Me.txtTipoDemanda.Text & "')"
        cmd.CommandText = sql

        'validacion
        If cod_cliente.ToString <> "" Then
            If cod_expediente.ToString <> "" Then
                If Me.txtTipoDemanda.Text <> "" Then
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro guardado con exito", MsgBoxStyle.Information, "Guardado")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("Por favor ingresar un tipo de demanda", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Por favor seleccionar un código de expediente.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Por favor seleccionar un código de cliente.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        nuevoClienteExpediente()
        llenarClientes()
        llenarExpedientes()
    End Sub

    Private Sub dgvExpedientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpedientes.CellContentClick

    End Sub
End Class