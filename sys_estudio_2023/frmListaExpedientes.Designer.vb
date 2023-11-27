<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaExpedientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaExpedientes))
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvExpedientes = New System.Windows.Forms.DataGridView()
        Me.btnImprimirExpediente = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnBuscarExpediente = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnAgregarExpediente = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroExpediente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE EXPEDIENTES"
        '
        'dgvExpedientes
        '
        Me.dgvExpedientes.AllowUserToAddRows = False
        Me.dgvExpedientes.AllowUserToDeleteRows = False
        Me.dgvExpedientes.AllowUserToResizeColumns = False
        Me.dgvExpedientes.AllowUserToResizeRows = False
        Me.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpedientes.Location = New System.Drawing.Point(17, 144)
        Me.dgvExpedientes.Name = "dgvExpedientes"
        Me.dgvExpedientes.ReadOnly = True
        Me.dgvExpedientes.Size = New System.Drawing.Size(816, 217)
        Me.dgvExpedientes.TabIndex = 6
        '
        'btnImprimirExpediente
        '
        Me.btnImprimirExpediente.AllowAnimations = True
        Me.btnImprimirExpediente.AllowMouseEffects = True
        Me.btnImprimirExpediente.AllowToggling = False
        Me.btnImprimirExpediente.AnimationSpeed = 200
        Me.btnImprimirExpediente.AutoGenerateColors = False
        Me.btnImprimirExpediente.AutoRoundBorders = False
        Me.btnImprimirExpediente.AutoSizeLeftIcon = True
        Me.btnImprimirExpediente.AutoSizeRightIcon = True
        Me.btnImprimirExpediente.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirExpediente.BackColor1 = System.Drawing.Color.DimGray
        Me.btnImprimirExpediente.BackgroundImage = CType(resources.GetObject("btnImprimirExpediente.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimirExpediente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnImprimirExpediente.ButtonText = ""
        Me.btnImprimirExpediente.ButtonTextMarginLeft = 0
        Me.btnImprimirExpediente.ColorContrastOnClick = 45
        Me.btnImprimirExpediente.ColorContrastOnHover = 45
        Me.btnImprimirExpediente.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnImprimirExpediente.CustomizableEdges = BorderEdges4
        Me.btnImprimirExpediente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImprimirExpediente.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnImprimirExpediente.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnImprimirExpediente.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnImprimirExpediente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnImprimirExpediente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnImprimirExpediente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimirExpediente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirExpediente.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnImprimirExpediente.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnImprimirExpediente.IconMarginLeft = 11
        Me.btnImprimirExpediente.IconPadding = 10
        Me.btnImprimirExpediente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimirExpediente.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnImprimirExpediente.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnImprimirExpediente.IconSize = 25
        Me.btnImprimirExpediente.IdleBorderColor = System.Drawing.SystemColors.Control
        Me.btnImprimirExpediente.IdleBorderRadius = 1
        Me.btnImprimirExpediente.IdleBorderThickness = 1
        Me.btnImprimirExpediente.IdleFillColor = System.Drawing.Color.DimGray
        Me.btnImprimirExpediente.IdleIconLeftImage = Global.sys_estudio_2023.My.Resources.Resources.icon_imprimir
        Me.btnImprimirExpediente.IdleIconRightImage = Nothing
        Me.btnImprimirExpediente.IndicateFocus = False
        Me.btnImprimirExpediente.Location = New System.Drawing.Point(17, 367)
        Me.btnImprimirExpediente.Name = "btnImprimirExpediente"
        Me.btnImprimirExpediente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnImprimirExpediente.OnDisabledState.BorderRadius = 1
        Me.btnImprimirExpediente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnImprimirExpediente.OnDisabledState.BorderThickness = 1
        Me.btnImprimirExpediente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnImprimirExpediente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnImprimirExpediente.OnDisabledState.IconLeftImage = Nothing
        Me.btnImprimirExpediente.OnDisabledState.IconRightImage = Nothing
        Me.btnImprimirExpediente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimirExpediente.onHoverState.BorderRadius = 1
        Me.btnImprimirExpediente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnImprimirExpediente.onHoverState.BorderThickness = 1
        Me.btnImprimirExpediente.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimirExpediente.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnImprimirExpediente.onHoverState.IconLeftImage = Nothing
        Me.btnImprimirExpediente.onHoverState.IconRightImage = Nothing
        Me.btnImprimirExpediente.OnIdleState.BorderColor = System.Drawing.SystemColors.Control
        Me.btnImprimirExpediente.OnIdleState.BorderRadius = 1
        Me.btnImprimirExpediente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnImprimirExpediente.OnIdleState.BorderThickness = 1
        Me.btnImprimirExpediente.OnIdleState.FillColor = System.Drawing.Color.DimGray
        Me.btnImprimirExpediente.OnIdleState.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimirExpediente.OnIdleState.IconLeftImage = Global.sys_estudio_2023.My.Resources.Resources.icon_imprimir
        Me.btnImprimirExpediente.OnIdleState.IconRightImage = Nothing
        Me.btnImprimirExpediente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnImprimirExpediente.OnPressedState.BorderRadius = 1
        Me.btnImprimirExpediente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnImprimirExpediente.OnPressedState.BorderThickness = 1
        Me.btnImprimirExpediente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnImprimirExpediente.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnImprimirExpediente.OnPressedState.IconLeftImage = Nothing
        Me.btnImprimirExpediente.OnPressedState.IconRightImage = Nothing
        Me.btnImprimirExpediente.Size = New System.Drawing.Size(47, 42)
        Me.btnImprimirExpediente.TabIndex = 7
        Me.btnImprimirExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImprimirExpediente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnImprimirExpediente.TextMarginLeft = 0
        Me.btnImprimirExpediente.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnImprimirExpediente.UseDefaultRadiusAndThickness = True
        '
        'btnBuscarExpediente
        '
        Me.btnBuscarExpediente.AllowAnimations = True
        Me.btnBuscarExpediente.AllowMouseEffects = True
        Me.btnBuscarExpediente.AllowToggling = False
        Me.btnBuscarExpediente.AnimationSpeed = 200
        Me.btnBuscarExpediente.AutoGenerateColors = False
        Me.btnBuscarExpediente.AutoRoundBorders = False
        Me.btnBuscarExpediente.AutoSizeLeftIcon = True
        Me.btnBuscarExpediente.AutoSizeRightIcon = True
        Me.btnBuscarExpediente.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarExpediente.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnBuscarExpediente.BackgroundImage = CType(resources.GetObject("btnBuscarExpediente.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarExpediente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBuscarExpediente.ButtonText = "BUSCAR"
        Me.btnBuscarExpediente.ButtonTextMarginLeft = 0
        Me.btnBuscarExpediente.ColorContrastOnClick = 45
        Me.btnBuscarExpediente.ColorContrastOnHover = 45
        Me.btnBuscarExpediente.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.btnBuscarExpediente.CustomizableEdges = BorderEdges5
        Me.btnBuscarExpediente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscarExpediente.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBuscarExpediente.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBuscarExpediente.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBuscarExpediente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnBuscarExpediente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBuscarExpediente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarExpediente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarExpediente.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnBuscarExpediente.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnBuscarExpediente.IconMarginLeft = 11
        Me.btnBuscarExpediente.IconPadding = 10
        Me.btnBuscarExpediente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarExpediente.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnBuscarExpediente.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnBuscarExpediente.IconSize = 25
        Me.btnBuscarExpediente.IdleBorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarExpediente.IdleBorderRadius = 1
        Me.btnBuscarExpediente.IdleBorderThickness = 1
        Me.btnBuscarExpediente.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscarExpediente.IdleIconLeftImage = Nothing
        Me.btnBuscarExpediente.IdleIconRightImage = Nothing
        Me.btnBuscarExpediente.IndicateFocus = False
        Me.btnBuscarExpediente.Location = New System.Drawing.Point(640, 85)
        Me.btnBuscarExpediente.Name = "btnBuscarExpediente"
        Me.btnBuscarExpediente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBuscarExpediente.OnDisabledState.BorderRadius = 1
        Me.btnBuscarExpediente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBuscarExpediente.OnDisabledState.BorderThickness = 1
        Me.btnBuscarExpediente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBuscarExpediente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBuscarExpediente.OnDisabledState.IconLeftImage = Nothing
        Me.btnBuscarExpediente.OnDisabledState.IconRightImage = Nothing
        Me.btnBuscarExpediente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarExpediente.onHoverState.BorderRadius = 1
        Me.btnBuscarExpediente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBuscarExpediente.onHoverState.BorderThickness = 1
        Me.btnBuscarExpediente.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarExpediente.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnBuscarExpediente.onHoverState.IconLeftImage = Nothing
        Me.btnBuscarExpediente.onHoverState.IconRightImage = Nothing
        Me.btnBuscarExpediente.OnIdleState.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarExpediente.OnIdleState.BorderRadius = 1
        Me.btnBuscarExpediente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBuscarExpediente.OnIdleState.BorderThickness = 1
        Me.btnBuscarExpediente.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscarExpediente.OnIdleState.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarExpediente.OnIdleState.IconLeftImage = Nothing
        Me.btnBuscarExpediente.OnIdleState.IconRightImage = Nothing
        Me.btnBuscarExpediente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnBuscarExpediente.OnPressedState.BorderRadius = 1
        Me.btnBuscarExpediente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBuscarExpediente.OnPressedState.BorderThickness = 1
        Me.btnBuscarExpediente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnBuscarExpediente.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnBuscarExpediente.OnPressedState.IconLeftImage = Nothing
        Me.btnBuscarExpediente.OnPressedState.IconRightImage = Nothing
        Me.btnBuscarExpediente.Size = New System.Drawing.Size(193, 42)
        Me.btnBuscarExpediente.TabIndex = 5
        Me.btnBuscarExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscarExpediente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBuscarExpediente.TextMarginLeft = 0
        Me.btnBuscarExpediente.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnBuscarExpediente.UseDefaultRadiusAndThickness = True
        '
        'btnAgregarExpediente
        '
        Me.btnAgregarExpediente.AllowAnimations = True
        Me.btnAgregarExpediente.AllowMouseEffects = True
        Me.btnAgregarExpediente.AllowToggling = False
        Me.btnAgregarExpediente.AnimationSpeed = 200
        Me.btnAgregarExpediente.AutoGenerateColors = False
        Me.btnAgregarExpediente.AutoRoundBorders = False
        Me.btnAgregarExpediente.AutoSizeLeftIcon = True
        Me.btnAgregarExpediente.AutoSizeRightIcon = True
        Me.btnAgregarExpediente.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarExpediente.BackColor1 = System.Drawing.Color.Green
        Me.btnAgregarExpediente.BackgroundImage = CType(resources.GetObject("btnAgregarExpediente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarExpediente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAgregarExpediente.ButtonText = "AGREGAR"
        Me.btnAgregarExpediente.ButtonTextMarginLeft = 0
        Me.btnAgregarExpediente.ColorContrastOnClick = 45
        Me.btnAgregarExpediente.ColorContrastOnHover = 45
        Me.btnAgregarExpediente.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.btnAgregarExpediente.CustomizableEdges = BorderEdges6
        Me.btnAgregarExpediente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarExpediente.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAgregarExpediente.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAgregarExpediente.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAgregarExpediente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnAgregarExpediente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarExpediente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarExpediente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarExpediente.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregarExpediente.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnAgregarExpediente.IconMarginLeft = 11
        Me.btnAgregarExpediente.IconPadding = 10
        Me.btnAgregarExpediente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarExpediente.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregarExpediente.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnAgregarExpediente.IconSize = 25
        Me.btnAgregarExpediente.IdleBorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregarExpediente.IdleBorderRadius = 1
        Me.btnAgregarExpediente.IdleBorderThickness = 1
        Me.btnAgregarExpediente.IdleFillColor = System.Drawing.Color.Green
        Me.btnAgregarExpediente.IdleIconLeftImage = Nothing
        Me.btnAgregarExpediente.IdleIconRightImage = Nothing
        Me.btnAgregarExpediente.IndicateFocus = False
        Me.btnAgregarExpediente.Location = New System.Drawing.Point(640, 37)
        Me.btnAgregarExpediente.Name = "btnAgregarExpediente"
        Me.btnAgregarExpediente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAgregarExpediente.OnDisabledState.BorderRadius = 1
        Me.btnAgregarExpediente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAgregarExpediente.OnDisabledState.BorderThickness = 1
        Me.btnAgregarExpediente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAgregarExpediente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAgregarExpediente.OnDisabledState.IconLeftImage = Nothing
        Me.btnAgregarExpediente.OnDisabledState.IconRightImage = Nothing
        Me.btnAgregarExpediente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarExpediente.onHoverState.BorderRadius = 1
        Me.btnAgregarExpediente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAgregarExpediente.onHoverState.BorderThickness = 1
        Me.btnAgregarExpediente.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarExpediente.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnAgregarExpediente.onHoverState.IconLeftImage = Nothing
        Me.btnAgregarExpediente.onHoverState.IconRightImage = Nothing
        Me.btnAgregarExpediente.OnIdleState.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregarExpediente.OnIdleState.BorderRadius = 1
        Me.btnAgregarExpediente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAgregarExpediente.OnIdleState.BorderThickness = 1
        Me.btnAgregarExpediente.OnIdleState.FillColor = System.Drawing.Color.Green
        Me.btnAgregarExpediente.OnIdleState.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarExpediente.OnIdleState.IconLeftImage = Nothing
        Me.btnAgregarExpediente.OnIdleState.IconRightImage = Nothing
        Me.btnAgregarExpediente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnAgregarExpediente.OnPressedState.BorderRadius = 1
        Me.btnAgregarExpediente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAgregarExpediente.OnPressedState.BorderThickness = 1
        Me.btnAgregarExpediente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnAgregarExpediente.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnAgregarExpediente.OnPressedState.IconLeftImage = Nothing
        Me.btnAgregarExpediente.OnPressedState.IconRightImage = Nothing
        Me.btnAgregarExpediente.Size = New System.Drawing.Size(193, 42)
        Me.btnAgregarExpediente.TabIndex = 4
        Me.btnAgregarExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregarExpediente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAgregarExpediente.TextMarginLeft = 0
        Me.btnAgregarExpediente.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnAgregarExpediente.UseDefaultRadiusAndThickness = True
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(306, 103)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(153, 20)
        Me.txtFechaDesde.TabIndex = 19
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(470, 103)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(154, 20)
        Me.txtFechaHasta.TabIndex = 20
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(158, 103)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(110, 20)
        Me.txtNombreCliente.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Fecha desde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(466, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fecha hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nro Expediente"
        '
        'txtNroExpediente
        '
        Me.txtNroExpediente.Location = New System.Drawing.Point(17, 103)
        Me.txtNroExpediente.Name = "txtNroExpediente"
        Me.txtNroExpediente.Size = New System.Drawing.Size(112, 20)
        Me.txtNroExpediente.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "|"
        '
        'frmListaExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 420)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNroExpediente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.btnImprimirExpediente)
        Me.Controls.Add(Me.dgvExpedientes)
        Me.Controls.Add(Me.btnBuscarExpediente)
        Me.Controls.Add(Me.btnAgregarExpediente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListaExpedientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Expediente"
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Friend WithEvents btnAgregarExpediente As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnBuscarExpediente As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents dgvExpedientes As DataGridView
    Friend WithEvents btnImprimirExpediente As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtFechaDesde As DateTimePicker
    Friend WithEvents txtFechaHasta As DateTimePicker
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNroExpediente As TextBox
    Friend WithEvents Label7 As Label
End Class
