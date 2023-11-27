Public Class infExpedienteNumero
    Private Sub infExpedienteNumero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SpuExpedientesNumeroTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuExpedientesNumero, cod_expediente)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class