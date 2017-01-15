Public Class Form1
    Public Declare Function GetIni Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpAppName As String _
                                                                                  , ByVal lpKeyName As String _
                                                                                  , ByVal lpDefault As String _
                                                                                  , ByRef lpReturnedString As String _
                                                                                  , ByVal nSize As Integer _
                                                                                  , ByVal lpFileName As String) As Integer
    Public Declare Function WriteIni Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpAppName As String _
                                                                                      , ByVal lpKeyName As String _
                                                                                      , ByVal lpString As String _
                                                                                      , ByVal lpFileName As String) As Boolean
    Private mouse As Point
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now(), "yyyy/MM/dd" & vbNewLine & "tt h:m:s" & vbNewLine & "dddd")
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        mouse = e.Location
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If Panel1.Capture Then
            Me.Location = New Point(Me.Location.X + e.Location.X - mouse.X, Me.Location.Y + e.Location.Y - mouse.Y)
        End If
        If e.Location.X < 185 And e.Location.X > 5 And e.Location.Y < 20 And e.Location.Y > 5 Then
            display()
        Else
            vanish()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As System.EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub display()
        Label2.ForeColor = Color.White
        Label2.BackColor = Color.Red
        Label2.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Visible = True
    End Sub
    Private Sub vanish()
        Label2.ForeColor = Color.MediumSeaGreen
        Label2.BackColor = Color.MediumSeaGreen
        Label2.BorderStyle = BorderStyle.None
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'GetIni("position", "window_x"
    End Sub
End Class
