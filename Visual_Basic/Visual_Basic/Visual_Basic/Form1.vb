Public Class frmClocks
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        Clock1.Text = TimeString ' 24 hour time '
        Clock2.Text = DateTime.Now.ToString("hh:mm:ss tt") ' Time with AM/PM '
    End Sub
End Class
