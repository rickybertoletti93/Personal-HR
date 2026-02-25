Imports System.Drawing.Drawing2D

Public Class UcDashboard
    Private ReadOnly _shadowPanels As New List(Of Panel)()

    Private Sub UcDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each card In GetCardPanels()
            RoundControl(card, 16)

            Dim shadow = CreateShadowBehind(card)
            RoundControl(shadow, 16)
            _shadowPanels.Add(shadow)
        Next
    End Sub

    Private Function GetCardPanels() As IEnumerable(Of Panel)
        Return {pnlCardSaldoMensile, pnlCardTimbrature, pnlCardStraordinari}
    End Function

    Private Function CreateShadowBehind(card As Panel) As Panel
        Dim shadow As New Panel() With {
            .Size = card.Size,
            .Location = New Point(card.Left + 4, card.Top + 4),
            .BackColor = Color.Transparent,
            .Margin = card.Margin
        }

        pnlCardsContainer.Controls.Add(shadow)
        shadow.SendToBack()
        card.BringToFront()

        AddHandler shadow.Paint,
            Sub(s, paintArgs)
                DrawSoftShadow(CType(s, Panel), paintArgs.Graphics, 16, 14)
            End Sub

        Return shadow
    End Function

    Private Sub DrawSoftShadow(p As Panel, g As Graphics, radius As Integer, alpha As Integer)
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, p.Width - 1, p.Height - 1)

        For i As Integer = 0 To 2
            Dim a As Integer = Math.Max(0, alpha - (i * 5))
            Dim r = Rectangle.Inflate(rect, -i, -i)

            Using path = RoundedRectPath(r, radius)
                Using br As New SolidBrush(Color.FromArgb(a, 0, 0, 0))
                    g.FillPath(br, path)
                End Using
            End Using
        Next
    End Sub

    Private Sub RoundControl(c As Control, radius As Integer)
        Dim rect As Rectangle = c.ClientRectangle
        If rect.Width <= 0 OrElse rect.Height <= 0 Then Return

        Using path = RoundedRectPath(New Rectangle(0, 0, rect.Width, rect.Height), radius)
            c.Region = New Region(path)
        End Using
    End Sub

    Private Function RoundedRectPath(r As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2

        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
