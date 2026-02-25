<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlSidebar = New Panel()
        btnImpostazioni = New Button()
        btnPermessi = New Button()
        btnTimbrature = New Button()
        btnDashboard = New Button()
        pnlTop = New Panel()
        btnToggle = New Button()
        pnlShadow = New Panel()
        pnlContent = New Panel()
        pnlTitleBar = New Panel()
        pnlUserInfo = New Panel()
        lblUserName = New Label()
        lblUserIcon = New Label()
        pnlSidebar.SuspendLayout()
        pnlTop.SuspendLayout()
        pnlTitleBar.SuspendLayout()
        pnlUserInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlSidebar.Controls.Add(btnImpostazioni)
        pnlSidebar.Controls.Add(btnPermessi)
        pnlSidebar.Controls.Add(btnTimbrature)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(pnlTop)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 840)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnImpostazioni
        ' 
        btnImpostazioni.BackColor = Color.Transparent
        btnImpostazioni.Cursor = Cursors.Hand
        btnImpostazioni.Dock = DockStyle.Top
        btnImpostazioni.FlatAppearance.BorderSize = 0
        btnImpostazioni.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnImpostazioni.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnImpostazioni.FlatStyle = FlatStyle.Flat
        btnImpostazioni.Font = New Font("Segoe UI Variable Display", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnImpostazioni.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnImpostazioni.ImageAlign = ContentAlignment.MiddleRight
        btnImpostazioni.Location = New Point(0, 206)
        btnImpostazioni.Name = "btnImpostazioni"
        btnImpostazioni.Padding = New Padding(12, 0, 0, 0)
        btnImpostazioni.Size = New Size(220, 50)
        btnImpostazioni.TabIndex = 4
        btnImpostazioni.Text = "⚙   Impostazioni"
        btnImpostazioni.TextAlign = ContentAlignment.MiddleLeft
        btnImpostazioni.UseVisualStyleBackColor = False
        ' 
        ' btnPermessi
        ' 
        btnPermessi.BackColor = Color.Transparent
        btnPermessi.Cursor = Cursors.Hand
        btnPermessi.Dock = DockStyle.Top
        btnPermessi.FlatAppearance.BorderSize = 0
        btnPermessi.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnPermessi.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnPermessi.FlatStyle = FlatStyle.Flat
        btnPermessi.Font = New Font("Segoe UI Variable Display", 12.0F)
        btnPermessi.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnPermessi.ImageAlign = ContentAlignment.MiddleRight
        btnPermessi.Location = New Point(0, 156)
        btnPermessi.Name = "btnPermessi"
        btnPermessi.Padding = New Padding(12, 0, 0, 0)
        btnPermessi.Size = New Size(220, 50)
        btnPermessi.TabIndex = 3
        btnPermessi.Text = "🗓   Permessi"
        btnPermessi.TextAlign = ContentAlignment.MiddleLeft
        btnPermessi.UseVisualStyleBackColor = False
        ' 
        ' btnTimbrature
        ' 
        btnTimbrature.BackColor = Color.Transparent
        btnTimbrature.Cursor = Cursors.Hand
        btnTimbrature.Dock = DockStyle.Top
        btnTimbrature.FlatAppearance.BorderSize = 0
        btnTimbrature.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnTimbrature.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnTimbrature.FlatStyle = FlatStyle.Flat
        btnTimbrature.Font = New Font("Segoe UI Variable Display", 12.0F)
        btnTimbrature.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnTimbrature.ImageAlign = ContentAlignment.MiddleRight
        btnTimbrature.Location = New Point(0, 106)
        btnTimbrature.Name = "btnTimbrature"
        btnTimbrature.Padding = New Padding(12, 0, 0, 0)
        btnTimbrature.Size = New Size(220, 50)
        btnTimbrature.TabIndex = 2
        btnTimbrature.Text = "⏱   Timbrature"
        btnTimbrature.TextAlign = ContentAlignment.MiddleLeft
        btnTimbrature.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI Variable Display", 12.0F)
        btnDashboard.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnDashboard.ImageAlign = ContentAlignment.MiddleRight
        btnDashboard.Location = New Point(0, 56)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(12, 0, 0, 0)
        btnDashboard.Size = New Size(220, 50)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "📊   Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.Transparent
        pnlTop.Controls.Add(btnToggle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(220, 56)
        pnlTop.TabIndex = 0
        ' 
        ' btnToggle
        ' 
        btnToggle.Cursor = Cursors.Hand
        btnToggle.Dock = DockStyle.Left
        btnToggle.FlatAppearance.BorderSize = 0
        btnToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(65), CByte(72), CByte(86))
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Font = New Font("Segoe UI Variable Display", 12.0F)
        btnToggle.ForeColor = Color.White
        btnToggle.Location = New Point(0, 0)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(64, 56)
        btnToggle.TabIndex = 0
        btnToggle.Text = "☰"
        btnToggle.UseVisualStyleBackColor = True
        ' 
        ' pnlShadow
        ' 
        pnlShadow.Dock = DockStyle.Left
        pnlShadow.Location = New Point(220, 0)
        pnlShadow.Name = "pnlShadow"
        pnlShadow.Size = New Size(12, 840)
        pnlShadow.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.Transparent
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(232, 40)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1018, 800)
        pnlContent.TabIndex = 2
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.Transparent
        pnlTitleBar.Controls.Add(pnlUserInfo)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Location = New Point(232, 0)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1018, 40)
        pnlTitleBar.TabIndex = 3
        ' 
        ' pnlUserInfo
        ' 
        pnlUserInfo.Controls.Add(lblUserName)
        pnlUserInfo.Controls.Add(lblUserIcon)
        pnlUserInfo.Dock = DockStyle.Left
        pnlUserInfo.Location = New Point(0, 0)
        pnlUserInfo.Name = "pnlUserInfo"
        pnlUserInfo.Size = New Size(200, 40)
        pnlUserInfo.TabIndex = 1
        ' 
        ' lblUserName
        ' 
        lblUserName.Dock = DockStyle.Fill
        lblUserName.FlatStyle = FlatStyle.Flat
        lblUserName.Font = New Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserName.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblUserName.Location = New Point(40, 0)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(160, 40)
        lblUserName.TabIndex = 1
        lblUserName.Text = "Riccardo Bertoletti"
        lblUserName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUserIcon
        ' 
        lblUserIcon.Dock = DockStyle.Left
        lblUserIcon.FlatStyle = FlatStyle.Flat
        lblUserIcon.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserIcon.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblUserIcon.Location = New Point(0, 0)
        lblUserIcon.Name = "lblUserIcon"
        lblUserIcon.Size = New Size(40, 40)
        lblUserIcon.TabIndex = 0
        lblUserIcon.Text = "👤"
        lblUserIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(51), CByte(60), CByte(77))
        ClientSize = New Size(1250, 840)
        Controls.Add(pnlContent)
        Controls.Add(pnlTitleBar)
        Controls.Add(pnlShadow)
        Controls.Add(pnlSidebar)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormMain"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Personal HR"
        pnlSidebar.ResumeLayout(False)
        pnlTop.ResumeLayout(False)
        pnlTitleBar.ResumeLayout(False)
        pnlUserInfo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnToggle As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTimbrature As Button
    Friend WithEvents btnPermessi As Button
    Friend WithEvents btnImpostazioni As Button
    Friend WithEvents pnlShadow As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents lblUserIcon As Label
    Friend WithEvents lblUserName As Label

End Class
