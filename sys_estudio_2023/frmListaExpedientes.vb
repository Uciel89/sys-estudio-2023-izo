Public Class frmListaExpedientes

    Private Sub frmExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaDesde.Format = DateTimePickerFormat.Custom
        txtFechaDesde.CustomFormat = "yyyy-MM-dd"

        txtFechaHasta.Format = DateTimePickerFormat.Custom
        txtFechaHasta.CustomFormat = "yyyy-MM-dd"

    End Sub

    ' Funciones de busqueda de expedientes
    Private Sub buscarExpCliente()
        Dim sql As String = "exec spuExpedienteCliente '" & nombre_cliente & "' "
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("expedientes")
        adp.Fill(ds.Tables("expedientes"))
        Me.dgvExpedientes.DataSource = ds.Tables("expedientes")

    End Sub

    Private Sub buscarFecha()
        Dim sql As String = "exec spuExpedienteFecha '" & fecha_desde & "', '" & fecha_hasta & "'  "
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("expedientes")
        adp.Fill(ds.Tables("expedientes"))
        Me.dgvExpedientes.DataSource = ds.Tables("expedientes")

    End Sub

    Private Sub buscarNro()
        Dim sql As String = "exec spuExpedientesNumero '" & cod_expediente & "'  "
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("expedientes")
        adp.Fill(ds.Tables("expedientes"))
        Me.dgvExpedientes.DataSource = ds.Tables("expedientes")

    End Sub

    Private Sub txtNombreCliente_Enter(sender As Object, e As EventArgs) Handles txtNombreCliente.Enter
        flag_spu = 1
    End Sub

    Private Sub txtFechaDesde_Enter(sender As Object, e As EventArgs) Handles txtFechaDesde.Enter
        flag_spu = 2
    End Sub

    Private Sub txtNombreExpediente_Enter(sender As Object, e As EventArgs) Handles txtNroExpediente.Enter
        flag_spu = 3
    End Sub

    Private Sub btnBuscarExpediente_Click(sender As Object, e As EventArgs) Handles btnBuscarExpediente.Click
        If flag_spu = 1 Then
            nombre_cliente = txtNombreCliente.Text
            buscarExpCliente()
        ElseIf flag_spu = 2 Then
            fecha_desde = txtFechaDesde.Text
            fecha_hasta = txtFechaHasta.Text
            buscarFecha()
        ElseIf flag_spu = 3 Then
            cod_expediente = Int(txtNroExpediente.Text)
            buscarNro()
        End If

    End Sub

    Private Sub btnImprimirExpediente_Click(sender As Object, e As EventArgs) Handles btnImprimirExpediente.Click
        If flag_spu = 1 Then
            infExpedienteCliente.ShowDialog()
        ElseIf flag_spu = 2 Then
            infExpedienteFecha.ShowDialog()
        ElseIf flag_spu = 3 Then
            infExpedienteNumero.ShowDialog()
        End If
    End Sub

    Private Sub btnAgregarExpediente_Click(sender As Object, e As EventArgs) Handles btnAgregarExpediente.Click
        frmExpedienteForm.ShowDialog()
    End Sub
End Class