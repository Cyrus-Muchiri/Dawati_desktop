Imports System.IO
Imports Apitron.PDF.Rasterizer
'Imports Apitron.PDF.Rasterizer

Public Class ebookViewer
    Private multimediaSeries As Integer
    Private studylevel As String
    Public Sub initialize(ByVal url As String)
        Dim ebookName As String = url.Substring(24)
        ebookLabel.Text = ebookName
        ebookAxAcroPDF.LoadFile(url)
        ebookPlayListBox.Items.Clear()
        fillOtherListBox()

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
    Public Sub getters(ByVal multimediaSeries As Integer, ByVal studylevel As String)
        Me.multimediaSeries = multimediaSeries
        Me.studylevel = studylevel
    End Sub
    Public Sub fillOtherListBox()
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("multimedia.db")
        Dim strSql As String = "Select file_name from multimedia_content where multimedia_series ='" & multimediaSeries & "' and file_type='slides' and study_level='" & studylevel & "' "
        dbConnect.selectSqlite(strSql)

        While dbConnect.reader.Read

            ebookPlayListBox.Items.Add(dbConnect.reader("file_name"))
        End While
        dbConnect.closeSqlite()
    End Sub


    Private Sub exitMetroButton_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click
        mainForm.encrypt()
        Close()
        classRoom.MdiParent = dawatiParent
        classRoom.Show()
    End Sub

    Private Sub playMetroButton_Click(sender As Object, e As EventArgs) Handles playMetroButton.Click
        classRoom.getSelectedEbook(ebookPlayListBox)
    End Sub

    Private Sub ebookPlayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ebookPlayListBox.DoubleClick
        classRoom.getSelectedEbook(ebookPlayListBox)
    End Sub
#Region "menu strips"
    Private Sub AttemptToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        mainForm.ebooksMetroPanel.Visible = False
        mainForm.aboutPanel.Visible = False
        mainForm.videosMetroPanel.Visible = False
        mainForm.profilePanel.Visible = False
        mainForm.evaluationMetroPanel.Visible = True
    End Sub

    Private Sub mathsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "Mathematics"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "english"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "biology"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Close()
        Dim subject As String = "physics"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub chemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "chemistry"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub ebooksMathsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Close()
        Dim subject As String = "Mathematics"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub ebookEngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "english"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookBioToolStripMenuIte_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "biology"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookPhyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "physics"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookChemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
        Dim subject As String = "chemistry"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub
#End Region
End Class