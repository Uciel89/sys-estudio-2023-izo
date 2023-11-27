Public Class infExpedienteFecha
    Private Sub infExpedienteFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SpuExpedienteFechaTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuExpedienteFecha, fecha_desde, fecha_hasta)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class