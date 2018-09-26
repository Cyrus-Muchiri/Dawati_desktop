Public Class selectStudyLevel
    Private learningMaterial
    Private subject As String
    Private studyLevel As String
    Public Sub initialize(ByVal subject As String, ByVal learningMaterial As String)
        Me.learningMaterial = learningMaterial
        Me.subject = subject
    End Sub
    Private Sub form1MetroTile_Click(sender As Object, e As EventArgs) Handles form1MetroTile.Click
        studyLevel = "Form 1"
        classRoom.initialize(subject, learningMaterial, studyLevel)
        classRoom.Show()

        Me.Close()
    End Sub

    Private Sub form2MetroTile_Click(sender As Object, e As EventArgs) Handles form2MetroTile.Click
        studyLevel = "Form 2"
        classRoom.initialize(subject, learningMaterial, studyLevel)
        classRoom.Show()
        Me.Close()
    End Sub

    Private Sub form3MetroTile_Click(sender As Object, e As EventArgs) Handles form3MetroTile.Click
        studyLevel = "Form 3"
        classRoom.initialize(subject, learningMaterial, studyLevel)
        classRoom.Show()
        Me.Close()
    End Sub

    Private Sub form4MetroTile_Click(sender As Object, e As EventArgs) Handles form4MetroTile.Click
        studyLevel = "Form 4"
        classRoom.initialize(subject, learningMaterial, studyLevel)
        classRoom.Show()
        Me.Close()
    End Sub

    Private Sub cancelMetroButton_Click(sender As Object, e As EventArgs) Handles cancelMetroButton.Click
        Me.Close()
    End Sub


End Class