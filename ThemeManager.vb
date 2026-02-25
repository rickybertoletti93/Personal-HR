Public Module ThemeManager

    Public Enum AppTheme
        Light
        Dark
    End Enum

    Public Sub ApplyTheme(root As Control, theme As AppTheme)
        Dim bg As Color = If(theme = AppTheme.Dark, Color.FromArgb(33, 33, 33), Color.FromArgb(238, 240, 244))
        Dim sidebar As Color = If(theme = AppTheme.Dark, Color.FromArgb(24, 24, 24), Color.FromArgb(246, 247, 251))
        Dim txt As Color = If(theme = AppTheme.Dark, Color.FromArgb(246, 247, 251), Color.FromArgb(93, 106, 125))

        ApplyRecursive(root, bg, sidebar, txt)
    End Sub

    Private Sub ApplyRecursive(c As Control, bg As Color, sidebar As Color, txt As Color)

        ' Background generale
        If TypeOf c Is Form OrElse TypeOf c Is UserControl Then
            c.BackColor = bg
        ElseIf TypeOf c Is Panel Then
            ' Sidebar riconosciuta per Name
            If c.Name = "pnlSidebar" Then
                c.BackColor = sidebar
            End If
        End If

        ' Testi
        If TypeOf c Is Label OrElse TypeOf c Is Button Then
            c.ForeColor = txt
        End If

        For Each child As Control In c.Controls
            ApplyRecursive(child, bg, sidebar, txt)
        Next
    End Sub

End Module
