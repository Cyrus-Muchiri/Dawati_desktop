Public Class questions

    'global variables
    Private question As String
    Private questionId As String
    Private questionType As String
    Private score As String
    Private attachment As String

    'counters
    Private tf As Integer = 0 'trueOrFalseCounter 
    Private SS As Integer = 0 'singleSelectCounter 
    Private MS As Integer = 0 'multipleSelectCounter 
    Private OE As Integer = 0 'OpenEndedCounter 

    Private qxCordinate As Integer = 50 'questions Xcordinates
    Private aXcordinate As Integer = 200 'answers xCordinates
    Private yCordinate As Integer = 30

    Private questionCounter As Integer = 1


    Public Sub initialize(ByVal exam_id As Integer, ByVal examName As String, ByVal numOfQuestions As Integer)
        Dim evaluation = New evaluationForm 'evaluationForm object
        Dim dbConnect = New databaseConnection 'database object
        ExamTitleLabel.Text = examName
        questionsPanel.AutoScroll = True


        Me.Text = examName

        Dim i As Integer = 0 'questions counter

        'open database connnection
        For i = 0 To i = numOfQuestions
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

            trueFalseQuestions(question, questionId, score, attachment)
        ElseIf questionType = 2 Then
            singleSelectQuestions(question, questionId, score, attachment)
        ElseIf questionType = 3 Then
            multipleSelectQuestion(question, questionId, score, attachment)
        ElseIf questionType = 4 Then
            openEndedQuestions(question, questionId, score, attachment)
        End If
    End Sub
    Private Sub trueFalseQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
        'initializing arrays of type control
        Dim questionNo(30) As Control
        Dim questionLabel(30) As Control
        Dim trueCheckBox(30) As Control
        Dim falseCheckBox(30) As Control
        'initializing array indexes as components
        questionLabel(tf) = New Label
        trueCheckBox(tf) = New CheckBox
        falseCheckBox(tf) = New CheckBox
        questionNo(tf) = New Label

        'question number properties

        questionNo(tf).Text = "Question" & questionCounter
        questionNo(tf).Location = New Point(qxCordinate, yCordinate)
        questionNo(tf).Anchor = AnchorStyles.Top
        questionNo(tf).Size = New Size(300, 30)
        questionNo(tf).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'questions properties
        questionLabel(tf).Text = question
        questionLabel(tf).Location = New Point(qxCordinate, yCordinate)
        questionLabel(tf).Size = New Size(500, 30)
        questionLabel(tf).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30


        'true checkbox properties
        trueCheckBox(tf).Text = "true"
        trueCheckBox(tf).Location = New Point(aXcordinate, yCordinate)

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'false checkbox properties 
        falseCheckBox(tf).Text = "false"
        falseCheckBox(tf).Location = New Point(aXcordinate, yCordinate)

        'adding controls to panel
        questionsPanel.Controls.Add(questionNo(tf))
        questionsPanel.Controls.Add(questionLabel(tf))
        questionsPanel.Controls.Add(trueCheckBox(tf))
        questionsPanel.Controls.Add(falseCheckBox(tf))

        tf = tf + 1

        'Dim trueAnswer As New CheckBox
        'trueAnswer.Text = True

        'questionLabel.Name = "question" + questionId
        'questionLabel.Text = question
        'questionsFlowLayoutPanel.Controls.Add(questionLabel)
        'Me.questionsFlowLayoutPanel.SetFlowBreak(questionLabel, True)




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
    Private Sub singleSelectQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)

    End Sub
    Private Sub multipleSelectQuestion(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)

    End Sub
    Private Sub openEndedQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
        'initializing arrays of controls
        Dim questionNo(30) As Control
        Dim questionLabel(30) As Control
        Dim richtextbox(30) As Control
        Dim insightLabel(30) As Control



        'initializing components
        questionNo(OE) = New Label
        questionLabel(OE) = New Label
        richtextbox(OE) = New RichTextBox
        insightLabel(OE) = New Label

        'question number properties

        questionNo(OE).Text = "Question" & questionCounter
        questionNo(OE).Location = New Point(qxCordinate, yCordinate)
        questionNo(OE).Anchor = AnchorStyles.Top
        questionNo(OE).Size = New Size(300, 30)
        questionNo(OE).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30


        'question properties
        questionLabel(OE).Text = question
        questionLabel(OE).Location = New Point(qxCordinate, yCordinate)
        questionLabel(OE).Anchor = AnchorStyles.Top
        questionLabel(OE).Size = New Size(800, 30)
        questionLabel(OE).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30


        'richtextbox properties
        richtextbox(OE).Location = New Point(aXcordinate, yCordinate)
        richtextbox(OE).Size = New Size(500, 60)
        richtextbox(OE).Anchor = AnchorStyles.Top

        'increment yCordinate by 30
        yCordinate = yCordinate + 103


        'insight label properties
        insightLabel(OE).Text = "~Answer correctly~"
        insightLabel(OE).Location = New Point(qxCordinate, yCordinate)


        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'adding controls to panel
        questionsPanel.Controls.Add(questionNo(OE))
        questionsPanel.Controls.Add(questionLabel(OE))
        questionsPanel.Controls.Add(richtextbox(OE))
        questionsPanel.Controls.Add(insightLabel(OE))

        'increment question counter
        questionCounter = questionCounter + 1


    End Sub

    Private Sub questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'trueFalseQuestions(question, questionId, questionType, score, attachment)
    End Sub


End Class