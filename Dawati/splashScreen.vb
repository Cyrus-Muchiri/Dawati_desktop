Public Class splashScreen
    Public Sub initialize()
        welcomeForm.initialize()
        loadTimer.Interval = 5000
        loadTimer.Enabled = True
        'loadTimer.Start()
    End Sub
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim init As New splashScreen

        Me.BackColor = Color.FromArgb(0, 161, 154)
        Me.BackgroundImage = Image.FromFile("assets\images\dawatiLogo.png")
        initialize()
        'Me.minimundisoa
        'loadTimer.Interval = 10000
        'loadTimer.Enabled = True
    End Sub

    Private Sub loadTimer_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick
        loadTimer.Stop()
        welcomeForm.Show()
        Hide()
    End Sub

End Class