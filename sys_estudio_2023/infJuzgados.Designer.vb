<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class infJuzgados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Ministerio_seguridadDataSet = New sys_estudio_2023.ministerio_seguridadDataSet()
        Me.SpuJuzgadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpuJuzgadosTableAdapter = New sys_estudio_2023.ministerio_seguridadDataSetTableAdapters.spuJuzgadosTableAdapter()
        CType(Me.Ministerio_seguridadDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpuJuzgadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet"
        ReportDataSource1.Value = Me.SpuJuzgadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_estudio_2023.informeJuzgados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Ministerio_seguridadDataSet
        '
        Me.Ministerio_seguridadDataSet.DataSetName = "ministerio_seguridadDataSet"
        Me.Ministerio_seguridadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpuJuzgadosBindingSource
        '
        Me.SpuJuzgadosBindingSource.DataMember = "spuJuzgados"
        Me.SpuJuzgadosBindingSource.DataSource = Me.Ministerio_seguridadDataSet
        '
        'SpuJuzgadosTableAdapter
        '
        Me.SpuJuzgadosTableAdapter.ClearBeforeFill = True
        '
        'infJuzgados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "infJuzgados"
        Me.Text = "infJuzgados"
        CType(Me.Ministerio_seguridadDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpuJuzgadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Ministerio_seguridadDataSet As ministerio_seguridadDataSet
    Friend WithEvents SpuJuzgadosBindingSource As BindingSource
    Friend WithEvents SpuJuzgadosTableAdapter As ministerio_seguridadDataSetTableAdapters.spuJuzgadosTableAdapter
End Class
