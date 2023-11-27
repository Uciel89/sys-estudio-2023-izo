Public Class infClientes
    Private Sub infClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ministerio_seguridadDataSet.spuClientes' Puede moverla o quitarla según sea necesario.
        Me.SpuClientesTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuClientes)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class