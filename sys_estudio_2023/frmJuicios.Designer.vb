<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJuicios
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
        Me.btnGuardarJuicio = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodJuicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescJuicio = New System.Windows.Forms.TextBox()
        Me.dtvJuicios = New System.Windows.Forms.DataGridView()
        Me.btnDeleteJuicio = New System.Windows.Forms.PictureBox()
        Me.btnUpdateJuicio = New System.Windows.Forms.PictureBox()
        CType(Me.dtvJuicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteJuicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateJuicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarJuicio
        '
        Me.btnGuardarJuicio.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarJuicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarJuicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarJuicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarJuicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarJuicio.Location = New System.Drawing.Point(19, 347)
        Me.btnGuardarJuicio.Name = "btnGuardarJuicio"
        Me.btnGuardarJuicio.Size = New System.Drawing.Size(376, 36)
        Me.btnGuardarJuicio.TabIndex = 40
        Me.btnGuardarJuicio.Text = "GUARDAR"
        Me.btnGuardarJuicio.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Código Juicio"
        '
        'txtCodJuicio
        '
        Me.txtCodJuicio.Location = New System.Drawing.Point(19, 311)
        Me.txtCodJuicio.Name = "txtCodJuicio"
        Me.txtCodJuicio.Size = New System.Drawing.Size(107, 20)
        Me.txtCodJuicio.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Descripción del Jucio"
        '
        'txtDescJuicio
        '
        Me.txtDescJuicio.Location = New System.Drawing.Point(132, 311)
        Me.txtDescJuicio.Name = "txtDescJuicio"
        Me.txtDescJuicio.Size = New System.Drawing.Size(263, 20)
        Me.txtDescJuicio.TabIndex = 29
        '
        'dtvJuicios
        '
        Me.dtvJuicios.AllowUserToAddRows = False
        Me.dtvJuicios.AllowUserToDeleteRows = False
        Me.dtvJuicios.AllowUserToResizeColumns = False
        Me.dtvJuicios.AllowUserToResizeRows = False
        Me.dtvJuicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvJuicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvJuicios.Location = New System.Drawing.Point(19, 68)
        Me.dtvJuicios.Name = "dtvJuicios"
        Me.dtvJuicios.ReadOnly = True
        Me.dtvJuicios.Size = New System.Drawing.Size(376, 224)
        Me.dtvJuicios.TabIndex = 23
        '
        'btnDeleteJuicio
        '
        Me.btnDeleteJuicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteJuicio.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteJuicio.Location = New System.Drawing.Point(83, 14)
        Me.btnDeleteJuicio.Name = "btnDeleteJuicio"
        Me.btnDeleteJuicio.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteJuicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteJuicio.TabIndex = 26
        Me.btnDeleteJuicio.TabStop = False
        '
        'btnUpdateJuicio
        '
        Me.btnUpdateJuicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateJuicio.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateJuicio.Location = New System.Drawing.Point(19, 14)
        Me.btnUpdateJuicio.Name = "btnUpdateJuicio"
        Me.btnUpdateJuicio.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateJuicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateJuicio.TabIndex = 25
        Me.btnUpdateJuicio.TabStop = False
        '
        'frmJuicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 394)
        Me.Controls.Add(Me.btnGuardarJuicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodJuicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescJuicio)
        Me.Controls.Add(Me.btnDeleteJuicio)
        Me.Controls.Add(Me.btnUpdateJuicio)
        Me.Controls.Add(Me.dtvJuicios)
        Me.Name = "frmJuicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJuicios"
        CType(Me.dtvJuicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteJuicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateJuicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarJuicio As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodJuicio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescJuicio As TextBox
    Friend WithEvents btnDeleteJuicio As PictureBox
    Friend WithEvents btnUpdateJuicio As PictureBox
    Friend WithEvents dtvJuicios As DataGridView
End Class
