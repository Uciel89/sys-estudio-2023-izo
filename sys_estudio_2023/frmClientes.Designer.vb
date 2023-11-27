<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dtvClientes = New System.Windows.Forms.DataGridView()
        Me.btnDeleteClientes = New System.Windows.Forms.PictureBox()
        Me.btnUpdateClientes = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelPart = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Domicilio = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.btnOpenLocalidad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodClientes = New System.Windows.Forms.TextBox()
        CType(Me.dtvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarCliente.Location = New System.Drawing.Point(264, 518)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(269, 44)
        Me.btnGuardarCliente.TabIndex = 49
        Me.btnGuardarCliente.Text = "GUARDAR"
        Me.btnGuardarCliente.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(174, 353)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(174, 398)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(212, 20)
        Me.txtApellido.TabIndex = 45
        '
        'dtvClientes
        '
        Me.dtvClientes.AllowUserToAddRows = False
        Me.dtvClientes.AllowUserToDeleteRows = False
        Me.dtvClientes.AllowUserToResizeColumns = False
        Me.dtvClientes.AllowUserToResizeRows = False
        Me.dtvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvClientes.Location = New System.Drawing.Point(12, 75)
        Me.dtvClientes.Name = "dtvClientes"
        Me.dtvClientes.ReadOnly = True
        Me.dtvClientes.Size = New System.Drawing.Size(776, 201)
        Me.dtvClientes.TabIndex = 41
        '
        'btnDeleteClientes
        '
        Me.btnDeleteClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteClientes.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_delete
        Me.btnDeleteClientes.Location = New System.Drawing.Point(76, 21)
        Me.btnDeleteClientes.Name = "btnDeleteClientes"
        Me.btnDeleteClientes.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteClientes.TabIndex = 44
        Me.btnDeleteClientes.TabStop = False
        '
        'btnUpdateClientes
        '
        Me.btnUpdateClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateClientes.Image = Global.sys_estudio_2023.My.Resources.Resources.icon_update
        Me.btnUpdateClientes.Location = New System.Drawing.Point(12, 21)
        Me.btnUpdateClientes.Name = "btnUpdateClientes"
        Me.btnUpdateClientes.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdateClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUpdateClientes.TabIndex = 43
        Me.btnUpdateClientes.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Tipo documento"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(174, 487)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(212, 20)
        Me.txtTipoDoc.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Número documento"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(406, 303)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(212, 20)
        Me.txtNumDoc.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Código postal"
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(404, 487)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.ReadOnly = True
        Me.txtCodPostal.Size = New System.Drawing.Size(129, 20)
        Me.txtCodPostal.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Teléfono celular"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(404, 398)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(212, 20)
        Me.txtCelular.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Fecha nacimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(401, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Teléfono particular"
        '
        'txtTelPart
        '
        Me.txtTelPart.Location = New System.Drawing.Point(404, 352)
        Me.txtTelPart.Name = "txtTelPart"
        Me.txtTelPart.Size = New System.Drawing.Size(214, 20)
        Me.txtTelPart.TabIndex = 62
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(404, 437)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(212, 20)
        Me.txtFechaNac.TabIndex = 64
        '
        'Domicilio
        '
        Me.Domicilio.AutoSize = True
        Me.Domicilio.Location = New System.Drawing.Point(173, 421)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(49, 13)
        Me.Domicilio.TabIndex = 66
        Me.Domicilio.Text = "Domicilio"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(175, 436)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(212, 20)
        Me.txtDomicilio.TabIndex = 65
        '
        'btnOpenLocalidad
        '
        Me.btnOpenLocalidad.Location = New System.Drawing.Point(539, 487)
        Me.btnOpenLocalidad.Name = "btnOpenLocalidad"
        Me.btnOpenLocalidad.Size = New System.Drawing.Size(79, 20)
        Me.btnOpenLocalidad.TabIndex = 67
        Me.btnOpenLocalidad.Text = "..."
        Me.btnOpenLocalidad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Cod Cliente"
        '
        'txtCodClientes
        '
        Me.txtCodClientes.Location = New System.Drawing.Point(176, 303)
        Me.txtCodClientes.Name = "txtCodClientes"
        Me.txtCodClientes.Size = New System.Drawing.Size(212, 20)
        Me.txtCodClientes.TabIndex = 68
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 574)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodClientes)
        Me.Controls.Add(Me.btnOpenLocalidad)
        Me.Controls.Add(Me.Domicilio)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelPart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.btnDeleteClientes)
        Me.Controls.Add(Me.btnUpdateClientes)
        Me.Controls.Add(Me.dtvClientes)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        CType(Me.dtvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btnDeleteClientes As PictureBox
    Friend WithEvents btnUpdateClientes As PictureBox
    Friend WithEvents dtvClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipoDoc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelPart As TextBox
    Friend WithEvents txtFechaNac As DateTimePicker
    Friend WithEvents Domicilio As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents btnOpenLocalidad As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodClientes As TextBox
End Class
