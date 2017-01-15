Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TrackBar1.Value = Form1.Opacity * 100
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Form1.Opacity = TrackBar1.Value / 100
    End Sub
End Class