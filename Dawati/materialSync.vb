Imports System.Net
Imports System.IO
Imports System.Net.WebClient.dowloadFile

Public Class materialSync
    'dbConnect is an object of database connection

    'global variables

    Public result As DialogResult ' stores dialog result from checkConnection method
    Public count As Integer = 0 ' has 0 if no occurence of the file in database, else >0
    Private Shared newFields(60000) As Integer  '


    'checks internet connectivity
    Public Sub checkConnection()
        Dim connection As Boolean

        'send web request
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    If client.IsBusy Then 'times out
                        connection = False
                    End If

                    connection = True
                End Using
            End Using
        Catch
            connection = False
        End Try

        If connection = True Then
            result = MessageBox.Show("Internet Connection detected. Do you want to sync videos from dawati server?", "Internet Connection", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            'ElseIf connection = False Then
        End If


        If result = DialogResult.Yes Then
            writeMaterialDetails()
            syncEvaluations()
            counter()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    'connect to remote sever and write details about the learning materials
    Public Sub writeMaterialDetails()
        ' stores data from remote database
        Dim file_name, file_type, target, study_level As String
        Dim file_id, num_slides, multimedia_series, multimedia_type As Integer
        Dim count As Integer = 0
        Dim dbConnect = New databaseConnection 'object
        dbConnect.dbConnection()
        'get data from remote server
        Dim strSql As String = "Select * FROM multimedia_content ORDER BY file_id ASC"
        dbConnect.selectMySql(strSql)

        While dbConnect.MySqlReader.Read
            file_id = dbConnect.MySqlReader("file_id")
            file_name = dbConnect.MySqlReader("file_name")
            file_type = dbConnect.MySqlReader("file_type")
            target = dbConnect.MySqlReader("target")
            'num_slides = dbConnect.MySqlReader("num_slides")
            multimedia_series = dbConnect.MySqlReader("multimedia_series")
            multimedia_type = dbConnect.MySqlReader("multimedia_type")
            study_level = dbConnect.MySqlReader("study_level")

            'check for existing content in local database
            dbConnect.sqlLiteConnection("multimedia.db")
            Try
                'sql string
                Dim selectStrSql = "select file_id from multimedia_content where file_id ='" & file_id & "'"
                dbConnect.selectSqlite(selectStrSql) 'call method selectSqlite and pass sql string as parameter

                If dbConnect.reader.HasRows Then
                    'do nothing
                Else
                    'add counter
                    count = count + 1
                    'record doesn't exist
                    Dim insertstrSql As String = "Insert into multimedia_content (file_id,file_name,file_type,target,num_slides,multimedia_series,
                    multimedia_type,study_level ) VALUES( '" & file_id & "','" & file_name & "','" & file_type & "','" & target & "','" & num_slides & "',
                    '" & multimedia_series & "','" & multimedia_type & "','" & study_level & "') "
                    'download said video
                    downloadVideos(file_name)
                    dbConnect.insertSqlite(insertstrSql)
                    dbConnect.closeSqlite()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End While
        dbConnect.closeDbConnection() 'close connection


    End Sub

    Private Sub downloadVideos(file_name)
        If (File.Exists("https://www.dawati.co.ke/uploads/multimedia/content/video/Biology/" & file_name & "")) Then
            MessageBox.Show("You are lucky mf")
            'My.Computer.Network.DownloadFile("https://dawati.co.ke/uploads/")
        Else
            MessageBox.Show("unlucky bro")


        End If
    End Sub

    Private Sub sendAnalytics()

    End Sub
    ' syncs new evaluation from the internet
    Private Sub syncEvaluations()
        Dim dbconnect As New databaseConnection
        dbconnect.dbConnection()
        'select statements from remote
        Dim examsStrSql As String = "select * from exams;"
        Dim questionsStrSql As String = "select * from questions;"
        Dim questionAnswersSql As String = "select * from question_answers;"
        Dim questionTypeSql As String = "select * from question_type"

        'read and write to variables

        'exams
        dbconnect.selectMySql(examsStrSql)
        'read while write into sqlite database
        dbconnect.sqlLiteConnection("Evaluations.db")
        While dbconnect.MySqlReader.Read



            Dim examId As Integer = dbconnect.MySqlReader("exam_id")
            Dim examName As String = dbconnect.MySqlReader("exam_name")
            Dim subject As String = dbconnect.MySqlReader("subject")
            ' Dim studyLevel As String = dbconnect.MySqlReader("")
            Dim description As String = dbconnect.MySqlReader("description")
            Dim numOfQuestions As Integer = dbconnect.MySqlReader("num_of_questions")
            Dim hours As Integer = dbconnect.MySqlReader("hours")
            Dim minutes As Integer = dbconnect.MySqlReader("minutes")
            Dim dateCreated As String = dbconnect.MySqlReader("date_created")

            'check if record exists

            Dim existsStrSql As String = "select exam_id from exams where exam_id ='" & examId & "'"
            dbconnect.selectSqlite(existsStrSql)

            If dbconnect.reader.HasRows Then
                'do nothing
            Else
                Dim insertExamsSql As String = "insert into exams(exam_id, exam_name,subject,description,num_of_questions,hours,minutes)values
                ('" & examId & "','" & examName & "','" & subject & "','" & description & "','" & numOfQuestions & "','" & hours & "','" & minutes & "');"


                dbconnect.insertSqlite(insertExamsSql)

                count = count + 1
                dbconnect.reader.Close()
            End If


        End While
        'dbconnect.closeSqlite()
        dbconnect.MySqlReader.Dispose()

        'questions
        dbconnect.selectMySql(questionsStrSql)
        'read while write into sqlite database
        While dbconnect.MySqlReader.Read

            Dim questionId As Integer = dbconnect.MySqlReader("question_id")
            Dim question As String = dbconnect.MySqlReader("question")
            Dim type As String = dbconnect.MySqlReader("type")
            ' Dim studyLevel As String = dbconnect.MySqlReader("")
            Dim score As String = dbconnect.MySqlReader("score")
            ' Dim date_updated As String = dbconnect.MySqlReader("date_updated").ToString
            Dim examId As Integer = dbconnect.MySqlReader("exam_id")
            Dim attachment As String = dbconnect.MySqlReader("attachment")
            'Dim numOfAnswers As String = dbconnect.MySqlReader("num_answers")

            'check if file exists
            Dim existsStrSql As String = "select question_id from questions where question_id ='" & questionId & "'"
            dbconnect.selectSqlite(existsStrSql)


            If dbconnect.reader.HasRows Then
                'do nothing
            Else
                Dim insertQuestionsSql As String = "insert into questions(question_id, question,type,score,exam_id,attachment)values
                ('" & questionId & "','" & question & "','" & type & "','" & score & "','" & examId & "','" & attachment & "');"


                dbconnect.insertSqlite(insertQuestionsSql)

                count = count + 1
                dbconnect.reader.Close()
            End If


        End While
        'dbconnect.closeSqlite()
        dbconnect.MySqlReader.Dispose()





        'question answers
        dbconnect.selectMySql(questionAnswersSql)
        'read while write into sqlite database
        While dbconnect.MySqlReader.Read

            Dim choiceId As Integer = dbconnect.MySqlReader("choice_id")
            Dim choice As String = dbconnect.MySqlReader("choice")
            Dim status As String = dbconnect.MySqlReader("status")
            Dim questionId As String = dbconnect.MySqlReader("question_id")


            'check if file exists
            Dim existsStrSql As String = "select choice_id from question_answers where choice_id ='" & choiceId & "'"
            dbconnect.selectSqlite(existsStrSql)


            If dbconnect.reader.HasRows Then
                'do nothing
            Else
                Dim insertQuestionAnswersSql As String = "insert into question_answers(choice_id, choice,status,question_id)values
                ('" & choiceId & "','" & choice & "','" & status & "','" & questionId & "');"


                dbconnect.insertSqlite(insertQuestionAnswersSql)

                count = count + 1
                dbconnect.reader.Close()
            End If

        End While
        'dbconnect.closeSqlite()
        dbconnect.MySqlReader.Dispose()

        'question type
        dbconnect.selectMySql(questionTypeSql)
        'read while write into sqlite database
        While dbconnect.MySqlReader.Read
            Dim Id As Integer = dbconnect.MySqlReader("id")
            Dim name As String = dbconnect.MySqlReader("name")



            'check if file exists
            Dim existsStrSql As String = "select id from question_type where id ='" & Id & "'"
            dbconnect.selectSqlite(existsStrSql)


            If dbconnect.reader.HasRows Then
                'do nothing
            Else
                Dim insertQuestionTypeSql As String = "insert into question_type(id, name)values
                ('" & Id & "','" & name & "');"


                dbconnect.insertSqlite(insertQuestionTypeSql)

                count = count + 1
                dbconnect.reader.Close()
            End If


        End While
        'dbconnect.closeSqlite()
        dbconnect.MySqlReader.Dispose()


    End Sub
    Private Sub counter()
        If count = 0 Then
            MessageBox.Show("Your videos,ebooks and evaluations are up to date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf count > 0 Then
            MessageBox.Show("" & count & " entries will be added to your offline base", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

End Class
