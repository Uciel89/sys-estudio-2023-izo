<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocalidad
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
        Me.dtvLocalidades = New System.Windows.Forms.DataGridView()
        Me.labelCP = New System.Windows.Forms.Label()
        Me.labelLocalidades = New System.Windows.Forms.Label()
        Me.btnGuardarLocalidad = New System.Windows.Forms.Button()
        Me.txtLocalidades = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.btnDeleteLocalidad = New System.Windows.Forms.PictureBox()
        Me.btnUpdateLocalidad = New System.Windows.Forms.PictureBox()
        CType(Me.dtvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvLocalidades
        '
        Me.dtvLocalidades.AllowUserToAddRows = False
        Me.dtvLocalidades.AllowUserToDeleteRows = False
        Me.dtvLocalidades.AllowUserToResizeColumns = False
        Me.dtvLocalidades.AllowUserToResizeRows = False
        Me.dtvLocalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvLocalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtvLocalidades.Location = New System.Drawing.Point(12, 66)
        Me.dtvLocalidades.Name = "dtvLocalidades"
        Me.dtvLocalidades.ReadOnly = True
        Me.dtvLocalidades.Size = New System.Drawing.Size(383, 214)
        Me.dtvLocalidades.TabIndex = 0
        '
        'labelCP
        '
        Me.labelCP.AutoSize = True
        Me.labelCP.Location = New System.Drawing.Point(9, 286)
        Me.labelCP.Name = "labelCP"
        Me.labelCP.Size = New System.Drawing.Size(21, 13)
        Me.labelCP.TabIndex = 4
        Me.labelCP.Text = "CP"
        '
        'labelLocalidades
        '
        Me.labelLocalidades.AutoSize = True
        Me.labelLocalidades.Location = New System.Drawing.Point(131, 289)
        Me.labelLocalidades.Name = "labelLocalidades"
        Me.labelLocalidades.Size = New System.Drawing.Size(53, 13)
        Me.labelLocalidades.TabIndex = 5
        Me.labelLocalidades.Text = "Localidad"
        '
        'btnGuardarLocalidad
        '
        Me.btnGuardarLocalidad.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarLocalidad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarLocalidad.Location = New System.Drawing.Point(12, 340)
        Me.btnGuardarLocalidad.Name = "btnGuardarLocalidad"
        Me.btnGuardarLocalidad.Size = New System.Drawing.Size(383, 36)
        Me.btnGuardarLocalidad.TabIndex = 6
        Me.btnGuardarLocalidad.Text = "GUARDAR"
        Me.btnGuardarLocalidad.UseVisualStyleBackColor = False
        '
        'txtLocalidades
        '
        Me.txtLocalidades.Location = New System.Drawing.Point(134, 305)
        Me.txtLocalidades.Name = "txtLocalidades"
        Me.txtLocalidades.Size = New System.Drawing.Size(261, 20)
        Me.txtLocalidades.TabIndex = 7
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(12, 305)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(116, 20)
        Me.txtCp.TabIndex = 8
        '
        'btnDeleteLocalidad
        '
        Me.btnDeleteLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteLocalidad.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteLocalidad.Location = New System.Drawing.Point(76, 12)
        Me.btnDeleteLocalidad.Name = "btnDeleteLocalidad"
        Me.btnDeleteLocalidad.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteLocalidad.TabIndex = 3
        Me.btnDeleteLocalidad.TabStop = False
        '
        'btnUpdateLocalidad
        '
        Me.btnUpdateLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateLocalidad.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateLocalidad.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateLocalidad.Name = "btnUpdateLocalidad"
        Me.btnUpdateLocalidad.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateLocalidad.TabIndex = 2
        Me.btnUpdateLocalidad.TabStop = False
        '
        'frmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 388)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtLocalidades)
        Me.Controls.Add(Me.btnGuardarLocalidad)
        Me.Controls.Add(Me.labelLocalidades)
        Me.Controls.Add(Me.labelCP)
        Me.Controls.Add(Me.btnDeleteLocalidad)
        Me.Controls.Add(Me.btnUpdateLocalidad)
        Me.Controls.Add(Me.dtvLocalidades)
        Me.Name = "frmLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localidades"
        CType(Me.dtvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtvLocalidades As DataGridView
    Friend WithEvents btnUpdateLocalidad As PictureBox
    Friend WithEvents btnDeleteLocalidad As PictureBox
    Friend WithEvents labelCP As Label
    Friend WithEvents labelLocalidades As Label
    Friend WithEvents btnGuardarLocalidad As Button
    Friend WithEvents txtLocalidades As TextBox
    Friend WithEvents txtCp As TextBox
End Class
