Imports System.Drawing.Drawing2D

Public Class UcImpostazioni
    Private pnlShadowFerie As Panel
    Private pnlShadowROL As Panel

    ' --- Layout scaling (solo quando la Form è massimizzata) ---
    Private _baseSize As Size
    Private _layoutSaved As Boolean = False

    Private _baseBounds As New Dictionary(Of Control, Rectangle)()
    Private _baseFontSize As New Dictionary(Of Control, Single)()

    Private _isApplying As Boolean = False

    Private Sub UcImpostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1) Ombre dietro i card
        pnlShadowFerie = CreateShadowBehind(pnlCardFerie)
        pnlShadowROL = CreateShadowBehind(pnlCardROL)

        pnlShadowFerie.Name = "pnlShadowFerie"
        pnlShadowROL.Name = "pnlShadowROL"


        ' 2) Angoli stondati ai card
        RoundControl(pnlCardFerie, 16)
        RoundControl(pnlCardROL, 16)

        ' (facoltativo) anche le ombre leggermente stondate
        RoundControl(pnlShadowFerie, 16)
        RoundControl(pnlShadowROL, 16)
    End Sub

    Private Function CreateShadowBehind(card As Panel) As Panel
        Dim shadow As New Panel()

        shadow.Size = card.Size
        shadow.Location = New Point(card.Left + 4, card.Top + 4)
        shadow.BackColor = Color.Transparent

        card.Parent.Controls.Add(shadow)
        shadow.SendToBack()
        card.BringToFront()

        AddHandler shadow.Paint,
            Sub(s, e)
                DrawSoftShadow(CType(s, Panel), e.Graphics, 16, 14)
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

    Private Sub SaveBaseLayout(root As Control)
        _baseSize = root.Size
        _baseBounds.Clear()
        _baseFontSize.Clear()

        CaptureControlTree(root)

        _layoutSaved = True
    End Sub

    Private Sub CaptureControlTree(c As Control)
        _baseBounds(c) = c.Bounds
        _baseFontSize(c) = c.Font.Size

        For Each child As Control In c.Controls
            CaptureControlTree(child)
        Next
    End Sub

    Private Sub RestoreBaseLayout()
        If Not _layoutSaved Then Return

        Me.SuspendLayout()
        Try
            For Each kv In _baseBounds
                Dim ctrl = kv.Key
                If ctrl Is Nothing OrElse ctrl.IsDisposed Then Continue For
                ctrl.Bounds = kv.Value

                If _baseFontSize.ContainsKey(ctrl) Then
                    Dim sz = _baseFontSize(ctrl)
                    ctrl.Font = New Font(ctrl.Font.FontFamily, sz, ctrl.Font.Style)
                End If
            Next
        Finally
            Me.ResumeLayout()
        End Try

        ' Ombre + angoli dopo restore
        SyncShadowAndRound()
    End Sub

    Private Sub ApplyScaleToLayout(scaleX As Single, scaleY As Single)
        If Not _layoutSaved Then Return

        Me.SuspendLayout()
        Try
            For Each kv In _baseBounds
                Dim ctrl = kv.Key
                If ctrl Is Nothing OrElse ctrl.IsDisposed Then Continue For

                Dim r0 = kv.Value
                Dim x = CInt(Math.Round(r0.X * scaleX))
                Dim y = CInt(Math.Round(r0.Y * scaleY))
                Dim w = CInt(Math.Round(r0.Width * scaleX))
                Dim h = CInt(Math.Round(r0.Height * scaleY))

                ctrl.Bounds = New Rectangle(x, y, Math.Max(1, w), Math.Max(1, h))

                ' Font: usa una scala “media” (evita testi schiacciati su Y o X)
                If _baseFontSize.ContainsKey(ctrl) Then
                    Dim s0 = _baseFontSize(ctrl)
                    Dim s = s0 * ((scaleX + scaleY) / 2.0F)
                    s = Math.Max(6.0F, s) ' minimo leggibile
                    ctrl.Font = New Font(ctrl.Font.FontFamily, s, ctrl.Font.Style)
                End If
            Next
        Finally
            Me.ResumeLayout()
        End Try

        SyncShadowAndRound()
    End Sub

    Private Sub SyncShadowAndRound()
        ' Spostamento ombra: puoi anche scalarlo, ma di solito 4px fissi è ok
        If pnlShadowFerie IsNot Nothing Then
            pnlShadowFerie.Size = pnlCardFerie.Size
            pnlShadowFerie.Location = New Point(pnlCardFerie.Left + 4, pnlCardFerie.Top + 4)
            pnlShadowFerie.Invalidate()
        End If

        If pnlShadowROL IsNot Nothing Then
            pnlShadowROL.Size = pnlCardROL.Size
            pnlShadowROL.Location = New Point(pnlCardROL.Left + 4, pnlCardROL.Top + 4)
            pnlShadowROL.Invalidate()
        End If

        ' Region arrotondata va rifatta dopo resize
        RoundControl(pnlCardFerie, 16)
        RoundControl(pnlCardROL, 16)

        If pnlShadowFerie IsNot Nothing Then RoundControl(pnlShadowFerie, 16)
        If pnlShadowROL IsNot Nothing Then RoundControl(pnlShadowROL, 16)

    End Sub

End Class

