<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDashboard
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlCardSaldoMensile = New Panel()
        lblSaldoMensileValue = New Label()
        lblSaldoMensileSubtitle = New Label()
        lblSaldoMensileTitle = New Label()
        pnlCardTimbrature = New Panel()
        lblTimbratureValue = New Label()
        lblTimbratureSubtitle = New Label()
        lblTimbratureTitle = New Label()
        pnlCardStraordinari = New Panel()
        lblStraordinariValue = New Label()
        lblStraordinariSubtitle = New Label()
        lblStraordinariTitle = New Label()
        pnlCardsContainer = New FlowLayoutPanel()
        pnlCardSaldoMensile.SuspendLayout()
        pnlCardTimbrature.SuspendLayout()
        pnlCardStraordinari.SuspendLayout()
        pnlCardsContainer.SuspendLayout()
        SuspendLayout()
        '
        ' lblTitle
        '
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblTitle.Location = New Point(912, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(79, 21)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Dashboard"
        '
        ' pnlCardSaldoMensile
        '
        pnlCardSaldoMensile.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlCardSaldoMensile.Controls.Add(lblSaldoMensileValue)
        pnlCardSaldoMensile.Controls.Add(lblSaldoMensileSubtitle)
        pnlCardSaldoMensile.Controls.Add(lblSaldoMensileTitle)
        pnlCardSaldoMensile.Margin = New Padding(10)
        pnlCardSaldoMensile.Name = "pnlCardSaldoMensile"
        pnlCardSaldoMensile.Padding = New Padding(16)
        pnlCardSaldoMensile.Size = New Size(300, 150)
        pnlCardSaldoMensile.TabIndex = 1
        '
        ' lblSaldoMensileValue
        '
        lblSaldoMensileValue.Dock = DockStyle.Top
        lblSaldoMensileValue.Font = New Font("Segoe UI Variable Text", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldoMensileValue.ForeColor = Color.White
        lblSaldoMensileValue.Location = New Point(16, 62)
        lblSaldoMensileValue.Name = "lblSaldoMensileValue"
        lblSaldoMensileValue.Size = New Size(268, 45)
        lblSaldoMensileValue.TabIndex = 2
        lblSaldoMensileValue.Text = "+07h 35m"
        lblSaldoMensileValue.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblSaldoMensileSubtitle
        '
        lblSaldoMensileSubtitle.Dock = DockStyle.Top
        lblSaldoMensileSubtitle.Font = New Font("Segoe UI Variable Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSaldoMensileSubtitle.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblSaldoMensileSubtitle.Location = New Point(16, 32)
        lblSaldoMensileSubtitle.Name = "lblSaldoMensileSubtitle"
        lblSaldoMensileSubtitle.Size = New Size(268, 30)
        lblSaldoMensileSubtitle.TabIndex = 1
        lblSaldoMensileSubtitle.Text = "Ore maturate - ore lavorative"
        lblSaldoMensileSubtitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblSaldoMensileTitle
        '
        lblSaldoMensileTitle.Dock = DockStyle.Top
        lblSaldoMensileTitle.Font = New Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldoMensileTitle.ForeColor = Color.White
        lblSaldoMensileTitle.Location = New Point(16, 16)
        lblSaldoMensileTitle.Name = "lblSaldoMensileTitle"
        lblSaldoMensileTitle.Size = New Size(268, 16)
        lblSaldoMensileTitle.TabIndex = 0
        lblSaldoMensileTitle.Text = "⏳ Saldo ore/minuti mensile"
        lblSaldoMensileTitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' pnlCardTimbrature
        '
        pnlCardTimbrature.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlCardTimbrature.Controls.Add(lblTimbratureValue)
        pnlCardTimbrature.Controls.Add(lblTimbratureSubtitle)
        pnlCardTimbrature.Controls.Add(lblTimbratureTitle)
        pnlCardTimbrature.Margin = New Padding(10)
        pnlCardTimbrature.Name = "pnlCardTimbrature"
        pnlCardTimbrature.Padding = New Padding(16)
        pnlCardTimbrature.Size = New Size(300, 150)
        pnlCardTimbrature.TabIndex = 2
        '
        ' lblTimbratureValue
        '
        lblTimbratureValue.Dock = DockStyle.Top
        lblTimbratureValue.Font = New Font("Segoe UI Variable Text", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimbratureValue.ForeColor = Color.White
        lblTimbratureValue.Location = New Point(16, 62)
        lblTimbratureValue.Name = "lblTimbratureValue"
        lblTimbratureValue.Size = New Size(268, 45)
        lblTimbratureValue.TabIndex = 2
        lblTimbratureValue.Text = "18 / 22"
        lblTimbratureValue.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblTimbratureSubtitle
        '
        lblTimbratureSubtitle.Dock = DockStyle.Top
        lblTimbratureSubtitle.Font = New Font("Segoe UI Variable Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimbratureSubtitle.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblTimbratureSubtitle.Location = New Point(16, 32)
        lblTimbratureSubtitle.Name = "lblTimbratureSubtitle"
        lblTimbratureSubtitle.Size = New Size(268, 30)
        lblTimbratureSubtitle.TabIndex = 1
        lblTimbratureSubtitle.Text = "Giorni timbrati nel mese corrente"
        lblTimbratureSubtitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblTimbratureTitle
        '
        lblTimbratureTitle.Dock = DockStyle.Top
        lblTimbratureTitle.Font = New Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimbratureTitle.ForeColor = Color.White
        lblTimbratureTitle.Location = New Point(16, 16)
        lblTimbratureTitle.Name = "lblTimbratureTitle"
        lblTimbratureTitle.Size = New Size(268, 16)
        lblTimbratureTitle.TabIndex = 0
        lblTimbratureTitle.Text = "📅 Presenze del mese"
        lblTimbratureTitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' pnlCardStraordinari
        '
        pnlCardStraordinari.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlCardStraordinari.Controls.Add(lblStraordinariValue)
        pnlCardStraordinari.Controls.Add(lblStraordinariSubtitle)
        pnlCardStraordinari.Controls.Add(lblStraordinariTitle)
        pnlCardStraordinari.Margin = New Padding(10)
        pnlCardStraordinari.Name = "pnlCardStraordinari"
        pnlCardStraordinari.Padding = New Padding(16)
        pnlCardStraordinari.Size = New Size(300, 150)
        pnlCardStraordinari.TabIndex = 3
        '
        ' lblStraordinariValue
        '
        lblStraordinariValue.Dock = DockStyle.Top
        lblStraordinariValue.Font = New Font("Segoe UI Variable Text", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStraordinariValue.ForeColor = Color.White
        lblStraordinariValue.Location = New Point(16, 62)
        lblStraordinariValue.Name = "lblStraordinariValue"
        lblStraordinariValue.Size = New Size(268, 45)
        lblStraordinariValue.TabIndex = 2
        lblStraordinariValue.Text = "04h 10m"
        lblStraordinariValue.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblStraordinariSubtitle
        '
        lblStraordinariSubtitle.Dock = DockStyle.Top
        lblStraordinariSubtitle.Font = New Font("Segoe UI Variable Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStraordinariSubtitle.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblStraordinariSubtitle.Location = New Point(16, 32)
        lblStraordinariSubtitle.Name = "lblStraordinariSubtitle"
        lblStraordinariSubtitle.Size = New Size(268, 30)
        lblStraordinariSubtitle.TabIndex = 1
        lblStraordinariSubtitle.Text = "Straordinario maturato nel mese"
        lblStraordinariSubtitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblStraordinariTitle
        '
        lblStraordinariTitle.Dock = DockStyle.Top
        lblStraordinariTitle.Font = New Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStraordinariTitle.ForeColor = Color.White
        lblStraordinariTitle.Location = New Point(16, 16)
        lblStraordinariTitle.Name = "lblStraordinariTitle"
        lblStraordinariTitle.Size = New Size(268, 16)
        lblStraordinariTitle.TabIndex = 0
        lblStraordinariTitle.Text = "🚀 Straordinari"
        lblStraordinariTitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' pnlCardsContainer
        '
        pnlCardsContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCardsContainer.BackColor = Color.Transparent
        pnlCardsContainer.Controls.Add(pnlCardSaldoMensile)
        pnlCardsContainer.Controls.Add(pnlCardTimbrature)
        pnlCardsContainer.Controls.Add(pnlCardStraordinari)
        pnlCardsContainer.Location = New Point(30, 60)
        pnlCardsContainer.Name = "pnlCardsContainer"
        pnlCardsContainer.Size = New Size(961, 170)
        pnlCardsContainer.TabIndex = 4
        '
        ' UcDashboard
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(pnlCardsContainer)
        Controls.Add(lblTitle)
        Name = "UcDashboard"
        Size = New Size(1018, 800)
        pnlCardSaldoMensile.ResumeLayout(False)
        pnlCardTimbrature.ResumeLayout(False)
        pnlCardStraordinari.ResumeLayout(False)
        pnlCardsContainer.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlCardSaldoMensile As Panel
    Friend WithEvents lblSaldoMensileValue As Label
    Friend WithEvents lblSaldoMensileSubtitle As Label
    Friend WithEvents lblSaldoMensileTitle As Label
    Friend WithEvents pnlCardTimbrature As Panel
    Friend WithEvents lblTimbratureValue As Label
    Friend WithEvents lblTimbratureSubtitle As Label
    Friend WithEvents lblTimbratureTitle As Label
    Friend WithEvents pnlCardStraordinari As Panel
    Friend WithEvents lblStraordinariValue As Label
    Friend WithEvents lblStraordinariSubtitle As Label
    Friend WithEvents lblStraordinariTitle As Label
    Friend WithEvents pnlCardsContainer As FlowLayoutPanel
End Class
