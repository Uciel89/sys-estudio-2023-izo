Public Class infJuzgados
    Private Sub infJuzgados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ministerio_seguridadDataSet.spuJuzgados' Puede moverla o quitarla según sea necesario.
        Me.SpuJuzgadosTableAdapter.Fill(Me.Ministerio_seguridadDataSet.spuJuzgados)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class