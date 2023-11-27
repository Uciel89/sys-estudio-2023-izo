<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infExpedienteFecha
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Ministerio_seguridadDataSet = New sys_estudio_2023.ministerio_seguridadDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SpuExpedienteFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpuExpedienteFechaTableAdapter = New sys_estudio_2023.ministerio_seguridadDataSetTableAdapters.spuExpedienteFechaTableAdapter()
        CType(Me.Ministerio_seguridadDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpuExpedienteFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ministerio_seguridadDataSet
        '
        Me.Ministerio_seguridadDataSet.DataSetName = "ministerio_seguridadDataSet"
        Me.Ministerio_seguridadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SpuExpedienteFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_estudio_2023.informeExpedienteFecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'SpuExpedienteFechaBindingSource
        '
        Me.SpuExpedienteFechaBindingSource.DataMember = "spuExpedienteFecha"
        Me.SpuExpedienteFechaBindingSource.DataSource = Me.Ministerio_seguridadDataSet
        '
        'SpuExpedienteFechaTableAdapter
        '
        Me.SpuExpedienteFechaTableAdapter.ClearBeforeFill = True
        '
        'infExpedienteFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "infExpedienteFecha"
        Me.Text = "informeExpedienteFecha"
        CType(Me.Ministerio_seguridadDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpuExpedienteFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Ministerio_seguridadDataSet As ministerio_seguridadDataSet
    Friend WithEvents SpuExpedienteFechaBindingSource As BindingSource
    Friend WithEvents SpuExpedienteFechaTableAdapter As ministerio_seguridadDataSetTableAdapters.spuExpedienteFechaTableAdapter
End Class
