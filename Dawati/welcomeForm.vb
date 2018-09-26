'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 06/09/2018
'welcome
Public Class welcomeForm
    Private loading As Boolean


    Public Function initialize()
        welcomeFormPanel.BackgroundImage = Image.FromFile("assets\images\bannner.png")
        welcomeFormPanel.BackgroundImageLayout = ImageLayout.Stretch
        'welcomeFormPanel.BackgroundImage = Opacity(BackgroundImage, 25%)

    End Function


    'Private Sub prevMetroButton_Click(sender As Object, e As EventArgs)
    '    Dim count As Integer = 1
    '    Dim i As Integer = 5

    '    While count < i
    '        '  sliderPictureBox.Image = sliderImageList.Images(count)
    '        count += count

    '    End While

    '    loading = True


    'End Sub


    Private Sub signUpMetroTile_Click_1(sender As Object, e As EventArgs) Handles signUpMetroTile.Click
        signUpForm.Show()


    End Sub

    Private Sub signInMetroTile_Click(sender As Object, e As EventArgs) Handles signInMetroTile.Click
        signInForm.Show()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Panel1.BackColor = Color.FromArgb(30, Color.Blue)
    End Sub


End Class