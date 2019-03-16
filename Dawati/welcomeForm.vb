﻿'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 06/09/2018
'welcome
Public Class welcomeForm
    Public Sub initialize()

        welcomeLabel.Text = "DAWATI ONLINE EDUCATION"
        welcomeLabel.ForeColor = Color.FromArgb(0, 161, 154)
        mainPictureBox.BackgroundImage = Image.FromFile("assets\images\banner.png")
        mainPictureBox.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    

    Private Sub signUpMetroTile_Click_1(sender As Object, e As EventArgs) 
        signUpForm.ShowDialog()


    End Sub

    Private Sub signInMetroTile_Click(sender As Object, e As EventArgs) Handles signInMetroTile.Click
        signInForm.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click
        Me.Close()
        Application.Exit()
    End Sub
    Private Sub MetroButton3_gotFocus(sender As Object, e As EventArgs) Handles exitMetroButton.GotFocus
        exitMetroButton.Highlight = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        ' Panel1.BackColor = Color.FromArgb(30, Color.Blue)
    End Sub
    Private Sub welcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()
    End Sub
    Private Sub welcomeForm_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class