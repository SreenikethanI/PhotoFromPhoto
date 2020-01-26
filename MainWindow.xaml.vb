Public Class MainWindow
    Public Sub MeLoad() Handles Me.Loaded

    End Sub
    Public Sub ThemeSelectionChanged()
        If ThemeDark.IsChecked Then
            Me.Style = Me.FindResource("Dark")
        ElseIf ThemeLight.IsChecked Then
            Me.Style = Nothing
        Else
            ThemeDark.IsChecked = True
            ThemeSelectionChanged()
        End If
    End Sub
End Class