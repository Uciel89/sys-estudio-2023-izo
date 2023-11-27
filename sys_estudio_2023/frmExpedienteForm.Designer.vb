<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpedienteForm
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
        Me.btnGuardarExpediente = New System.Windows.Forms.Button()
        Me.btnOpenJuzgado = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodExpediente = New System.Windows.Forms.TextBox()
        Me.txtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodEstado = New System.Windows.Forms.TextBox()
        Me.txtCaratulaExpediente = New System.Windows.Forms.TextBox()
        Me.txtCodJuicio = New System.Windows.Forms.TextBox()
        Me.dtvExpedientes = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodJuzgado = New System.Windows.Forms.TextBox()
        Me.btnOpenJuicio = New System.Windows.Forms.Button()
        Me.btnOpenEstado = New System.Windows.Forms.Button()
        Me.btnDeleteExpediente = New System.Windows.Forms.PictureBox()
        Me.btnUpdateExpedientes = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dtvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarExpediente
        '
        Me.btnGuardarExpediente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarExpediente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarExpediente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarExpediente.Location = New System.Drawing.Point(250, 460)
        Me.btnGuardarExpediente.Name = "btnGuardarExpediente"
        Me.btnGuardarExpediente.Size = New System.Drawing.Size(200, 36)
        Me.btnGuardarExpediente.TabIndex = 40
        Me.btnGuardarExpediente.Text = "GUARDAR"
        Me.btnGuardarExpediente.UseVisualStyleBackColor = False
        '
        'btnOpenJuzgado
        '
        Me.btnOpenJuzgado.Location = New System.Drawing.Point(379, 19)
        Me.btnOpenJuzgado.Name = "btnOpenJuzgado"
        Me.btnOpenJuzgado.Size = New System.Drawing.Size(58, 20)
        Me.btnOpenJuzgado.TabIndex = 39
        Me.btnOpenJuzgado.Text = "..."
        Me.btnOpenJuzgado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Código Expediente"
        '
        'txtCodExpediente
        '
        Me.txtCodExpediente.Location = New System.Drawing.Point(3, 19)
        Me.txtCodExpediente.Name = "txtCodExpediente"
        Me.txtCodExpediente.Size = New System.Drawing.Size(197, 20)
        Me.txtCodExpediente.TabIndex = 37
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Location = New System.Drawing.Point(235, 109)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(197, 20)
        Me.txtFechaInicio.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fecha Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Código Juicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Código Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Caratula Expediente"
        '
        'txtCodEstado
        '
        Me.txtCodEstado.Location = New System.Drawing.Point(3, 65)
        Me.txtCodEstado.Name = "txtCodEstado"
        Me.txtCodEstado.ReadOnly = True
        Me.txtCodEstado.Size = New System.Drawing.Size(138, 20)
        Me.txtCodEstado.TabIndex = 30
        '
        'txtCaratulaExpediente
        '
        Me.txtCaratulaExpediente.Location = New System.Drawing.Point(232, 65)
        Me.txtCaratulaExpediente.Name = "txtCaratulaExpediente"
        Me.txtCaratulaExpediente.Size = New System.Drawing.Size(197, 20)
        Me.txtCaratulaExpediente.TabIndex = 29
        '
        'txtCodJuicio
        '
        Me.txtCodJuicio.Location = New System.Drawing.Point(3, 109)
        Me.txtCodJuicio.Name = "txtCodJuicio"
        Me.txtCodJuicio.ReadOnly = True
        Me.txtCodJuicio.Size = New System.Drawing.Size(138, 20)
        Me.txtCodJuicio.TabIndex = 27
        '
        'dtvExpedientes
        '
        Me.dtvExpedientes.AllowUserToAddRows = False
        Me.dtvExpedientes.AllowUserToDeleteRows = False
        Me.dtvExpedientes.AllowUserToResizeColumns = False
        Me.dtvExpedientes.AllowUserToResizeRows = False
        Me.dtvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvExpedientes.Location = New System.Drawing.Point(12, 63)
        Me.dtvExpedientes.Name = "dtvExpedientes"
        Me.dtvExpedientes.ReadOnly = True
        Me.dtvExpedientes.Size = New System.Drawing.Size(676, 224)
        Me.dtvExpedientes.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Código Juzgado"
        '
        'txtCodJuzgado
        '
        Me.txtCodJuzgado.Location = New System.Drawing.Point(232, 19)
        Me.txtCodJuzgado.Name = "txtCodJuzgado"
        Me.txtCodJuzgado.ReadOnly = True
        Me.txtCodJuzgado.Size = New System.Drawing.Size(141, 20)
        Me.txtCodJuzgado.TabIndex = 42
        '
        'btnOpenJuicio
        '
        Me.btnOpenJuicio.Location = New System.Drawing.Point(147, 109)
        Me.btnOpenJuicio.Name = "btnOpenJuicio"
        Me.btnOpenJuicio.Size = New System.Drawing.Size(58, 20)
        Me.btnOpenJuicio.TabIndex = 43
        Me.btnOpenJuicio.Text = "..."
        Me.btnOpenJuicio.UseVisualStyleBackColor = True
        '
        'btnOpenEstado
        '
        Me.btnOpenEstado.Location = New System.Drawing.Point(147, 65)
        Me.btnOpenEstado.Name = "btnOpenEstado"
        Me.btnOpenEstado.Size = New System.Drawing.Size(58, 20)
        Me.btnOpenEstado.TabIndex = 44
        Me.btnOpenEstado.Text = "..."
        Me.btnOpenEstado.UseVisualStyleBackColor = True
        '
        'btnDeleteExpediente
        '
        Me.btnDeleteExpediente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteExpediente.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteExpediente.Location = New System.Drawing.Point(76, 9)
        Me.btnDeleteExpediente.Name = "btnDeleteExpediente"
        Me.btnDeleteExpediente.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteExpediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteExpediente.TabIndex = 26
        Me.btnDeleteExpediente.TabStop = False
        '
        'btnUpdateExpedientes
        '
        Me.btnUpdateExpedientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateExpedientes.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateExpedientes.Location = New System.Drawing.Point(12, 9)
        Me.btnUpdateExpedientes.Name = "btnUpdateExpedientes"
        Me.btnUpdateExpedientes.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateExpedientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateExpedientes.TabIndex = 25
        Me.btnUpdateExpedientes.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOpenEstado)
        Me.Panel1.Controls.Add(Me.txtCodExpediente)
        Me.Panel1.Controls.Add(Me.btnOpenJuicio)
        Me.Panel1.Controls.Add(Me.txtCodJuicio)
        Me.Panel1.Controls.Add(Me.txtCodJuzgado)
        Me.Panel1.Controls.Add(Me.txtCaratulaExpediente)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtCodEstado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnOpenJuzgado)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFechaInicio)
        Me.Panel1.Location = New System.Drawing.Point(133, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 142)
        Me.Panel1.TabIndex = 45
        '
        'frmExpedienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 512)
        Me.Controls.Add(Me.btnGuardarExpediente)
        Me.Controls.Add(Me.btnDeleteExpediente)
        Me.Controls.Add(Me.btnUpdateExpedientes)
        Me.Controls.Add(Me.dtvExpedientes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmExpedienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Expedientes"
        CType(Me.dtvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarExpediente As Button
    Friend WithEvents btnOpenJuzgado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodExpediente As TextBox
    Friend WithEvents txtFechaInicio As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodEstado As TextBox
    Friend WithEvents txtCaratulaExpediente As TextBox
    Friend WithEvents txtCodJuicio As TextBox
    Friend WithEvents btnDeleteExpediente As PictureBox
    Friend WithEvents btnUpdateExpedientes As PictureBox
    Friend WithEvents btnAddLocalidad As PictureBox
    Friend WithEvents dtvExpedientes As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodJuzgado As TextBox
    Friend WithEvents btnOpenJuicio As Button
    Friend WithEvents btnOpenEstado As Button
    Friend WithEvents Panel1 As Panel
End Class
