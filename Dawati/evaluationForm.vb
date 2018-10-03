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
    Private Sub showExamDetails()
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
    End Sub
    Public Sub databaseReader(ByVal subject As String)

        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("Evaluations.db")
        Dim selectsql As String = "select exam_name,hours,minutes from exams where subject='" & subject & "'"
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
        questions.initialize(exam_id)
        questions.Show()
    End Sub


End Class