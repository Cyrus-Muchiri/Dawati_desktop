Imports System.Windows.Forms

Public Class dawatiParent

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Create a new instance of the child form.
        ' Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        mainForm.initialize()
        mainForm.MdiParent = Me

        ' m_ChildFormNumber += 1
        ' ChildForm.Text = "Window " & m_ChildFormNumber
        mainForm.Show()
    End Sub
    Private Sub closeform(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want exit dawati", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'If result = DialogResult.Yes Then
        Application.Exit()

        'ElseIf result = DialogResult.No Then
        '    'make sure user doesnt exit
        'End If
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
#Region "menu strips"
    Private Sub AttemptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttemptToolStripMenuItem.Click

        mainForm.ebooksMetroPanel.Visible = False
        mainForm.aboutPanel.Visible = False
        mainForm.videosMetroPanel.Visible = False
        mainForm.profilePanel.Visible = False
        mainForm.evaluationMetroPanel.Visible = True
    End Sub

    Private Sub mathsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mathsToolStripMenuItem.Click

        Dim subject As String = "Mathematics"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles englishToolStripMenuItem.Click

        Dim subject As String = "english"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles biologyToolStripMenuItem.Click

        Dim subject As String = "biology"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles physicsToolStripMenuItem.Click


        Dim subject As String = "physics"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub chemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles chemToolStripMenuItem.Click

        Dim subject As String = "chemistry"
        Dim learningMaterial As String = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub ebooksMathsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ebooksMathsToolStripMenuItem.Click


        Dim subject As String = "Mathematics"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub ebookEngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ebookEngToolStripMenuItem.Click

        Dim subject As String = "english"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookBioToolStripMenuIte_Click(sender As Object, e As EventArgs) Handles EbookBioToolStripMenuIte.Click

        Dim subject As String = "biology"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookPhyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EbookPhyToolStripMenuItem.Click

        Dim subject As String = "physics"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub EbookChemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EbookChemToolStripMenuItem.Click

        Dim subject As String = "chemistry"
        Dim learningMaterial As String = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

#End Region

    Private m_ChildFormNumber As Integer

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        classRoom.Close()
        videoPlayer.Close()
        ebookViewer.Close()
        evaluationForm.Close()
        attemptReports.Close()
        questions.Close()

        mainForm.MdiParent = Me
        mainForm.Show()
        mainForm.WindowState = FormWindowState.Maximized
    End Sub
End Class
