Public Class infExpedienteCliente
    Private Sub infExpedienteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SpuExpedienteClienteTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuExpedienteCliente, nombre_cliente)
        Me.SpuExpedienteClienteTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuExpedienteCliente, nombre_cliente)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class