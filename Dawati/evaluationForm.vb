Public Class evaluationForm

    Public rowCount As Integer = 0
    Public exam_id As Integer
    Public hours As String
    Public minutes As String
    Public numQuestions As Integer
    Public examName As String
    Public subject As String
    'Public mainObject As New mainForm 'mainForm Object

    Public Sub initialize()

    End Sub
    Public Sub showExamDetails()
        Dim selectedExam As String = evaluationsListBox.SelectedItem
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("Evaluations.db")
        Dim strSql As String = "select exam_id, exam_name, hours, minutes,description,num_of_questions, subject from exams where exam_name = '" & selectedExam & "';"
        dbConnect.selectSqlite(strSql)

        While dbConnect.reader.Read
            exam_id = dbConnect.reader("exam_id")
            hours = dbConnect.reader("hours")
            numQuestions = dbConnect.reader("num_of_questions")
            minutes = dbConnect.reader("minutes")
            examName = dbConnect.reader("exam_name")

            examNameLabel.Text = examName
            subjectLabel.Text = dbConnect.reader("subject")
            descriptionLabel.Text = dbConnect.reader("description")
            noOfQuestionsLabel.Text = numQuestions
            hoursLabel.Text = hours
            hoursNameLabel.Visible = True
            minutesLabel.Text = minutes
            MinutesNameLabel.Visible = True
        End While
        questions.getter(exam_id, examName, numQuestions)

    End Sub
    Public Sub databaseReader(ByVal subject As String)

        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("Evaluations.db")
        'select questions which are not open ended
        Dim selectsql As String = "select exam_name,hours,minutes from exams where subject='" & subject & "' "
        'Dim selectsql As String = "Select exam_name,hours,minutes from exams where subject='English'"
        dbConnect.selectSqlite(selectsql)
        While dbConnect.reader.Read
            evaluationsListBox.Items.Add(dbConnect.reader("exam_name"))
        End While
        dbConnect.closeSqlite()



    End Sub


    'Public Sub trueOrFalseQuestions()
    '    'initialize components
    '    Dim varTest = New System.Windows.Forms.Label()

    'End Sub

    ''single select questions
    'Private Sub singleSelectQuestion()

    'End Sub

    ''multiple select questions
    'Private Sub multipleSelectQuestion()

    'End Sub
    ''open ended questions
    'Public Sub openEndedQuestion()

    'End Sub



    Private Sub evaluationsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles evaluationsListBox.SelectedIndexChanged
        showExamDetails()
    End Sub

    Private Sub startMetroTile_Click(sender As Object, e As EventArgs) Handles startMetroTile.Click
        questions.initialize(exam_id, examName, numQuestions)
        questions.MdiParent = dawatiParent
        Me.Hide()
        questions.Show()
        questions.WindowState = FormWindowState.Maximized

        Close()
    End Sub

    Private Sub evaluationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        mainForm.MdiParent = dawatiParent
        mainForm.WindowState = FormWindowState.Maximized
        mainForm.Show()
    End Sub
End Class