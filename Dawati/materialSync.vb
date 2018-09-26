Imports System.Net
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

                    dbConnect.insertSqlite(insertstrSql)
                    dbConnect.closeSqlite()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End While
        If count = 0 Then
            MessageBox.Show("Your videos and ebooks are up to date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf count > 0 Then
            MessageBox.Show("" & count & " videos and ebooks will be added to your offline base", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            downloadVideos(count, file_id)

        End If
        dbConnect.closeDbConnection() 'close connection
    End Sub

    Private Sub downloadVideos(count, file_id)

    End Sub


End Class
