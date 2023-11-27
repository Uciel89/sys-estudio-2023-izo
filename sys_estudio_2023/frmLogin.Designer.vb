<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties25 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties26 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties27 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties28 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties29 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties30 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties31 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties32 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelError1 = New System.Windows.Forms.Label()
        Me.labelError2 = New System.Windows.Forms.Label()
        Me.btnAcceder = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtContraseña = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.txtUsuario = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(449, 145)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(40, 15)
        Me.BunifuLabel1.TabIndex = 4
        Me.BunifuLabel1.Text = "Usuario"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(449, 229)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(59, 15)
        Me.BunifuLabel2.TabIndex = 5
        Me.BunifuLabel2.Text = "Contraseña"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(449, 84)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(199, 45)
        Me.BunifuLabel3.TabIndex = 6
        Me.BunifuLabel3.Text = "Iniciar Sesión"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.labelError1)
        Me.Panel1.Controls.Add(Me.labelError2)
        Me.Panel1.Location = New System.Drawing.Point(448, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 277)
        Me.Panel1.TabIndex = 7
        '
        'labelError1
        '
        Me.labelError1.AutoSize = True
        Me.labelError1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelError1.Location = New System.Drawing.Point(3, 122)
        Me.labelError1.Name = "labelError1"
        Me.labelError1.Size = New System.Drawing.Size(128, 13)
        Me.labelError1.TabIndex = 9
        Me.labelError1.Text = "Este campo es requerido*"
        Me.labelError1.Visible = False
        '
        'labelError2
        '
        Me.labelError2.AutoSize = True
        Me.labelError2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelError2.Location = New System.Drawing.Point(3, 207)
        Me.labelError2.Name = "labelError2"
        Me.labelError2.Size = New System.Drawing.Size(128, 13)
        Me.labelError2.TabIndex = 8
        Me.labelError2.Text = "Este campo es requerido*"
        Me.labelError2.Visible = False
        '
        'btnAcceder
        '
        Me.btnAcceder.AllowAnimations = True
        Me.btnAcceder.AllowMouseEffects = True
        Me.btnAcceder.AllowToggling = False
        Me.btnAcceder.AnimationSpeed = 200
        Me.btnAcceder.AutoGenerateColors = False
        Me.btnAcceder.AutoRoundBorders = True
        Me.btnAcceder.AutoSizeLeftIcon = True
        Me.btnAcceder.AutoSizeRightIcon = True
        Me.btnAcceder.BackColor = System.Drawing.Color.Transparent
        Me.btnAcceder.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnAcceder.BackgroundImage = CType(resources.GetObject("btnAcceder.BackgroundImage"), System.Drawing.Image)
        Me.btnAcceder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAcceder.ButtonText = "ACCEDER"
        Me.btnAcceder.ButtonTextMarginLeft = 0
        Me.btnAcceder.ColorContrastOnClick = 45
        Me.btnAcceder.ColorContrastOnHover = 45
        Me.btnAcceder.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnAcceder.CustomizableEdges = BorderEdges4
        Me.btnAcceder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAcceder.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAcceder.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAcceder.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAcceder.Enabled = False
        Me.btnAcceder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnAcceder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceder.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnAcceder.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnAcceder.IconMarginLeft = 11
        Me.btnAcceder.IconPadding = 10
        Me.btnAcceder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcceder.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnAcceder.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnAcceder.IconSize = 25
        Me.btnAcceder.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAcceder.IdleBorderRadius = 37
        Me.btnAcceder.IdleBorderThickness = 1
        Me.btnAcceder.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnAcceder.IdleIconLeftImage = Nothing
        Me.btnAcceder.IdleIconRightImage = Nothing
        Me.btnAcceder.IndicateFocus = False
        Me.btnAcceder.Location = New System.Drawing.Point(449, 322)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAcceder.OnDisabledState.BorderRadius = 1
        Me.btnAcceder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAcceder.OnDisabledState.BorderThickness = 1
        Me.btnAcceder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAcceder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAcceder.OnDisabledState.IconLeftImage = Nothing
        Me.btnAcceder.OnDisabledState.IconRightImage = Nothing
        Me.btnAcceder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAcceder.onHoverState.BorderRadius = 1
        Me.btnAcceder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAcceder.onHoverState.BorderThickness = 1
        Me.btnAcceder.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAcceder.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.onHoverState.IconLeftImage = Nothing
        Me.btnAcceder.onHoverState.IconRightImage = Nothing
        Me.btnAcceder.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAcceder.OnIdleState.BorderRadius = 1
        Me.btnAcceder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAcceder.OnIdleState.BorderThickness = 1
        Me.btnAcceder.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnAcceder.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.OnIdleState.IconLeftImage = Nothing
        Me.btnAcceder.OnIdleState.IconRightImage = Nothing
        Me.btnAcceder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnAcceder.OnPressedState.BorderRadius = 1
        Me.btnAcceder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAcceder.OnPressedState.BorderThickness = 1
        Me.btnAcceder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnAcceder.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.OnPressedState.IconLeftImage = Nothing
        Me.btnAcceder.OnPressedState.IconRightImage = Nothing
        Me.btnAcceder.Size = New System.Drawing.Size(260, 39)
        Me.btnAcceder.TabIndex = 3
        Me.btnAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAcceder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAcceder.TextMarginLeft = 0
        Me.btnAcceder.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnAcceder.UseDefaultRadiusAndThickness = True
        '
        'txtContraseña
        '
        Me.txtContraseña.AcceptsReturn = False
        Me.txtContraseña.AcceptsTab = False
        Me.txtContraseña.AnimationSpeed = 200
        Me.txtContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.BackgroundImage = CType(resources.GetObject("txtContraseña.BackgroundImage"), System.Drawing.Image)
        Me.txtContraseña.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtContraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtContraseña.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtContraseña.BorderRadius = 1
        Me.txtContraseña.BorderThickness = 1
        Me.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtContraseña.DefaultText = ""
        Me.txtContraseña.FillColor = System.Drawing.Color.White
        Me.txtContraseña.HideSelection = True
        Me.txtContraseña.IconLeft = Global.sys_estudio_2023.My.Resources.Resources.icon_password
        Me.txtContraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.IconPadding = 10
        Me.txtContraseña.IconRight = Nothing
        Me.txtContraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.Lines = New String(-1) {}
        Me.txtContraseña.Location = New System.Drawing.Point(449, 251)
        Me.txtContraseña.MaxLength = 32767
        Me.txtContraseña.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtContraseña.Modified = False
        Me.txtContraseña.Multiline = False
        Me.txtContraseña.Name = "txtContraseña"
        StateProperties25.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties25.FillColor = System.Drawing.Color.Empty
        StateProperties25.ForeColor = System.Drawing.Color.Empty
        StateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtContraseña.OnActiveState = StateProperties25
        StateProperties26.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties26.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtContraseña.OnDisabledState = StateProperties26
        StateProperties27.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties27.FillColor = System.Drawing.Color.Empty
        StateProperties27.ForeColor = System.Drawing.Color.Empty
        StateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtContraseña.OnHoverState = StateProperties27
        StateProperties28.BorderColor = System.Drawing.Color.Silver
        StateProperties28.FillColor = System.Drawing.Color.White
        StateProperties28.ForeColor = System.Drawing.Color.Empty
        StateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtContraseña.OnIdleState = StateProperties28
        Me.txtContraseña.Padding = New System.Windows.Forms.Padding(3)
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtContraseña.PlaceholderText = ""
        Me.txtContraseña.ReadOnly = False
        Me.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.SelectionLength = 0
        Me.txtContraseña.SelectionStart = 0
        Me.txtContraseña.ShortcutsEnabled = True
        Me.txtContraseña.Size = New System.Drawing.Size(260, 37)
        Me.txtContraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtContraseña.TextMarginBottom = 0
        Me.txtContraseña.TextMarginLeft = 3
        Me.txtContraseña.TextMarginTop = 0
        Me.txtContraseña.TextPlaceholder = ""
        Me.txtContraseña.UseSystemPasswordChar = False
        Me.txtContraseña.WordWrap = True
        '
        'txtUsuario
        '
        Me.txtUsuario.AcceptsReturn = False
        Me.txtUsuario.AcceptsTab = False
        Me.txtUsuario.AnimationSpeed = 200
        Me.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtUsuario.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtUsuario.BorderRadius = 1
        Me.txtUsuario.BorderThickness = 1
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUsuario.DefaultText = ""
        Me.txtUsuario.FillColor = System.Drawing.Color.White
        Me.txtUsuario.HideSelection = True
        Me.txtUsuario.IconLeft = Global.sys_estudio_2023.My.Resources.Resources.icon_user
        Me.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.IconPadding = 10
        Me.txtUsuario.IconRight = Nothing
        Me.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(449, 166)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtUsuario.Modified = False
        Me.txtUsuario.Multiline = False
        Me.txtUsuario.Name = "txtUsuario"
        StateProperties29.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties29.FillColor = System.Drawing.Color.Empty
        StateProperties29.ForeColor = System.Drawing.Color.Empty
        StateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsuario.OnActiveState = StateProperties29
        StateProperties30.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties30.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtUsuario.OnDisabledState = StateProperties30
        StateProperties31.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties31.FillColor = System.Drawing.Color.Empty
        StateProperties31.ForeColor = System.Drawing.Color.Empty
        StateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsuario.OnHoverState = StateProperties31
        StateProperties32.BorderColor = System.Drawing.Color.Silver
        StateProperties32.FillColor = System.Drawing.Color.White
        StateProperties32.ForeColor = System.Drawing.Color.Empty
        StateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsuario.OnIdleState = StateProperties32
        Me.txtUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsuario.PlaceholderText = ""
        Me.txtUsuario.ReadOnly = False
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(260, 37)
        Me.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsuario.TextMarginBottom = 0
        Me.txtUsuario.TextMarginLeft = 3
        Me.txtUsuario.TextMarginTop = 0
        Me.txtUsuario.TextPlaceholder = ""
        Me.txtUsuario.UseSystemPasswordChar = False
        Me.txtUsuario.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sys_estudio_2023.My.Resources.Resources.logo_estudio_2023
        Me.PictureBox1.Location = New System.Drawing.Point(91, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(138, 207)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(39, 13)
        Me.lblContraseña.TabIndex = 10
        Me.lblContraseña.Text = "Label1"
        Me.lblContraseña.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 450)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsuario As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents txtContraseña As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents btnAcceder As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelError1 As Label
    Friend WithEvents labelError2 As Label
    Friend WithEvents lblContraseña As Label
End Class
