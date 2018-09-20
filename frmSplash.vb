Public Class frmSplash
    Private Sub frmSplash_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Get version no
        lblVersion.Text = "Version: " & Application.ProductVersion
        tmrStartup.Enabled = True
    End Sub

    Private Sub tmrStartup_Tick(sender As Object, e As EventArgs) Handles tmrStartup.Tick
        'Start time count
        prgBar.Increment(10)
        If prgBar.Value = 100 Then
            frmMain.Show()
            Me.Close()
            tmrStartup.Enabled = False
        End If
    End Sub
End Class