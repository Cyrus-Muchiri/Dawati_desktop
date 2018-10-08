Imports System.IO
Imports Apitron.PDF.Rasterizer
'Imports Apitron.PDF.Rasterizer

Public Class ebookViewer

    Public Sub initialize(ByVal url As String)
        Dim ebookName As String = url.Substring(24)
        ebookLabel.Text = ebookName
        ebookAxAcroPDF.LoadFile(url)

        'Using fStream As FileStream = New FileStream(url, FileMode.Open)
        '    Dim document As Document = New Document(fStream)
        '    Dim renderingSettings = New Configuration.RenderingSettings()
        '    For i As Integer = 0 To document.Pages.Count - 1
        '        Dim currentPage As Page = document.Pages(i)

        '        Using bitmap As Bitmap = currentPage.Render(currentPage.Width, currentPage.Height, renderingSettings)
        '            bitmap.Save(String.Format("{0}.png", i), Imaging.ImageFormat.Png)
        '        End Using
        '    Next
        '    Process.Start("0.png")
        'End Using
    End Sub



    Private Sub exitMetroButton_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click
        mainForm.encrypt()
        Close()
    End Sub

    Private Sub playMetroButton_Click(sender As Object, e As EventArgs) Handles playMetroButton.Click
        classRoom.getSelectedEbook(ebookPlayListBox)
    End Sub

    Private Sub ebookPlayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ebookPlayListBox.DoubleClick
        classRoom.getSelectedEbook(ebookPlayListBox)
    End Sub
End Class