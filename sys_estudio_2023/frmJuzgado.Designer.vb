<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJuzgado
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
        Me.dtvJuzgados = New System.Windows.Forms.DataGridView()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.txtNombreJuez = New System.Windows.Forms.TextBox()
        Me.txtNombreSecretario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodJuzgado = New System.Windows.Forms.TextBox()
        Me.btnLocalidad = New System.Windows.Forms.Button()
        Me.btnGuardarJuzgado = New System.Windows.Forms.Button()
        Me.btnDeleteJuzgado = New System.Windows.Forms.PictureBox()
        Me.btnUpdateLocalidad = New System.Windows.Forms.PictureBox()
        CType(Me.dtvJuzgados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteJuzgado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvJuzgados
        '
        Me.dtvJuzgados.AllowUserToAddRows = False
        Me.dtvJuzgados.AllowUserToDeleteRows = False
        Me.dtvJuzgados.AllowUserToResizeColumns = False
        Me.dtvJuzgados.AllowUserToResizeRows = False
        Me.dtvJuzgados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvJuzgados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvJuzgados.Location = New System.Drawing.Point(12, 67)
        Me.dtvJuzgados.Name = "dtvJuzgados"
        Me.dtvJuzgados.ReadOnly = True
        Me.dtvJuzgados.Size = New System.Drawing.Size(666, 224)
        Me.dtvJuzgados.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(360, 319)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(197, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(360, 414)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.ReadOnly = True
        Me.txtCp.Size = New System.Drawing.Size(133, 20)
        Me.txtCp.TabIndex = 9
        '
        'txtNombreJuez
        '
        Me.txtNombreJuez.Location = New System.Drawing.Point(115, 366)
        Me.txtNombreJuez.Name = "txtNombreJuez"
        Me.txtNombreJuez.Size = New System.Drawing.Size(197, 20)
        Me.txtNombreJuez.TabIndex = 11
        '
        'txtNombreSecretario
        '
        Me.txtNombreSecretario.Location = New System.Drawing.Point(115, 414)
        Me.txtNombreSecretario.Name = "txtNombreSecretario"
        Me.txtNombreSecretario.Size = New System.Drawing.Size(197, 20)
        Me.txtNombreSecretario.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre juez trámite"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre secretario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fecha alta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cp"
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Location = New System.Drawing.Point(360, 366)
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Size = New System.Drawing.Size(197, 20)
        Me.txtFechaAlta.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Código juzgado"
        '
        'txtCodJuzgado
        '
        Me.txtCodJuzgado.Location = New System.Drawing.Point(115, 319)
        Me.txtCodJuzgado.Name = "txtCodJuzgado"
        Me.txtCodJuzgado.Size = New System.Drawing.Size(197, 20)
        Me.txtCodJuzgado.TabIndex = 19
        '
        'btnLocalidad
        '
        Me.btnLocalidad.Location = New System.Drawing.Point(499, 414)
        Me.btnLocalidad.Name = "btnLocalidad"
        Me.btnLocalidad.Size = New System.Drawing.Size(58, 20)
        Me.btnLocalidad.TabIndex = 21
        Me.btnLocalidad.Text = "..."
        Me.btnLocalidad.UseVisualStyleBackColor = True
        '
        'btnGuardarJuzgado
        '
        Me.btnGuardarJuzgado.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarJuzgado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarJuzgado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarJuzgado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarJuzgado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarJuzgado.Location = New System.Drawing.Point(115, 456)
        Me.btnGuardarJuzgado.Name = "btnGuardarJuzgado"
        Me.btnGuardarJuzgado.Size = New System.Drawing.Size(442, 36)
        Me.btnGuardarJuzgado.TabIndex = 22
        Me.btnGuardarJuzgado.Text = "GUARDAR"
        Me.btnGuardarJuzgado.UseVisualStyleBackColor = False
        '
        'btnDeleteJuzgado
        '
        Me.btnDeleteJuzgado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteJuzgado.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteJuzgado.Location = New System.Drawing.Point(76, 12)
        Me.btnDeleteJuzgado.Name = "btnDeleteJuzgado"
        Me.btnDeleteJuzgado.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteJuzgado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteJuzgado.TabIndex = 6
        Me.btnDeleteJuzgado.TabStop = False
        '
        'btnUpdateLocalidad
        '
        Me.btnUpdateLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateLocalidad.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateLocalidad.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateLocalidad.Name = "btnUpdateLocalidad"
        Me.btnUpdateLocalidad.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateLocalidad.TabIndex = 5
        Me.btnUpdateLocalidad.TabStop = False
        '
        'frmJuzgado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 512)
        Me.Controls.Add(Me.btnGuardarJuzgado)
        Me.Controls.Add(Me.btnLocalidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodJuzgado)
        Me.Controls.Add(Me.txtFechaAlta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreSecretario)
        Me.Controls.Add(Me.txtNombreJuez)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnDeleteJuzgado)
        Me.Controls.Add(Me.btnUpdateLocalidad)
        Me.Controls.Add(Me.dtvJuzgados)
        Me.Name = "frmJuzgado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juzgados"
        CType(Me.dtvJuzgados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteJuzgado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtvJuzgados As DataGridView
    Friend WithEvents btnDeleteJuzgado As PictureBox
    Friend WithEvents btnUpdateLocalidad As PictureBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCp As TextBox
    Friend WithEvents txtNombreJuez As TextBox
    Friend WithEvents txtNombreSecretario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaAlta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodJuzgado As TextBox
    Friend WithEvents btnLocalidad As Button
    Friend WithEvents btnGuardarJuzgado As Button
End Class
