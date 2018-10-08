Public Class videoPlayer
    Private videoPath As String
    'Public Sub initialize(ByVal url As String)
    Public Sub initialize(ByVal url As String)
        AxWindowsMediaPlayer.URL = url
        videoPath = url
    End Sub


    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        mainForm.encrypt()
        Close()
    End Sub

    Private Sub playMetroButton_Click(sender As Object, e As EventArgs) Handles playMetroButton.Click
        classRoom.getSelectedVideo(playListListBox)

    End Sub

    Private Sub playListListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playListListBox.DoubleClick
        classRoom.getSelectedVideo(playListListBox)
    End Sub
End Class