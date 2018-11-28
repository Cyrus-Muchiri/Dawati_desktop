Public Class attemptReports



    'users variables
    Private userid As Integer
    'initializing arrays of type control
    Private questionNo(30) As Label

    'global variables
    Private question As String
        Private questionId As String
        Private questionType As String
        Private score As String
        Private attachment As String


        'global variables for marking
        ' Private correctAnswer(100) As Label
        ' Private selectedItem(100) As 

        'counters
        Private tf As Integer = 0 'trueOrFalseCounter 
        Private SS As Integer = 0 'singleSelectCounter 
        Private MS As Integer = 0 'multipleSelectCounter 
        Private OE As Integer = 0 'OpenEndedCounter 
        Private CA As Integer = 0 ' marker counter

        Private qxCordinate As Integer = 50 'questions Xcordinates
        Private aXcordinate As Integer = 27 'answers xCordinates
        ' Private aYcordinate As Integer = 31
        Private yCordinate As Integer = 30
        Private gXCordinate As Integer = 200
        'Private gYCordinate As Integer = 132

        Private questionCounter As Integer = 1
    Private obj As New questions

    Public Sub getUserId(ByVal userId As Integer)
        Me.userid = userId
    End Sub

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

                    ''store answer values if question type is 2 or 3
                    'If questionType = 2 Or questionType = 3 Then
                    '    choice1 = dbConnect.reader("")
                    '    choice1 = dbConnect.reader("")
                    '    choice1 = dbConnect.reader("")
                    '    choice1 = dbConnect.reader("")
                    'End If

                    'call displayQuestion method
                    displayQuestion(question, questionId, questionType, score, attachment)

                End While
            Next
        End Sub

    Private Sub displayQuestion(ByVal question As String, ByVal questionId As String, ByVal questionType As String, ByVal score As String, ByVal attachment As String)
        If questionType = 1 Then
            '  MessageBox.Show(obj.userChoices(0, 0))
            trueFalseQuestions(question, questionId, score, attachment)
        ElseIf questionType = 2 Then
            singleSelectQuestions(question, questionId, score, attachment)
        ElseIf questionType = 3 Then
            multipleSelectQuestion(question, questionId, score, attachment)
        ElseIf questionType = 4 Then
            'openEndedQuestions(question, questionId, score, attachment)
        End If
    End Sub

    ' this function will return the answer, as string, the specified user returned for a particular string
    Private Function showSelectedAnswer(ByVal questionId As Integer, ByVal userId As Integer) As String
        Dim dbConnect As New databaseConnection
        'local variable to store choice
        Dim choice As String = ""
        dbConnect.sqlLiteConnection("Evaluations.db")
        Dim strSql As String = " Select choice from respondent_attempts where question_id='" & questionId & "'  AND user_id='" & userId & "'"
        dbConnect.selectSqlite(strSql)
        While dbConnect.reader.Read
            choice = dbConnect.reader("choice")
        End While

        Return Choice
    End Function
    Private Sub trueFalseQuestions(ByVal question As String, ByVal questionId As String, ByVal score As Integer, ByVal attachment As String)
        'local variable to store users answer
        Dim myChoice = showSelectedAnswer(questionId, userid)


        ' stores the ycordinate of the answers
        Dim aYcordinate As Integer = 31


        ''initializing arrays of type control
        Dim questionLabel(30) As Label
        Dim trueradioButton(30) As RadioButton
        Dim falseradioButton(30) As RadioButton
        Dim insightLabel(30) As Label
        Dim groupBox(30) As GroupBox
        Dim pictureBox(30) As PictureBox
        Dim correctAnswer(30) As Label
        Dim statusPanel(30) As Panel
        Dim scorelabel(30) As Label
        Dim statuslabel(30) As Label ' store correct or wrong  variables
        Dim correctAnswerlabel(30) As Label

        'initializing array indexes as components
        questionLabel(tf) = New Label
        trueradioButton(tf) = New RadioButton
        falseradioButton(tf) = New RadioButton
        questionNo(tf) = New Label
        insightLabel(tf) = New Label
        groupBox(tf) = New GroupBox
        pictureBox(tf) = New PictureBox
        statuslabel(tf) = New Label
        scorelabel(tf) = New Label
        statusPanel(tf) = New Panel
        correctAnswerlabel(tf) = New Label

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
        questionLabel(tf).Size = New Size(500, 60)
        questionLabel(tf).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'checks for attachments
        If attachment.Equals("") Then
            'do nothing/ skip attachments
        Else
            'picture properties
            pictureBox(tf).Size = New Size(617, 197)
            pictureBox(tf).Location = New Point(qxCordinate, yCordinate)
            pictureBox(tf).BackgroundImage = Image.FromFile("assets\question_attachments\" & attachment & "")
            pictureBox(tf).BackgroundImageLayout = ImageLayout.Center

            'increment ycordinate
            yCordinate = yCordinate + 200
        End If

        'group box properties
        groupBox(tf).Size = New Size(201, 80)
        groupBox(tf).Location = New Point(gXCordinate, yCordinate)
        groupBox(tf).Text = ""

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'true radioButton properties
        trueradioButton(tf).Text = "true"
        Dim trueRBtext As String = trueradioButton(tf).Text 'RB stands for radiobutton
        trueradioButton(tf).Location = New Point(aXcordinate, aYcordinate)
        If myChoice = trueRBtext Then
            trueradioButton(tf).Checked = True
        End If

        'increment yCordinate by 30
        aYcordinate = aYcordinate + 30

        'false radioButton properties 
        falseradioButton(tf).Text = "false"
        Dim falseRBtext As String = falseradioButton(tf).Text
        falseradioButton(tf).Location = New Point(aXcordinate, aYcordinate)
        If myChoice = falseRBtext Then
            falseradioButton(tf).Checked = True
        End If

        'increment yCordinate by 80, size of groupbox
        yCordinate = yCordinate + 80
        '-----------------------------------------------------------'
        'Section to Show whether the user answered correctly or not '
        '---------------------------------------------------------- '
        Dim status As String = markingQuestions(questionId, myChoice)
        'status panel and its component
        'status panel


        statusPanel(tf).Size = New Size(1000, 80)
        statusPanel(tf).Name = "statuspanel"
        statusPanel(tf).Margin = New Padding(4)
        statusPanel(tf).Location = New Point(qxCordinate, yCordinate)
        If status = "Correct" Then
            statusPanel(tf).BackColor = Color.FromArgb(112, 219, 112)


        ElseIf status = "Incorrect" Then
            statusPanel(tf).BackColor = Color.FromArgb(255, 102, 102)
        Else
            statusPanel(tf).BackColor = Color.FromArgb(153, 77, 0)
        End If

        'staus label
        Dim ycord = 50
        statuslabel(tf).Location = New Point(34, 10)
        If status = "Correct" Then
            statuslabel(tf).Text = "correct"

        ElseIf status = "Incorrect" Then
            statuslabel(tf).Text = "incorrect"
            'correctanswer label
            ycord = 35
            correctAnswerlabel(tf).Text = "Correct answer : " & correctAnswers(questionId)
            correctAnswerlabel(tf).Location = New Point(34, ycord)
            ycord += 20
        Else
            statuslabel(tf).Text = "The answer to this question is not provided"
            statuslabel(tf).Size = New Size(500, 20)
        End If
        'score label
        If status = "Correct" Then
            scorelabel(tf).Text = score & "  marks"

        Else
            scorelabel(tf).Text = 0 & "  marks"
            statusPanel(tf).Controls.Add(correctAnswerlabel(tf))
        End If

        scorelabel(tf).Location = New Point(34, ycord)

        'add items to status panel
        statusPanel(tf).Controls.Add(statuslabel(tf))
        statusPanel(tf).Controls.Add(scorelabel(tf))
        statusPanel(tf).Controls.Add(correctAnswerlabel(tf))

        '----------------
        'end status panel
        '----------------



        'increment yCordinate by 30
        yCordinate = yCordinate + 95

        'adding controls to panel
        questionsPanel.Controls.Add(questionNo(tf))
        questionsPanel.Controls.Add(questionLabel(tf))
        If attachment.Equals("") Then
            'do nothing
        Else
            questionsPanel.Controls.Add(pictureBox(tf))
        End If
        'adding radiobutons to groupbox
        groupBox(tf).Controls.Add(trueradioButton(tf))
        groupBox(tf).Controls.Add(falseradioButton(tf))

        'groupBox(tf).Controls.Add(correctAnswer(tf))
        'adding group box to questions panel
        questionsPanel.Controls.Add(groupBox(tf))
        questionsPanel.Controls.Add(statusPanel(tf))


        'increment ss
        tf = tf + 1

        'increment question counter
        questionCounter = questionCounter + 1


    End Sub
    Private Sub singleSelectQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)

        'select answers and strore them in variables
        '-------------------------------------------
        Dim myChoice = showSelectedAnswer(questionId, userid)

        ' stores the ycordinate of the answers
        Dim aYcordinate As Integer = 31

        'array of choices
        Dim choice(4) As String

            'select questions from database
            Dim dbConnect As New databaseConnection
            dbConnect.sqlLiteConnection("Evaluations.db")
            'choice array counters
            Dim counter As Integer = 0
            Dim strSql As String = "select choice from question_answers where question_id ='" & questionId & "'"
            dbConnect.selectSqlite(strSql)
            While dbConnect.reader.Read
            choice(counter) = dbConnect.reader("choice") 'brilliant
            counter = counter + 1
            End While

            'declaring arrays of controls
            Dim questionNo(30) As Control
            Dim questionLabel(30) As Control
            Dim choice1radioButton(30) As RadioButton
            Dim choice2radioButton(30) As RadioButton
            Dim choice3radioButton(30) As RadioButton
            Dim choice4radioButton(30) As RadioButton
            Dim groupBox(30) As Control
            Dim insightLabel(30) As Control
            Dim picturebox(30) As Control
        Dim statusPanel(30) As Panel
        Dim scorelabel(30) As Label
        Dim statuslabel(30) As Label ' store correct or wrong  variables
        Dim correctAnswerlabel(30) As Label

        'initializing controls
        questionNo(SS) = New Label
            questionLabel(SS) = New Label
            choice1radioButton(SS) = New RadioButton
            choice2radioButton(SS) = New RadioButton
            choice3radioButton(SS) = New RadioButton
            choice4radioButton(SS) = New RadioButton
            insightLabel(SS) = New Label
            groupBox(SS) = New GroupBox ' used for grouping radio buttons
            picturebox(SS) = New PictureBox
        statusPanel(SS) = New Panel
        scorelabel(SS) = New Label
        statuslabel(SS) = New Label
        correctAnswerlabel(SS) = New Label


        'question NO properties
        questionNo(SS).Text = "Question" & questionCounter
            questionNo(SS).Location = New Point(qxCordinate, yCordinate)
            questionNo(SS).Anchor = AnchorStyles.Top
            questionNo(SS).Size = New Size(300, 30)
            questionNo(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'handling check changed events and calling marker
            '-----------------------------------------------
            Dim choice1 = choice1radioButton(SS).Text
            Dim choice2 = choice2radioButton(SS).Text
            Dim choice3 = choice3radioButton(SS).Text
            Dim choice4 = choice4radioButton(SS).Text

        'end
        '-------------------------------
        'increment yCordinate by 30
        yCordinate = yCordinate + 30

            'question properties
            questionLabel(SS).Text = question
            questionLabel(SS).Location = New Point(qxCordinate, yCordinate)
            questionLabel(SS).Anchor = AnchorStyles.Top
            questionLabel(SS).Size = New Size(800, 60)
            questionLabel(SS).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

            If attachment.Equals("") Then
                'do nothing/ skip attachments
            Else
                'picture properties
                picturebox(SS).Size = New Size(617, 197)
                picturebox(SS).Location = New Point(qxCordinate, yCordinate)
                picturebox(SS).BackgroundImage = Image.FromFile("assets\question_attachments\" & attachment & "")
                picturebox(SS).BackgroundImageLayout = ImageLayout.Center

                'increment ycordinate
                yCordinate = yCordinate + 200
            End If

        'group box properties
        groupBox(SS).Size = New Size(1000, 120)
        groupBox(SS).Location = New Point(gXCordinate, yCordinate)
            groupBox(SS).Text = ""

            'choice1radioButton properties
            choice1radioButton(SS).Text = choice(0)
            choice1radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
            choice1radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice1radioButton(SS).Size = New Size(800, 21)
        Dim choice1Text As String = choice1radioButton(SS).Text
        If myChoice = choice1Text Then
            choice1radioButton(SS).Checked = True

        End If


        aYcordinate = aYcordinate + 21

        'choice2radioButton properties
        choice2radioButton(SS).Text = choice(1)
            choice2radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
            choice2radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice2radioButton(SS).Size = New Size(800, 21)
        Dim choice2Text As String = choice2radioButton(SS).Text
        If myChoice = choice2Text Then
            choice2radioButton(SS).Checked = True

        End If

        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

            'choice3radioButton properties
            choice3radioButton(SS).Text = choice(2)
            choice3radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
            choice3radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice3radioButton(SS).Size = New Size(800, 21)
        'check user selected answer
        Dim choice3Text As String = choice3radioButton(SS).Text
        If myChoice = choice3Text Then
            choice3radioButton(SS).Checked = True

        End If
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

            'choice4radioButton properties
            choice4radioButton(SS).Text = choice(3)
            choice4radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
            choice4radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice4radioButton(SS).Size = New Size(500, 21)
        'check user selected answer
        Dim choice4Text As String = choice4radioButton(SS).Text
        If myChoice = choice4Text Then
            choice4radioButton(SS).Checked = True

        End If
        'increment yCordinate by 180
        yCordinate = yCordinate + 120

        '-----------------------------------------------------------'
        'Section to Show whether the user answered correctly or not '
        '---------------------------------------------------------- '
        Dim status As String = markingQuestions(questionId, myChoice)
        'status panel and its component
        'status panel


        statusPanel(SS).Size = New Size(1000, 80)
        statusPanel(SS).Name = "statuspanel"
        statusPanel(SS).Margin = New Padding(4)
        statusPanel(SS).Location = New Point(qxCordinate, yCordinate)
        If status = "Correct" Then
            statusPanel(SS).BackColor = Color.FromArgb(112, 219, 112)


        ElseIf status = "Incorrect" Then
            statusPanel(SS).BackColor = Color.FromArgb(255, 102, 102)
        Else
            statusPanel(SS).BackColor = Color.FromArgb(153, 77, 0)
        End If

        'staus label
        'staus label
        Dim ycord = 10

        If status = "Correct" Then
            statuslabel(SS).Text = "correct"

        ElseIf status = "Incorrect" Then
            statuslabel(SS).Text = "incorrect"
            statuslabel(SS).Location = New Point(34, ycord)
            correctAnswerlabel(SS).Location = New Point(34, ycord)
            'correctanswer label
            ycord += 21
            Dim answer As String = correctAnswers(questionId) ' will store the correct answer of the particular question
            correctAnswerlabel(SS).Text = "Correct answer : " & answer
            correctAnswerlabel(SS).Size = New Size(700, 21)
            correctAnswerlabel(SS).Location = New Point(34, ycord)

        Else
            statuslabel(SS).Text = "The answer to this question is not provided"
            statuslabel(SS).Size = New Size(500, 21)
        End If
        'score label
        If status = "Correct" Then
            statuslabel(SS).Text = "correct"

        Else
            statuslabel(SS).Text = "incorrect"
        End If
        'score label
        ycord += 25
        If status = "Correct" Then
            scorelabel(SS).Text = score & "  marks"

        Else
            scorelabel(SS).Text = 0 & "  marks"
            ' statusPanel(SS).Controls.Add(correctAnswerlabel(SS))
        End If
        scorelabel(SS).Location = New Point(34, ycord)

        'add items to status panel
        statusPanel(SS).Controls.Add(statuslabel(SS))
        statusPanel(SS).Controls.Add(scorelabel(SS))
        statusPanel(SS).Controls.Add(correctAnswerlabel(SS))
        '----------------
        'end status panel
        '----------------



        'increment yCordinate by 30
        yCordinate = yCordinate + 90

        'adding controls to panel
        questionsPanel.Controls.Add(questionNo(SS))
            questionsPanel.Controls.Add(questionLabel(SS))

            If attachment.Equals("") Then
                'do nothing
            Else
                questionsPanel.Controls.Add(picturebox(SS))
            End If



            'adding radio buttons to groupbox

            groupBox(SS).Controls.Add(choice1radioButton(SS))
            groupBox(SS).Controls.Add(choice2radioButton(SS))
            groupBox(SS).Controls.Add(choice3radioButton(SS))
            groupBox(SS).Controls.Add(choice4radioButton(SS))


        questionsPanel.Controls.Add(groupBox(SS))

        questionsPanel.Controls.Add(statusPanel(SS))

        'increment ss
        SS = SS + 1

            'increment question counter
            questionCounter = questionCounter + 1



        End Sub
        Private Sub multipleSelectQuestion(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
        'users choice
        Dim myChoice As String = ""
        myChoice = showSelectedAnswer(questionId, userid)

        ' stores the ycordinate of the answers
        Dim aYcordinate As Integer = 31

            'select answers and strore them in variables
            '-------------------------------------------

            'array of choices
            Dim choice(4) As String

            'select questions from database
            Dim dbConnect As New databaseConnection
            dbConnect.sqlLiteConnection("Evaluations.db")
            'choice array counters
            Dim counter As Integer = 0
            Dim strSql As String = "select choice from question_answers where question_id ='" & questionId & "'"
            dbConnect.selectSqlite(strSql)
            While dbConnect.reader.Read
                choice(counter) = dbConnect.reader("choice")
                counter = counter + 1
            End While

            'declaring variables for answers 
            Dim correctAnswer(100)
            'declaring arrays of controls
            Dim pictureBox(30) As Control
            Dim questionNo(30) As Control
            Dim questionLabel(30) As Control
        Dim choice1CheckBox(30) As CheckBox
        Dim choice2CheckBox(30) As CheckBox
        Dim choice3CheckBox(30) As CheckBox
        Dim choice4CheckBox(30) As CheckBox
        Dim groupBox(30) As Control
        Dim statusPanel(30) As Panel
        Dim scorelabel(30) As Label
        Dim statuslabel(30) As Label ' store correct or wrong  variables
        Dim correctAnswerlabel(30) As Label ' stores correct answer after marking

        'initializing controls
        questionNo(MS) = New Label
            questionLabel(MS) = New Label
            choice1CheckBox(MS) = New CheckBox
            choice2CheckBox(MS) = New CheckBox
            choice3CheckBox(MS) = New CheckBox
            choice4CheckBox(MS) = New CheckBox
        statusPanel(MS) = New Panel
        scorelabel(MS) = New Label
        statuslabel(MS) = New Label
        groupBox(MS) = New GroupBox ' used for grouping radio buttons
        correctAnswerlabel(MS) = New Label

        pictureBox(MS) = New PictureBox

            'question NO properties
            questionNo(MS).Text = "Question" & questionCounter
            questionNo(MS).Location = New Point(qxCordinate, yCordinate)
            questionNo(MS).Anchor = AnchorStyles.Top
            questionNo(MS).Size = New Size(300, 30)
            questionNo(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'increment yCordinate by 30
            yCordinate = yCordinate + 30

            'question properties
            questionLabel(MS).Text = question
            questionLabel(MS).Location = New Point(qxCordinate, yCordinate)
            questionLabel(MS).Anchor = AnchorStyles.Top
            questionLabel(MS).Size = New Size(800, 60)
            questionLabel(MS).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'increment yCordinate by 30
            yCordinate = yCordinate + 50
            If attachment.Equals("") Then
                'do nothing/ skip attachments
            Else
                'picture properties
                pictureBox(MS).Size = New Size(617, 197)
                pictureBox(MS).Location = New Point(qxCordinate, yCordinate)
                pictureBox(MS).BackgroundImage = Image.FromFile("assets\question_attachments\" & attachment & "")
                pictureBox(MS).BackgroundImageLayout = ImageLayout.Center

                'increment ycordinate
                yCordinate = yCordinate + 200
            End If

        'group box properties
        groupBox(MS).Size = New Size(1000, 150)
        groupBox(MS).Location = New Point(gXCordinate, yCordinate)
            groupBox(MS).Text = ""

            'choice1CheckBox properties
            choice1CheckBox(MS).Text = choice(0)
            choice1CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
            choice1CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice1CheckBox(MS).Size = New Size(700, 21)


        'check user selected answer
        Dim choice1Text As String = choice1CheckBox(MS).Text
        If myChoice = choice1Text Then
            choice1CheckBox(MS).Checked = True
            choice1CheckBox(MS).CheckState = CheckState.Checked

        End If

        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice2CheckBox properties
        choice2CheckBox(MS).Text = choice(1)
            choice2CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
            choice2CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice2CheckBox(MS).Size = New Size(700, 21)

        'check user selected answer
        Dim choice2Text As String = choice2CheckBox(MS).Text
        If myChoice = choice2Text Then
            choice2CheckBox(MS).Checked = True
            choice2CheckBox(MS).CheckState = CheckState.Checked

        End If
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23


        'choice3CheckBox properties
        choice3CheckBox(MS).Text = choice(2)
            choice3CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
            choice3CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice3CheckBox(MS).Size = New Size(700, 21)

        'check user selected answer
        Dim choice3Text As String = choice3CheckBox(MS).Text
        If myChoice = choice3Text Then
            choice3CheckBox(MS).Checked = True
            choice3CheckBox(MS).CheckState = CheckState.Checked

        End If
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23


        'choice4CheckBox properties
        choice4CheckBox(MS).Text = choice(3)
            choice4CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
            choice4CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice4CheckBox(MS).Size = New Size(700, 21)
        'check user selected answer
        Dim choice4Text As String = choice4CheckBox(MS).Text
        If myChoice = choice4Text Then
            choice4CheckBox(MS).Checked = True
            choice4CheckBox(MS).CheckState = CheckState.Checked

        End If
        'increment yCordinate by 180
        yCordinate = yCordinate + 150

        '-----------------------------------------------------------'
        'Section to Show whether the user answered correctly or not '
        '---------------------------------------------------------- '
        Dim status As String = markingQuestions(questionId, myChoice)
        'status panel and its component
        'status panel


        statusPanel(MS).Size = New Size(1000, 80)
        statusPanel(MS).Name = "statuspanel"
        statusPanel(MS).Margin = New Padding(4)
        statusPanel(MS).Location = New Point(qxCordinate, yCordinate)
        If status = "Correct" Then
            statusPanel(MS).BackColor = Color.FromArgb(112, 219, 112)


        ElseIf status = "Incorrect" Then
            statusPanel(MS).BackColor = Color.FromArgb(255, 102, 102)
        Else
            statusPanel(MS).BackColor = Color.FromArgb(153, 77, 0)
        End If

        'staus label
        'staus label
        Dim ycord = 10

        If status = "Correct" Then
            statuslabel(MS).Text = "correct"

        ElseIf status = "Incorrect" Then
            statuslabel(MS).Text = "incorrect"
            statuslabel(MS).Location = New Point(34, ycord)
            correctAnswerlabel(MS).Location = New Point(34, ycord)
            'correctanswer label
            ycord += 21
            Dim answer As String = correctAnswers(questionId) ' will store the correct answer of the particular question
            correctAnswerlabel(MS).Text = "Correct answer : " & answer
            correctAnswerlabel(MS).Size = New Size(700, 21)
            correctAnswerlabel(MS).Location = New Point(34, ycord)

        Else
            statuslabel(MS).Text = "The answer to this question is not provided"
            statuslabel(MS).Size = New Size(500, 21)
        End If
        'score label
        If status = "Correct" Then
            statuslabel(MS).Text = "correct"

        Else
            statuslabel(MS).Text = "incorrect"
        End If
        'score label
        ycord += 25
        If status = "Correct" Then
            scorelabel(MS).Text = score & "  marks"

        Else
            scorelabel(MS).Text = 0 & "  marks"
            ' statusPanel(MS).Controls.Add(correctAnswerlabel(MS))
        End If
        scorelabel(MS).Location = New Point(34, ycord)

        'add items to status panel
        statusPanel(MS).Controls.Add(statuslabel(MS))
        statusPanel(MS).Controls.Add(scorelabel(MS))
        statusPanel(MS).Controls.Add(correctAnswerlabel(MS))
        '----------------
        'end status panel
        '----------------


        'increment yCordinate by 30
        yCordinate = yCordinate + 90

        'adding controls to panel

        questionsPanel.Controls.Add(questionNo(MS))
            questionsPanel.Controls.Add(questionLabel(MS))
            If attachment.Equals("") Then
                'do nothing
            Else
                questionsPanel.Controls.Add(pictureBox(MS))
            End If
            'adding radio buttons to groupbox
            groupBox(MS).Controls.Add(choice1CheckBox(MS))
            groupBox(MS).Controls.Add(choice2CheckBox(MS))
            groupBox(MS).Controls.Add(choice3CheckBox(MS))
            groupBox(MS).Controls.Add(choice4CheckBox(MS))

            questionsPanel.Controls.Add(groupBox(MS))

        questionsPanel.Controls.Add(statusPanel(MS))



        'increment question counter
        questionCounter = questionCounter + 1
            'getting selected answer


            'increment MS
            MS = MS + 1

        End Sub
        Private Sub openEndedQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
            'declaring arrays of controls
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
            questionLabel(OE).Size = New Size(800, 60)
            questionLabel(OE).Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'increment yCordinate by 30
            yCordinate = yCordinate + 60


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

    Public Function markingQuestions(ByVal questionId, ByVal choice) As String
        Dim status As String
        Dim dbconnect As databaseConnection = New databaseConnection
        dbconnect.sqlLiteConnection("Evaluations.db")
        Dim strSql As String = "SELECT status from question_answers where question_id='" & questionId & "' AND choice='" & choice & "'"
        dbconnect.selectSqlite(strSql)

        While dbconnect.reader.Read
            status = dbconnect.reader("status")
        End While
        dbconnect.closeSqlite()
        Return status
    End Function
    Public Function correctAnswers(ByVal questionId As String) As String
        Dim correctChoice As String = ""
        Dim dbconnect As databaseConnection = New databaseConnection
        dbconnect.sqlLiteConnection("Evaluations.db")
        Dim strSql As String = "SELECT choice from question_answers where question_id='" & questionId & "' AND status='Correct'"
        dbconnect.selectSqlite(strSql)

        While dbconnect.reader.Read
            correctChoice = dbconnect.reader("choice")
        End While
        dbconnect.closeSqlite()
        Return correctChoice
    End Function

    'Public Function correctAnswersMS(ByVal questionId As String) As String()
    '    Dim correctChoice(4) As String
    '    Dim dbconnect As databaseConnection = New databaseConnection
    '    dbconnect.sqlLiteConnection("Evaluations.db")
    '    Dim strSql As String = "SELECT choice from question_answers where question_id='" & questionId & "' AND status='Correct'"
    '    dbconnect.selectSqlite(strSql)
    '    Dim count As Integer = 0
    '    While dbconnect.reader.Read
    '        correctChoice(count) = dbconnect.reader("choice")
    '        count += 1
    '    End While
    '    dbconnect.closeSqlite()
    '    Return correctChoice(4)

    'End Function


End Class
