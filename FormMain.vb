
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Public Class FormMain

    Private sidebarExpanded As Boolean = True
    Private Const SidebarExpandedWidth As Integer = 220
    Private Const SidebarCollapsedWidth As Integer = 64
    Private settingsPage As New UcImpostazioni()


    ' Testi completi (icona + nome) e testi compatti (solo icona)
    Private ReadOnly FullDashboard As String = "📊   Dashboard"
    Private ReadOnly FullTimbrature As String = "⏱   Timbrature"
    Private ReadOnly FullPermessi As String = "🗓   Permessi"
    Private ReadOnly FullImpostazioni As String = "⚙   Impostazioni"

    Private ReadOnly MiniDashboard As String = "📊"
    Private ReadOnly MiniTimbrature As String = "⏱"
    Private ReadOnly MiniPermessi As String = "🗓"
    Private ReadOnly MiniImpostazioni As String = "⚙"

    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' stato iniziale: espanso
        ApplySidebarState(True)


        ' evidenzia Dashboard come attivo (facoltativo)
        SetActiveMenu(btnDashboard)
        AddHandler pnlTitleBar.MouseDown, AddressOf pnlTitleBar_MouseDown
        AddHandler btnImpostazioni.Click, AddressOf btnImpostazioni_Click
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        sidebarExpanded = Not sidebarExpanded
        ApplySidebarState(sidebarExpanded)
    End Sub

    Private Sub ApplySidebarState(expanded As Boolean)

        pnlSidebar.Width = If(expanded, SidebarExpandedWidth, SidebarCollapsedWidth)

        ' Testo: espanso = icona + testo, compatto = solo icona
        btnDashboard.Text = If(expanded, FullDashboard, MiniDashboard)
        btnTimbrature.Text = If(expanded, FullTimbrature, MiniTimbrature)
        btnPermessi.Text = If(expanded, FullPermessi, MiniPermessi)
        btnImpostazioni.Text = If(expanded, FullImpostazioni, MiniImpostazioni)

        ' Allineamenti e padding
        For Each b As Button In {btnDashboard, btnTimbrature, btnPermessi, btnImpostazioni}
            b.TextAlign = If(expanded, ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter)
            b.Padding = If(expanded, New Padding(12, 0, 0, 0), New Padding(0))
        Next

        ' Tooltip (utile quando è compatta)
        Dim tt As New ToolTip()
        tt.SetToolTip(btnDashboard, "Dashboard")
        tt.SetToolTip(btnTimbrature, "Timbrature")
        tt.SetToolTip(btnPermessi, "Permessi")
        tt.SetToolTip(btnImpostazioni, "Impostazioni")

        pnlShadow.Width = If(expanded, 12, 8)


    End Sub

    ' === Gestione "menu attivo" (colore testo + (opzionale) sfondo leggero) ===
    Private Sub SetActiveMenu(activeBtn As Button)

        Dim normalFore As Color = Color.FromArgb(255, 255, 255)
        Dim activeFore As Color = Color.FromArgb(255, 255, 255)

        For Each b As Button In {btnDashboard, btnTimbrature, btnPermessi, btnImpostazioni}
            b.ForeColor = normalFore
            b.BackColor = Color.Transparent
        Next

        activeBtn.ForeColor = activeFore
        activeBtn.BackColor = Color.FromArgb(65, 72, 86) ' sfondo soft (puoi toglierlo se lo vuoi minimal)

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
    End Sub

    Private Sub pnlShadow_Paint(sender As Object, e As PaintEventArgs) Handles pnlShadow.Paint

        Dim g = e.Graphics
        Dim rect As New Rectangle(0, 0, pnlShadow.Width, pnlShadow.Height)

        Using brush As New Drawing2D.LinearGradientBrush(
        rect,
        Color.FromArgb(15, 0, 0, 0),   ' leggerissima ombra
        Color.Transparent,
        Drawing2D.LinearGradientMode.Horizontal)

            g.FillRectangle(brush, rect)
        End Using

    End Sub


    ' Click menu: per ora solo evidenzia
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetActiveMenu(btnDashboard)
    End Sub

    Private Sub btnTimbrature_Click(sender As Object, e As EventArgs) Handles btnTimbrature.Click
        SetActiveMenu(btnTimbrature)
    End Sub

    Private Sub btnPermessi_Click(sender As Object, e As EventArgs) Handles btnPermessi.Click
        SetActiveMenu(btnPermessi)
    End Sub


    Private Sub MakeRoundButton(b As Button)
        b.Width = 15
        b.Height = 15
        b.FlatStyle = FlatStyle.Flat
        b.FlatAppearance.BorderSize = 0
        b.TabStop = False

        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, b.Width, b.Height)
        b.Region = New Region(gp)
    End Sub

    ' ROSSO: chiudi
    Private Sub btnMacClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    ' GIALLO: minimizza
    Private Sub btnMacMinimize_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    ' VERDE: massimizza / ripristina
    Private Sub btnMacMaximize_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    ' === Drag finestra dalla titlebar (se non l'hai già) ===
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Sub pnlTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112, &HF012, 0)
        End If
    End Sub

    Private Sub ShowPage(page As UserControl)
        pnlContent.SuspendLayout()
        pnlContent.Controls.Clear()
        page.Dock = DockStyle.Fill
        pnlContent.Controls.Add(page)
        pnlContent.ResumeLayout()
    End Sub

    Private Sub btnImpostazioni_Click(sender As Object, e As EventArgs)
        SetActiveMenu(btnImpostazioni)
        ShowPage(New UcImpostazioni())
    End Sub





End Class
