Public Class ebookViewer

    Public Sub initialize(ByVal url As String)
        Dim ebookName As String = url.Substring(24)
        ebookLabel.Text = ebookName
        ebookAxAcroPDF.LoadFile(url)
    End Sub



    Private Sub exitMetroButton_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click
        mainForm.encrypt()
        Close()
    End Sub

    Private Sub playMetroButton_Click(sender As Object, e As EventArgs) Handles playMetroButton.Click
        classRoom.getSelectedEbook(ebookPlayListBox)
    End Sub
End Class