Public Class questions

    'global variables
    Private question As String
    Private questionId As String
    Private questionType As String
    Private score As String
    Private attachment As String

    Public Sub initialize(ByVal exam_id As Integer)
        Dim evaluation = New evaluationForm 'evaluationForm object
        Dim dbConnect = New databaseConnection 'database object



        Me.Text = evaluation.examName

        Dim i As Integer = 0 'questions counter

        'open database connnection
        For i = 0 To i = evaluation.numQuestions
            dbConnect.sqlLiteConnection("Evaluations.db")
            Dim strSql As String = "select * from questions where exam_id ='" & exam_id & "'"
            dbConnect.selectSqlite(strSql)

            While dbConnect.reader.Read
                question = dbConnect.reader("question")
                questionId = dbConnect.reader("question_id")
                questionType = dbConnect.reader("type")
                score = dbConnect.reader("score")
                attachment = dbConnect.reader("attachment")

                'call displayQuestion method
                displayQuestion(question, questionId, questionType, score, attachment)

            End While
        Next
    End Sub

    Private Sub displayQuestion(ByVal question As String, ByVal questionId As String, ByVal questionType As String, ByVal score As String, ByVal attachment As String)
        If questionType = 1 Then

            'put in a table layout row
            ' questionsTableLayoutPanel.RowCount = questionsTableLayoutPanel.RowCount + 1


            trueFalseQuestions(question, questionId, questionType, score, attachment)
        ElseIf questionType = 2 Then
            singleSelectQuestions()
        ElseIf questionType = 3 Then
            multipleSelectQuestion()
        ElseIf questionType - 4 Then
            openEndedQuestions()
        End If
    End Sub
    Private Sub trueFalseQuestions(ByVal question As String, ByVal questionId As String, ByVal questionType As String, ByVal score As String, ByVal attachment As String)

        Dim questionLabel As New Label

        'questionLabel.Name = "question" + questionId
        questionLabel.Text = question
        questionsFlowLayoutPanel.Controls.Add(questionLabel)
        Me.questionsFlowLayoutPanel.SetFlowBreak(questionLabel, True)




        'Dim question(10) As Control
        'Dim x As Integer = 4
        'Dim y As Integer = 10
        'Dim i As Integer = 0
        'For i = 0 To 10
        '    a(i) = New Button
        '    a(i).Location = New Point(x, y)
        '    a(i).Text = "You tried" + i.ToString
        '    Me.Controls.Add(a(i))
        '    y = y + 30


        'Next

    End Sub
    Private Sub singleSelectQuestions()

    End Sub
    Private Sub multipleSelectQuestion()

    End Sub
    Private Sub openEndedQuestions()

    End Sub

    Private Sub questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'trueFalseQuestions(question, questionId, questionType, score, attachment)
    End Sub
End Class