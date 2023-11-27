<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstados
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
        Me.btnGuardarEstados = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodEstados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescEstados = New System.Windows.Forms.TextBox()
        Me.btnDeleteEstudios = New System.Windows.Forms.PictureBox()
        Me.btnUpdateEstados = New System.Windows.Forms.PictureBox()
        Me.dtvEstados = New System.Windows.Forms.DataGridView()
        CType(Me.btnDeleteEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarEstados
        '
        Me.btnGuardarEstados.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarEstados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEstados.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarEstados.Location = New System.Drawing.Point(20, 349)
        Me.btnGuardarEstados.Name = "btnGuardarEstados"
        Me.btnGuardarEstados.Size = New System.Drawing.Size(354, 36)
        Me.btnGuardarEstados.TabIndex = 49
        Me.btnGuardarEstados.Text = "GUARDAR"
        Me.btnGuardarEstados.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Código Estado"
        '
        'txtCodEstados
        '
        Me.txtCodEstados.Location = New System.Drawing.Point(20, 314)
        Me.txtCodEstados.Name = "txtCodEstados"
        Me.txtCodEstados.Size = New System.Drawing.Size(116, 20)
        Me.txtCodEstados.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Descripción Estados"
        '
        'txtDescEstados
        '
        Me.txtDescEstados.Location = New System.Drawing.Point(142, 314)
        Me.txtDescEstados.Name = "txtDescEstados"
        Me.txtDescEstados.Size = New System.Drawing.Size(232, 20)
        Me.txtDescEstados.TabIndex = 45
        '
        'btnDeleteEstudios
        '
        Me.btnDeleteEstudios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteEstudios.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteEstudios.Location = New System.Drawing.Point(84, 14)
        Me.btnDeleteEstudios.Name = "btnDeleteEstudios"
        Me.btnDeleteEstudios.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteEstudios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteEstudios.TabIndex = 44
        Me.btnDeleteEstudios.TabStop = False
        '
        'btnUpdateEstados
        '
        Me.btnUpdateEstados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateEstados.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateEstados.Location = New System.Drawing.Point(20, 14)
        Me.btnUpdateEstados.Name = "btnUpdateEstados"
        Me.btnUpdateEstados.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateEstados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateEstados.TabIndex = 43
        Me.btnUpdateEstados.TabStop = False
        '
        'dtvEstados
        '
        Me.dtvEstados.AllowUserToAddRows = False
        Me.dtvEstados.AllowUserToDeleteRows = False
        Me.dtvEstados.AllowUserToResizeColumns = False
        Me.dtvEstados.AllowUserToResizeRows = False
        Me.dtvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvEstados.Location = New System.Drawing.Point(20, 68)
        Me.dtvEstados.Name = "dtvEstados"
        Me.dtvEstados.ReadOnly = True
        Me.dtvEstados.Size = New System.Drawing.Size(354, 224)
        Me.dtvEstados.TabIndex = 41
        '
        'frmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 399)
        Me.Controls.Add(Me.btnGuardarEstados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodEstados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescEstados)
        Me.Controls.Add(Me.btnDeleteEstudios)
        Me.Controls.Add(Me.btnUpdateEstados)
        Me.Controls.Add(Me.dtvEstados)
        Me.Name = "frmEstados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEstados"
        CType(Me.btnDeleteEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarEstados As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodEstados As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescEstados As TextBox
    Friend WithEvents btnDeleteEstudios As PictureBox
    Friend WithEvents btnUpdateEstados As PictureBox
    Friend WithEvents dtvEstados As DataGridView
End Class
