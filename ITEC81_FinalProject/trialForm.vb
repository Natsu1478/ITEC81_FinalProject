Public Class trialForm
    Private Sub trialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim WithEvents hoverTimer As Timer
    Dim isHovered As Boolean = False
    Dim targetSize As Integer = 120
    Dim animationStep As Integer = 5

    Public Sub New()
        InitializeComponent()

        ' Initialize Timer
        hoverTimer = New Timer()
        hoverTimer.Interval = 30 ' Set the timer interval (ms)
        hoverTimer.Start()

        ' Set initial size of the button
        Button1.Width = 300
        Button1.Height = 150
    End Sub

    ' MouseEnter event to trigger hover effect
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        isHovered = True
    End Sub

    ' MouseLeave event to reset the effect when mouse leaves
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        isHovered = False
    End Sub

    ' Timer Tick event to animate hover effect
    Private Sub hoverTimer_Tick(sender As Object, e As EventArgs) Handles hoverTimer.Tick
        If isHovered Then
            ' Animate the background color and size increase on hover
            If Button1.Width < targetSize Then
                Button1.Width += animationStep
                Button1.Height += animationStep
                Button1.BackColor = Color.LightBlue ' Change background color (optional)
            End If
        Else
            ' Animate the background color and size decrease when mouse leaves
            If Button1.Width > 100 Then
                Button1.Width -= animationStep
                Button1.Height -= animationStep
                Button1.BackColor = Color.LightGray ' Reset background color (optional)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
