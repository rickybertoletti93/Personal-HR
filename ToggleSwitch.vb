Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class ToggleSwitch
    Inherits Control

    Private _checked As Boolean

    <Category("Behavior"), DefaultValue(False)>
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            If _checked <> value Then
                _checked = value
                Invalidate()
                RaiseEvent CheckedChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    ' iOS-like colors
    <Category("Appearance"), DefaultValue(GetType(Color), "0, 200, 83")>
    Public Property OnBackColor As Color = Color.FromArgb(0, 200, 83)
    ' green

    <Category("Appearance"), DefaultValue(GetType(Color), "232, 232, 232")>
    Public Property OffBackColor As Color = Color.FromArgb(232, 232, 232)
    ' light gray

    <Category("Appearance"), DefaultValue(GetType(Color), "White")>
    Public Property ThumbColor As Color = Color.White


    ' Shadow tuning
    <Category("Appearance"), DefaultValue(28)>
    Public Property TrackShadowAlpha As Integer = 28


    <Category("Appearance"), DefaultValue(40)>
    Public Property ThumbShadowAlpha As Integer = 40


    Public Event CheckedChanged As EventHandler

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.FromArgb(238, 240, 244) ' colore light mode
        Me.Size = New Size(72, 40) ' close to your reference
        Me.Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        If e.Button = MouseButtons.Left Then
            Checked = Not Checked
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        Dim pad As Integer = 2

        ' Track (pill)
        Dim trackRect As New Rectangle(pad, pad, Width - pad * 2, Height - pad * 2)
        Dim radius As Integer = trackRect.Height \ 2

        ' Track shadow (soft, below-right)
        Dim shadowOffset As Integer = 1
        Dim trackShadowRect As New Rectangle(trackRect.X + shadowOffset, trackRect.Y + shadowOffset, trackRect.Width, trackRect.Height)
        Using pathShadow = RoundedRect(trackShadowRect, radius)
            Using br As New SolidBrush(Color.FromArgb(TrackShadowAlpha, 0, 0, 0))
                g.FillPath(br, pathShadow)
            End Using
        End Using

        ' Track fill
        Using pathTrack = RoundedRect(trackRect, radius)
            Using br As New SolidBrush(If(Checked, OnBackColor, OffBackColor))
                g.FillPath(br, pathTrack)
            End Using
        End Using

        ' Thumb (big circle)
        Dim thumbSize As Integer = trackRect.Height - 6
        Dim thumbY As Integer = trackRect.Y + (trackRect.Height - thumbSize) \ 2

        Dim thumbX As Integer
        If Checked Then
            thumbX = trackRect.Right - 3 - thumbSize
        Else
            thumbX = trackRect.Left + 3
        End If

        ' Thumb shadow
        Dim thumbShadowRect As New Rectangle(thumbX + 3, thumbY + 3, thumbSize, thumbSize)
        Using br As New SolidBrush(Color.FromArgb(ThumbShadowAlpha, 0, 0, 0))
            g.FillEllipse(br, thumbShadowRect)
        End Using

        ' Thumb
        Dim thumbRect As New Rectangle(thumbX, thumbY, thumbSize, thumbSize)
        Using br As New SolidBrush(ThumbColor)
            g.FillEllipse(br, thumbRect)
        End Using

        ' subtle rim
        Using pen As New Pen(Color.FromArgb(22, 0, 0, 0))
            g.DrawEllipse(pen, thumbRect)
        End Using
    End Sub

    Private Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
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
