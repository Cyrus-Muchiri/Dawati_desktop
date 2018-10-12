'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 07/09/2018
'Class for sign in form

Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class signInForm

    'global variables
    Private userCategory As Integer
    Private dbPassword As String
    Public email As String
    Private userStatus As String

    'log in operation
    Private Sub signInMetroButton_Click(sender As Object, e As EventArgs) Handles signInMetroButton.Click
        'input from form
        email = emailMetroTextBox.Text
        Dim salt = BCrypt.Net.BCrypt.GenerateSalt(12)
        'Dim password = BCrypt.Net.BCrypt.HashPassword(passwordMetroTextBox.Text, salt)
        Dim password = passwordMetroTextBox.Text
        'getting details from database

        'initializing connection
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("dawatico_dawati.db")
        Try
            Dim strSQL As String = "SELECT user_status,email, password, user_type from users WHERE email='" & email & "' ;"



            'MYSQL WAS TO USED FOR ONLINE BUT THIS APP IS OFFLINE
            'Dim sqlCommand As New MySqlCommand(strSQL, dbConnect.conn)
            'Dim reader As MySqlDataReader
            'sqlCommand.CommandText = strSQL
            'reader = sqlCommand.ExecuteReader

            'calling sqlite methods
            dbConnect.selectSqlite(strSQL)

            While dbConnect.reader.Read
                userCategory = dbConnect.reader("user_type")
                dbPassword = dbConnect.reader("password").ToString
                userStatus = dbConnect.reader("user_status").ToString
            End While
            ' MessageBox.Show("success")
            'close connection
            dbConnect.closeSqlite()

        Catch ex As Exception
            '   MessageBox.Show(ex.Message)
        End Try
        'comparing passwords
        If userStatus = "Confirmed" Then
            If BCrypt.Net.BCrypt.Verify(password, dbPassword) Then
                'getting user category
                If userCategory = 1 Then
                    'mainForm.initialize()
                    'mainForm.Show()
                    'Close()
                    ''welcomeForm.Hide()
                    'Dim main As New mainForm
                    mainForm.initialize()
                    'main.MdiParent = dawatiParent
                    'mainForm.Show()
                    dawatiParent.Show()
                    Close()
                    welcomeForm.Hide()
                ElseIf userCategory = 2 Then
                    'mainForm.initialize()
                    'mainForm.Show()
                    'Close()
                    'welcomeForm.Hide()
                    'Dim main As New mainForm
                    mainForm.initialize()
                    'main.MdiParent = dawatiParent
                    'mainForm.Show()
                    dawatiParent.Show()
                    Close()
                    welcomeForm.Hide()
                ElseIf userCategory = 3 Then
                    'Dim main As New mainForm
                    mainForm.initialize()
                    'main.MdiParent = dawatiParent
                    'mainForm.Show()
                    dawatiParent.Show()
                    Close()
                    welcomeForm.Hide()
                ElseIf userCategory = 4 Then
                    'MessageBox.Show("You will be logged on as a School admin    ")
                ElseIf userCategory = 5 Then
                    'MessageBox.Show("You will be logged on as a admin")
                End If
            Else
                MessageBox.Show("Wrong password")

            End If
        Else
            MessageBox.Show("Your account is yet to be confirmed")
        End If

    End Sub
    'handles close operation
    Private Sub loadMain()

    End Sub
    Private Sub closeMetroButton_Click(sender As Object, e As EventArgs) Handles closeMetroButton.Click
        Me.Close()
    End Sub


End Class
