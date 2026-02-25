
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcImpostazioni
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlCardFerie = New Panel()
        Panel3 = New Panel()
        lblFERIESaldoFineAnno = New Label()
        lblFERIEProiezione = New Label()
        lblFERIESaldo = New Label()
        pnlFerieMatUsati = New Panel()
        Panel2 = New Panel()
        lblFERIEUtilizzate = New Label()
        Label2 = New Label()
        Label4 = New Label()
        pnlFerieMaturati = New Panel()
        lblFERIEMaturate = New Label()
        Label3 = New Label()
        lblMaturateSymbol = New Label()
        pnlCardFerieTitle = New Panel()
        lblFERIE = New Label()
        pnlCardROL = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Panel7 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel8 = New Panel()
        lblROL = New Label()
        pnlCardFerie.SuspendLayout()
        Panel3.SuspendLayout()
        pnlFerieMatUsati.SuspendLayout()
        Panel2.SuspendLayout()
        pnlFerieMaturati.SuspendLayout()
        pnlCardFerieTitle.SuspendLayout()
        pnlCardROL.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblTitle.Location = New Point(891, 21)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(100, 21)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Impostazioni"
        ' 
        ' pnlCardFerie
        ' 
        pnlCardFerie.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlCardFerie.Controls.Add(Panel3)
        pnlCardFerie.Controls.Add(pnlFerieMatUsati)
        pnlCardFerie.Controls.Add(pnlCardFerieTitle)
        pnlCardFerie.Location = New Point(40, 70)
        pnlCardFerie.Margin = New Padding(10)
        pnlCardFerie.Name = "pnlCardFerie"
        pnlCardFerie.Padding = New Padding(10)
        pnlCardFerie.Size = New Size(420, 158)
        pnlCardFerie.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(lblFERIESaldoFineAnno)
        Panel3.Controls.Add(lblFERIEProiezione)
        Panel3.Controls.Add(lblFERIESaldo)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(10, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(258, 98)
        Panel3.TabIndex = 4
        ' 
        ' lblFERIESaldoFineAnno
        ' 
        lblFERIESaldoFineAnno.BackColor = Color.Transparent
        lblFERIESaldoFineAnno.Dock = DockStyle.Fill
        lblFERIESaldoFineAnno.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFERIESaldoFineAnno.ForeColor = Color.White
        lblFERIESaldoFineAnno.Location = New Point(147, 50)
        lblFERIESaldoFineAnno.Name = "lblFERIESaldoFineAnno"
        lblFERIESaldoFineAnno.Size = New Size(111, 48)
        lblFERIESaldoFineAnno.TabIndex = 2
        lblFERIESaldoFineAnno.Text = "13,33h"
        lblFERIESaldoFineAnno.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFERIEProiezione
        ' 
        lblFERIEProiezione.Dock = DockStyle.Left
        lblFERIEProiezione.ForeColor = Color.White
        lblFERIEProiezione.Location = New Point(0, 50)
        lblFERIEProiezione.Name = "lblFERIEProiezione"
        lblFERIEProiezione.Size = New Size(147, 48)
        lblFERIEProiezione.TabIndex = 1
        lblFERIEProiezione.Text = "Proiezione fine anno:"
        lblFERIEProiezione.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFERIESaldo
        ' 
        lblFERIESaldo.Dock = DockStyle.Top
        lblFERIESaldo.Font = New Font("Segoe UI Variable Text", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFERIESaldo.ForeColor = Color.White
        lblFERIESaldo.Location = New Point(0, 0)
        lblFERIESaldo.Name = "lblFERIESaldo"
        lblFERIESaldo.Size = New Size(258, 50)
        lblFERIESaldo.TabIndex = 0
        lblFERIESaldo.Text = "Saldo:   152,20h"
        lblFERIESaldo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlFerieMatUsati
        ' 
        pnlFerieMatUsati.Controls.Add(Panel2)
        pnlFerieMatUsati.Controls.Add(pnlFerieMaturati)
        pnlFerieMatUsati.Location = New Point(274, 76)
        pnlFerieMatUsati.Name = "pnlFerieMatUsati"
        pnlFerieMatUsati.Size = New Size(140, 70)
        pnlFerieMatUsati.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblFERIEUtilizzate)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 36)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(5, 0, 0, 0)
        Panel2.Size = New Size(140, 36)
        Panel2.TabIndex = 1
        ' 
        ' lblFERIEUtilizzate
        ' 
        lblFERIEUtilizzate.BackColor = Color.Transparent
        lblFERIEUtilizzate.Dock = DockStyle.Fill
        lblFERIEUtilizzate.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFERIEUtilizzate.ForeColor = Color.White
        lblFERIEUtilizzate.Location = New Point(34, 0)
        lblFERIEUtilizzate.Name = "lblFERIEUtilizzate"
        lblFERIEUtilizzate.Size = New Size(50, 36)
        lblFERIEUtilizzate.TabIndex = 1
        lblFERIEUtilizzate.Text = "4,5h"
        lblFERIEUtilizzate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Right
        Label2.Font = New Font("Segoe UI Variable Small Light", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(84, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 36)
        Label2.TabIndex = 2
        Label2.Text = "Utilizzate"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 36)
        Label4.TabIndex = 0
        Label4.Text = "📉"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlFerieMaturati
        ' 
        pnlFerieMaturati.Controls.Add(lblFERIEMaturate)
        pnlFerieMaturati.Controls.Add(Label3)
        pnlFerieMaturati.Controls.Add(lblMaturateSymbol)
        pnlFerieMaturati.Dock = DockStyle.Top
        pnlFerieMaturati.Location = New Point(0, 0)
        pnlFerieMaturati.Name = "pnlFerieMaturati"
        pnlFerieMaturati.Padding = New Padding(5, 0, 0, 0)
        pnlFerieMaturati.Size = New Size(140, 36)
        pnlFerieMaturati.TabIndex = 0
        ' 
        ' lblFERIEMaturate
        ' 
        lblFERIEMaturate.BackColor = Color.Transparent
        lblFERIEMaturate.Dock = DockStyle.Fill
        lblFERIEMaturate.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFERIEMaturate.ForeColor = Color.White
        lblFERIEMaturate.Location = New Point(34, 0)
        lblFERIEMaturate.Name = "lblFERIEMaturate"
        lblFERIEMaturate.Size = New Size(50, 36)
        lblFERIEMaturate.TabIndex = 1
        lblFERIEMaturate.Text = "13,33h"
        lblFERIEMaturate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Dock = DockStyle.Right
        Label3.Font = New Font("Segoe UI Variable Small Light", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.ImageAlign = ContentAlignment.MiddleLeft
        Label3.Location = New Point(84, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 36)
        Label3.TabIndex = 2
        Label3.Text = "Maturate"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMaturateSymbol
        ' 
        lblMaturateSymbol.BackColor = Color.Transparent
        lblMaturateSymbol.Dock = DockStyle.Left
        lblMaturateSymbol.Font = New Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaturateSymbol.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblMaturateSymbol.ImageAlign = ContentAlignment.MiddleLeft
        lblMaturateSymbol.Location = New Point(5, 0)
        lblMaturateSymbol.Name = "lblMaturateSymbol"
        lblMaturateSymbol.Size = New Size(29, 36)
        lblMaturateSymbol.TabIndex = 0
        lblMaturateSymbol.Text = "📈"
        lblMaturateSymbol.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardFerieTitle
        ' 
        pnlCardFerieTitle.BackColor = Color.Transparent
        pnlCardFerieTitle.Controls.Add(lblFERIE)
        pnlCardFerieTitle.Dock = DockStyle.Top
        pnlCardFerieTitle.Location = New Point(10, 10)
        pnlCardFerieTitle.Name = "pnlCardFerieTitle"
        pnlCardFerieTitle.Size = New Size(400, 40)
        pnlCardFerieTitle.TabIndex = 2
        ' 
        ' lblFERIE
        ' 
        lblFERIE.BackColor = Color.Transparent
        lblFERIE.Dock = DockStyle.Fill
        lblFERIE.Font = New Font("Segoe UI Variable Display", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFERIE.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblFERIE.Location = New Point(0, 0)
        lblFERIE.Name = "lblFERIE"
        lblFERIE.Size = New Size(400, 40)
        lblFERIE.TabIndex = 3
        lblFERIE.Text = "Ferie"
        lblFERIE.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlCardROL
        ' 
        pnlCardROL.BackColor = Color.FromArgb(CByte(29), CByte(38), CByte(54))
        pnlCardROL.Controls.Add(Panel4)
        pnlCardROL.Controls.Add(Panel5)
        pnlCardROL.Controls.Add(Panel8)
        pnlCardROL.Location = New Point(536, 70)
        pnlCardROL.Margin = New Padding(10)
        pnlCardROL.Name = "pnlCardROL"
        pnlCardROL.Padding = New Padding(10)
        pnlCardROL.Size = New Size(420, 158)
        pnlCardROL.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label6)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(10, 50)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(258, 98)
        Panel4.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(147, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 48)
        Label1.TabIndex = 2
        Label1.Text = "13,33h"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.ForeColor = Color.White
        Label5.Location = New Point(0, 50)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 48)
        Label5.TabIndex = 1
        Label5.Text = "Proiezione fine anno:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Top
        Label6.Font = New Font("Segoe UI Variable Text", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(258, 50)
        Label6.TabIndex = 0
        Label6.Text = "Saldo:   152,20h"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Panel7)
        Panel5.Location = New Point(274, 76)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(140, 70)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label9)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 36)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(5, 0, 0, 0)
        Panel6.Size = New Size(140, 36)
        Panel6.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(34, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 36)
        Label7.TabIndex = 1
        Label7.Text = "4,5h"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Dock = DockStyle.Right
        Label8.Font = New Font("Segoe UI Variable Small Light", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.ImageAlign = ContentAlignment.MiddleLeft
        Label8.Location = New Point(84, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 36)
        Label8.TabIndex = 2
        Label8.Text = "Utilizzate"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Dock = DockStyle.Left
        Label9.Font = New Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        Label9.ImageAlign = ContentAlignment.MiddleLeft
        Label9.Location = New Point(5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 36)
        Label9.TabIndex = 0
        Label9.Text = "📉"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(Label12)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(5, 0, 0, 0)
        Panel7.Size = New Size(140, 36)
        Panel7.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Segoe UI Variable Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(34, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 36)
        Label10.TabIndex = 1
        Label10.Text = "13,33h"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Transparent
        Label11.Dock = DockStyle.Right
        Label11.Font = New Font("Segoe UI Variable Small Light", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(84, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 36)
        Label11.TabIndex = 2
        Label11.Text = "Maturate"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Transparent
        Label12.Dock = DockStyle.Left
        Label12.Font = New Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(29, 36)
        Label12.TabIndex = 0
        Label12.Text = "📈"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Transparent
        Panel8.Controls.Add(lblROL)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 10)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(400, 40)
        Panel8.TabIndex = 2
        ' 
        ' lblROL
        ' 
        lblROL.BackColor = Color.Transparent
        lblROL.Dock = DockStyle.Fill
        lblROL.Font = New Font("Segoe UI Variable Display", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblROL.ForeColor = Color.FromArgb(CByte(170), CByte(199), CByte(255))
        lblROL.Location = New Point(0, 0)
        lblROL.Name = "lblROL"
        lblROL.Size = New Size(400, 40)
        lblROL.TabIndex = 3
        lblROL.Text = "ROL"
        lblROL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UcImpostazioni
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(pnlCardROL)
        Controls.Add(pnlCardFerie)
        Controls.Add(lblTitle)
        Name = "UcImpostazioni"
        Size = New Size(1018, 800)
        pnlCardFerie.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        pnlFerieMatUsati.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        pnlFerieMaturati.ResumeLayout(False)
        pnlCardFerieTitle.ResumeLayout(False)
        pnlCardROL.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlCardFerie As Panel
    Friend WithEvents pnlFerieMatUsati As Panel
    Friend WithEvents pnlFerieMaturati As Panel
    Friend WithEvents pnlCardFerieTitle As Panel
    Friend WithEvents lblFERIE As Label
    Friend WithEvents lblMaturateSymbol As Label
    Friend WithEvents lblFERIEMaturate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFERIEUtilizzate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFERIESaldo As Label
    Friend WithEvents lblFERIESaldoFineAnno As Label
    Friend WithEvents lblFERIEProiezione As Label
    Friend WithEvents pnlCardROL As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblROL As Label

End Class
