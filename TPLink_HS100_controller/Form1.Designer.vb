<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblStep0 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnUpdatelist = New System.Windows.Forms.Button()
        Me.lblDevlist = New System.Windows.Forms.Label()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.DeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceStaus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listviewDevices = New System.Windows.Forms.ListView()
        Me.DeviceState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OnDelay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OffDelay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RightClickCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dbgMode = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.btnCreateSettings = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartInTray = New System.Windows.Forms.CheckBox()
        Me.lblQueuetitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.btnQueue = New System.Windows.Forms.Button()
        Me.sec = New System.Windows.Forms.NumericUpDown()
        Me.min = New System.Windows.Forms.NumericUpDown()
        Me.hrs = New System.Windows.Forms.NumericUpDown()
        Me.comboQueuestatus = New System.Windows.Forms.ComboBox()
        Me.comboDeviceQueueList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQueueafter = New System.Windows.Forms.Label()
        Me.lblQueueturn = New System.Windows.Forms.Label()
        Me.tick = New System.Windows.Forms.Timer(Me.components)
        Me.StartWithWin = New System.Windows.Forms.CheckBox()
        Me.RightClickCopy.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStep0
        '
        Me.lblStep0.AutoSize = True
        Me.lblStep0.Location = New System.Drawing.Point(12, 11)
        Me.lblStep0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStep0.Name = "lblStep0"
        Me.lblStep0.Size = New System.Drawing.Size(303, 32)
        Me.lblStep0.TabIndex = 0
        Me.lblStep0.Text = "Step 0) Log in to Kasa app with cloud account and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "add a device to your account"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 101)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(299, 22)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(13, 81)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(336, 81)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'btnUpdatelist
        '
        Me.btnUpdatelist.Location = New System.Drawing.Point(16, 134)
        Me.btnUpdatelist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdatelist.Name = "btnUpdatelist"
        Me.btnUpdatelist.Size = New System.Drawing.Size(567, 28)
        Me.btnUpdatelist.TabIndex = 6
        Me.btnUpdatelist.Text = "Update devices list"
        Me.btnUpdatelist.UseVisualStyleBackColor = True
        '
        'lblDevlist
        '
        Me.lblDevlist.AutoSize = True
        Me.lblDevlist.Location = New System.Drawing.Point(17, 199)
        Me.lblDevlist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDevlist.Name = "lblDevlist"
        Me.lblDevlist.Size = New System.Drawing.Size(76, 16)
        Me.lblDevlist.TabIndex = 8
        Me.lblDevlist.Text = "Devices list"
        '
        'btnOn
        '
        Me.btnOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOn.Location = New System.Drawing.Point(17, 501)
        Me.btnOn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(100, 28)
        Me.btnOn.TabIndex = 11
        Me.btnOn.Text = "Turn on"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOff.Location = New System.Drawing.Point(129, 501)
        Me.btnOff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(100, 28)
        Me.btnOff.TabIndex = 12
        Me.btnOff.Text = "Turn off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'DeviceName
        '
        Me.DeviceName.Text = "Name"
        Me.DeviceName.Width = 110
        '
        'DeviceStaus
        '
        Me.DeviceStaus.Text = "Status"
        Me.DeviceStaus.Width = 45
        '
        'DeviceID
        '
        Me.DeviceID.Text = "ID"
        Me.DeviceID.Width = 180
        '
        'DeviceURL
        '
        Me.DeviceURL.Text = "URL"
        Me.DeviceURL.Width = 50
        '
        'listviewDevices
        '
        Me.listviewDevices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listviewDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DeviceName, Me.DeviceStaus, Me.DeviceID, Me.DeviceURL, Me.DeviceState, Me.OnDelay, Me.OffDelay})
        Me.listviewDevices.ContextMenuStrip = Me.RightClickCopy
        Me.listviewDevices.FullRowSelect = True
        Me.listviewDevices.GridLines = True
        Me.listviewDevices.HideSelection = False
        Me.listviewDevices.Location = New System.Drawing.Point(17, 219)
        Me.listviewDevices.Margin = New System.Windows.Forms.Padding(4)
        Me.listviewDevices.MultiSelect = False
        Me.listviewDevices.Name = "listviewDevices"
        Me.listviewDevices.Size = New System.Drawing.Size(782, 244)
        Me.listviewDevices.TabIndex = 9
        Me.listviewDevices.UseCompatibleStateImageBehavior = False
        Me.listviewDevices.View = System.Windows.Forms.View.Details
        '
        'DeviceState
        '
        Me.DeviceState.Text = "On/Off"
        Me.DeviceState.Width = 50
        '
        'OnDelay
        '
        Me.OnDelay.Text = "OnDelay"
        Me.OnDelay.Width = 80
        '
        'OffDelay
        '
        Me.OffDelay.Text = "OffDelay"
        Me.OffDelay.Width = 80
        '
        'RightClickCopy
        '
        Me.RightClickCopy.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RightClickCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.RightClickCopy.Name = "RightClickCopy"
        Me.RightClickCopy.Size = New System.Drawing.Size(218, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 24)
        Me.ToolStripMenuItem1.Text = "Copy ID to clipboard"
        '
        'dbgMode
        '
        Me.dbgMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dbgMode.AutoSize = True
        Me.dbgMode.Location = New System.Drawing.Point(409, 651)
        Me.dbgMode.Margin = New System.Windows.Forms.Padding(4)
        Me.dbgMode.Name = "dbgMode"
        Me.dbgMode.Size = New System.Drawing.Size(108, 20)
        Me.dbgMode.TabIndex = 18
        Me.dbgMode.Text = "Debug mode"
        Me.dbgMode.UseVisualStyleBackColor = True
        Me.dbgMode.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(340, 101)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(241, 22)
        Me.txtPassword.TabIndex = 5
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(12, 59)
        Me.lblStep1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(152, 16)
        Me.lblStep1.TabIndex = 1
        Me.lblStep1.Text = "Step 1) Enter credentials"
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(16, 183)
        Me.lblStep2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(145, 16)
        Me.lblStep2.TabIndex = 7
        Me.lblStep2.Text = "Step 2) Select a device"
        '
        'lblStep3
        '
        Me.lblStep3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(19, 481)
        Me.lblStep3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(167, 16)
        Me.lblStep3.TabIndex = 10
        Me.lblStep3.Text = "Step 3) Send it a command"
        '
        'btnCreateSettings
        '
        Me.btnCreateSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateSettings.Location = New System.Drawing.Point(489, 501)
        Me.btnCreateSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateSettings.Name = "btnCreateSettings"
        Me.btnCreateSettings.Size = New System.Drawing.Size(312, 28)
        Me.btnCreateSettings.TabIndex = 13
        Me.btnCreateSettings.Text = "Edit automatic startup/shutdown settings"
        Me.btnCreateSettings.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WiFi Switch"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 52)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(689, 645)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 28)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit Program"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'StartInTray
        '
        Me.StartInTray.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartInTray.AutoSize = True
        Me.StartInTray.Location = New System.Drawing.Point(16, 652)
        Me.StartInTray.Margin = New System.Windows.Forms.Padding(4)
        Me.StartInTray.Name = "StartInTray"
        Me.StartInTray.Size = New System.Drawing.Size(140, 20)
        Me.StartInTray.TabIndex = 16
        Me.StartInTray.Text = "Start in system tray"
        Me.StartInTray.UseVisualStyleBackColor = True
        '
        'lblQueuetitle
        '
        Me.lblQueuetitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueuetitle.AutoSize = True
        Me.lblQueuetitle.Location = New System.Drawing.Point(19, 553)
        Me.lblQueuetitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQueuetitle.Name = "lblQueuetitle"
        Me.lblQueuetitle.Size = New System.Drawing.Size(117, 16)
        Me.lblQueuetitle.TabIndex = 14
        Me.lblQueuetitle.Text = "Queue commands"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnExtend)
        Me.Panel1.Controls.Add(Me.btnQueue)
        Me.Panel1.Controls.Add(Me.sec)
        Me.Panel1.Controls.Add(Me.min)
        Me.Panel1.Controls.Add(Me.hrs)
        Me.Panel1.Controls.Add(Me.comboQueuestatus)
        Me.Panel1.Controls.Add(Me.comboDeviceQueueList)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblQueueafter)
        Me.Panel1.Controls.Add(Me.lblQueueturn)
        Me.Panel1.Location = New System.Drawing.Point(16, 572)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 47)
        Me.Panel1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(721, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExtend
        '
        Me.btnExtend.Location = New System.Drawing.Point(645, 10)
        Me.btnExtend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(68, 28)
        Me.btnExtend.TabIndex = 11
        Me.btnExtend.Text = "Extend"
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'btnQueue
        '
        Me.btnQueue.Location = New System.Drawing.Point(573, 10)
        Me.btnQueue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQueue.Name = "btnQueue"
        Me.btnQueue.Size = New System.Drawing.Size(63, 28)
        Me.btnQueue.TabIndex = 10
        Me.btnQueue.Text = "Queue"
        Me.btnQueue.UseVisualStyleBackColor = True
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(499, 10)
        Me.sec.Margin = New System.Windows.Forms.Padding(4)
        Me.sec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(49, 22)
        Me.sec.TabIndex = 8
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(420, 10)
        Me.min.Margin = New System.Windows.Forms.Padding(4)
        Me.min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(49, 22)
        Me.min.TabIndex = 6
        '
        'hrs
        '
        Me.hrs.Location = New System.Drawing.Point(341, 10)
        Me.hrs.Margin = New System.Windows.Forms.Padding(4)
        Me.hrs.Name = "hrs"
        Me.hrs.Size = New System.Drawing.Size(49, 22)
        Me.hrs.TabIndex = 4
        '
        'comboQueuestatus
        '
        Me.comboQueuestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboQueuestatus.FormattingEnabled = True
        Me.comboQueuestatus.Items.AddRange(New Object() {"Off", "On"})
        Me.comboQueuestatus.Location = New System.Drawing.Point(219, 10)
        Me.comboQueuestatus.Margin = New System.Windows.Forms.Padding(4)
        Me.comboQueuestatus.Name = "comboQueuestatus"
        Me.comboQueuestatus.Size = New System.Drawing.Size(68, 24)
        Me.comboQueuestatus.TabIndex = 2
        '
        'comboDeviceQueueList
        '
        Me.comboDeviceQueueList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDeviceQueueList.FormattingEnabled = True
        Me.comboDeviceQueueList.Location = New System.Drawing.Point(49, 10)
        Me.comboDeviceQueueList.Margin = New System.Windows.Forms.Padding(4)
        Me.comboDeviceQueueList.Name = "comboDeviceQueueList"
        Me.comboDeviceQueueList.Size = New System.Drawing.Size(160, 24)
        Me.comboDeviceQueueList.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "after"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "H :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "S"
        '
        'lblQueueafter
        '
        Me.lblQueueafter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueueafter.AutoSize = True
        Me.lblQueueafter.Location = New System.Drawing.Point(468, 15)
        Me.lblQueueafter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQueueafter.Name = "lblQueueafter"
        Me.lblQueueafter.Size = New System.Drawing.Size(24, 16)
        Me.lblQueueafter.TabIndex = 7
        Me.lblQueueafter.Text = "M :"
        '
        'lblQueueturn
        '
        Me.lblQueueturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueueturn.AutoSize = True
        Me.lblQueueturn.Location = New System.Drawing.Point(4, 14)
        Me.lblQueueturn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQueueturn.Name = "lblQueueturn"
        Me.lblQueueturn.Size = New System.Drawing.Size(37, 16)
        Me.lblQueueturn.TabIndex = 0
        Me.lblQueueturn.Text = "Turn "
        '
        'tick
        '
        Me.tick.Interval = 1000
        '
        'StartWithWin
        '
        Me.StartWithWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartWithWin.AutoSize = True
        Me.StartWithWin.Location = New System.Drawing.Point(176, 651)
        Me.StartWithWin.Margin = New System.Windows.Forms.Padding(4)
        Me.StartWithWin.Name = "StartWithWin"
        Me.StartWithWin.Size = New System.Drawing.Size(135, 20)
        Me.StartWithWin.TabIndex = 17
        Me.StartWithWin.Text = "Start with windows"
        Me.StartWithWin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(817, 688)
        Me.Controls.Add(Me.StartWithWin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblQueuetitle)
        Me.Controls.Add(Me.StartInTray)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCreateSettings)
        Me.Controls.Add(Me.lblStep0)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.dbgMode)
        Me.Controls.Add(Me.listviewDevices)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.lblDevlist)
        Me.Controls.Add(Me.btnUpdatelist)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(835, 600)
        Me.Name = "Form1"
        Me.Text = "TP-Link HS100 WiFi Socket Controller"
        Me.RightClickCopy.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStep0 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnUpdatelist As System.Windows.Forms.Button
    Friend WithEvents lblDevlist As System.Windows.Forms.Label
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents DeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceStaus As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceID As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents listviewDevices As System.Windows.Forms.ListView
    Friend WithEvents dbgMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label
    Friend WithEvents btnCreateSettings As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviceState As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StartInTray As System.Windows.Forms.CheckBox
    Friend WithEvents RightClickCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnDelay As System.Windows.Forms.ColumnHeader
    Friend WithEvents OffDelay As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblQueuetitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblQueueturn As System.Windows.Forms.Label
    Friend WithEvents comboQueuestatus As System.Windows.Forms.ComboBox
    Friend WithEvents comboDeviceQueueList As System.Windows.Forms.ComboBox
    Friend WithEvents lblQueueafter As System.Windows.Forms.Label
    Friend WithEvents btnQueue As System.Windows.Forms.Button
    Friend WithEvents sec As System.Windows.Forms.NumericUpDown
    Friend WithEvents min As System.Windows.Forms.NumericUpDown
    Friend WithEvents hrs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents tick As System.Windows.Forms.Timer
    Friend WithEvents StartWithWin As System.Windows.Forms.CheckBox

End Class
