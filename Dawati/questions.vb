Public Class questions

    'global variables
    Private question As String
    Private questionId As String
    Private questionType As String
    Private score As String
    Private attachment As String

    'global variables for marking
    ' Private selectedItem(100) As 

    'counters
    Private tf As Integer = 0 'trueOrFalseCounter 
    Private SS As Integer = 0 'singleSelectCounter 
    Private MS As Integer = 0 'multipleSelectCounter 
    Private OE As Integer = 0 'OpenEndedCounter 

    Private qxCordinate As Integer = 50 'questions Xcordinates
    Private aXcordinate As Integer = 27 'answers xCordinates
    ' Private aYcordinate As Integer = 31
    Private yCordinate As Integer = 30
    Private gXCordinate As Integer = 200
    'Private gYCordinate As Integer = 132

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
        ' stores the ycordinate of the answers
        Dim aYcordinate As Integer = 31


        'initializing arrays of type control
        Dim questionNo(30) As Control
        Dim questionLabel(30) As Control
        Dim trueradioButton(30) As Control
        Dim falseradioButton(30) As Control
        Dim insightLabel(30) As Control
        Dim groupBox(30) As Control
        Dim pictureBox(30) As Control

        'initializing array indexes as components
        questionLabel(tf) = New Label
        trueradioButton(tf) = New RadioButton
        falseradioButton(tf) = New RadioButton
        questionNo(tf) = New Label
        insightLabel(tf) = New Label
        groupBox(tf) = New GroupBox
        pictureBox(tf) = New PictureBox
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
        groupBox(tf).Size = New Size(201, 180)
        groupBox(tf).Location = New Point(gXCordinate, yCordinate)
        groupBox(tf).Text = ""

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

        'true radioButton properties
        trueradioButton(tf).Text = "true"
        trueradioButton(tf).Location = New Point(aXcordinate, aYcordinate)

        'increment yCordinate by 30
        aYcordinate = aYcordinate + 30

        'false radioButton properties 
        falseradioButton(tf).Text = "false"
        falseradioButton(tf).Location = New Point(aXcordinate, aYcordinate)


        'increment yCordinate by 30
        yCordinate = yCordinate + 170

        'insight label properties
        insightLabel(tf).Text = "~Answer correctly~"
        insightLabel(tf).Location = New Point(qxCordinate, yCordinate)

        'adding controls to panel
        questionsPanel.Controls.Add(questionNo(tf))
        questionsPanel.Controls.Add(questionLabel(tf))
        If attachment.Equals("") Then
            'do nothing
        Else
            questionsPanel.Controls.Add(PictureBox(tf))
        End If
        'adding radiobutons to groupbox
        groupBox(tf).Controls.Add(trueradioButton(tf))
        groupBox(tf).Controls.Add(falseradioButton(tf))
        'adding group box to questions panel
        questionsPanel.Controls.Add(groupBox(tf))

        'questionsPanel.Controls.Add(falseradioButton(tf))

        'increment ss
        tf = tf + 1

        'increment question counter
        questionCounter = questionCounter + 1


    End Sub
    Private Sub singleSelectQuestions(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
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

        'declaring arrays of controls
        Dim questionNo(30) As Control
        Dim questionLabel(30) As Control
        Dim choice1radioButton(30) As Control
        Dim choice2radioButton(30) As Control
        Dim choice3radioButton(30) As Control
        Dim choice4radioButton(30) As Control
        Dim groupBox(30) As Control
        Dim insightLabel(30) As Control
        Dim picturebox(30) As Control

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

        'question NO properties
        questionNo(SS).Text = "Question" & questionCounter
        questionNo(SS).Location = New Point(qxCordinate, yCordinate)
        questionNo(SS).Anchor = AnchorStyles.Top
        questionNo(SS).Size = New Size(300, 30)
        questionNo(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

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
        groupBox(SS).Size = New Size(201, 180)
        groupBox(SS).Location = New Point(gXCordinate, yCordinate)
        groupBox(SS).Text = ""

        'choice1radioButton properties
        choice1radioButton(SS).Text = choice(0)
        choice1radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
        choice1radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice1radioButton(SS).Size = New Size(300, 21)
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice2radioButton properties
        choice2radioButton(SS).Text = choice(1)
        choice2radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
        choice2radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice2radioButton(SS).Size = New Size(300, 21)

        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice3radioButton properties
        choice3radioButton(SS).Text = choice(2)
        choice3radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
        choice3radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice3radioButton(SS).Size = New Size(300, 21)
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice4radioButton properties
        choice4radioButton(SS).Text = choice(3)
        choice4radioButton(SS).Location = New Point(aXcordinate, aYcordinate)
        choice4radioButton(SS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice4radioButton(SS).Size = New Size(300, 21)
        'increment yCordinate by 30
        yCordinate = yCordinate + 175

        'insight label properties
        insightLabel(SS).Text = "~Answer correctly~"
        insightLabel(SS).Location = New Point(qxCordinate, yCordinate)

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

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

        questionsPanel.Controls.Add(insightLabel(SS))

        'increment ss
        SS = SS + 1

        'increment question counter
        questionCounter = questionCounter + 1


    End Sub
    Private Sub multipleSelectQuestion(ByVal question As String, ByVal questionId As String, ByVal score As String, ByVal attachment As String)
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

        'declaring arrays of controls
        Dim pictureBox(30) As Control
        Dim questionNo(30) As Control
        Dim questionLabel(30) As Control
        Dim choice1CheckBox(30) As Control
        Dim choice2CheckBox(30) As Control
        Dim choice3CheckBox(30) As Control
        Dim choice4CheckBox(30) As Control
        Dim groupBox(30) As Control
        Dim insightLabel(30) As Control

        'initializing controls
        questionNo(MS) = New Label
        questionLabel(MS) = New Label
        choice1CheckBox(MS) = New CheckBox
        choice2CheckBox(MS) = New CheckBox
        choice3CheckBox(MS) = New CheckBox
        choice4CheckBox(MS) = New CheckBox
        insightLabel(MS) = New Label
        groupBox(MS) = New GroupBox ' used for grouping radio buttons


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
        groupBox(MS).Size = New Size(201, 180)
        groupBox(MS).Location = New Point(gXCordinate, yCordinate)
        groupBox(MS).Text = ""

        'choice1CheckBox properties
        choice1CheckBox(MS).Text = choice(0)
        choice1CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
        choice1CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice1CheckBox(MS).Size = New Size(300, 21)
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice2CheckBox properties
        choice2CheckBox(MS).Text = choice(1)
        choice2CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
        choice2CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice2CheckBox(MS).Size = New Size(300, 21)
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice3CheckBox properties
        choice3CheckBox(MS).Text = choice(2)
        choice3CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
        choice3CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice3CheckBox(MS).Size = New Size(300, 21)
        'increment yCordinate by 30
        aYcordinate = aYcordinate + 23

        'choice4CheckBox properties
        choice4CheckBox(MS).Text = choice(3)
        choice4CheckBox(MS).Location = New Point(aXcordinate, aYcordinate)
        choice4CheckBox(MS).Font = New Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        choice4CheckBox(MS).Size = New Size(300, 21)
        'increment yCordinate by 30
        yCordinate = yCordinate + 185

        'insight label properties
        insightLabel(MS).Text = "~Answer correctly~"
        insightLabel(MS).Location = New Point(qxCordinate, yCordinate)

        'increment yCordinate by 30
        yCordinate = yCordinate + 30

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

        questionsPanel.Controls.Add(insightLabel(MS))

        'increment MS
        MS = SS + 1

        'increment question counter
        questionCounter = questionCounter + 1


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




End Class