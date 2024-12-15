Public Class Form_Admin

    Dim isHovered As Boolean = False
    Dim animationTimer As Timer

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animationTimer = New Timer()
        animationTimer.Interval = 30
    End Sub

    Private Sub btnHover(sender As Object, e As EventArgs) Handles btnStudent.MouseMove, Button1.MouseMove, Button2.MouseMove, Button3.MouseMove, Button4.MouseMove
        animationTimer.Start()
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnStudent.MouseLeave, Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
        btnStudent.ForeColor = Color.Black
        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        isHovered = True
        animationTimer.Stop()
    End Sub

    Private Sub AnimationTimer1_Tick(sender As Object, e As EventArgs) Handles AnimationTimer1.Tick

    End Sub


End Class