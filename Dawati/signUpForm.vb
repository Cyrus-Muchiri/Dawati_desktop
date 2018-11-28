'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 06/09/2018
'Class for database connection
Imports MySql.Data
Imports System.Data.Sql
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports BCrypt.Net

Public Class signUpForm
    'global variables to store form details
    Private email As String
    Private Fname As String
    Private lname As String
    Private password As String
    Private cPassword As String
    Private gender As String
    Private userCategory As String
    Private count As Integer ' activates sign up button


    Public Sub initialize()

    End Sub
    'make sign up button inactive
    Private Sub signUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        signUpMetroButton.Enabled = False
    End Sub

    'start validation
    Private Sub fNameMetroTextBox_Click(sender As Object, e As EventArgs) Handles fNameMetroTextBox.LostFocus
        Fname = fNameMetroTextBox.Text
        Dim validater As New formValidation
        If validater.validateNames(Fname) = True Then
            fnameValidateLabel.Text = "correct*"
            fnameValidateLabel.ForeColor = Color.Green
            count = count + 1
        ElseIf validater.validateNames(Fname) = False Then
            fnameValidateLabel.Text = "incorrect*"
            fnameValidateLabel.ForeColor = Color.Red

        End If

    End Sub

    Private Sub lnameMetroTextBox_Click(sender As Object, e As EventArgs) Handles lnameMetroTextBox.LostFocus
        lname = lnameMetroTextBox.Text
        Dim validater As New formValidation
        If validater.validateNames(lname) = True Then
            lnameValidateLabel.Text = "correct*"
            lnameValidateLabel.ForeColor = Color.Green
            count = count + 1
        ElseIf validater.validateNames(lname) = False Then
            lnameValidateLabel.Text = "incorrect*"
            lnameValidateLabel.ForeColor = Color.Red

        End If

    End Sub
    Private Sub emailMetroTextBox_Click(sender As Object, e As EventArgs) Handles emailMetroTextBox.LostFocus
        'storing email in a variable
        email = emailMetroTextBox.Text
        'validating
        Dim validater As New formValidation
        If validater.validateEmail(email) = True Then
            emailValidateLabel.Text = "correct*"
            emailValidateLabel.ForeColor = Color.Green
            count = count + 1
        ElseIf validater.validateEmail(email) = False Then
            emailValidateLabel.Text = "incorrect*"
            emailValidateLabel.ForeColor = Color.Red
        End If

    End Sub
    Private Sub userTypeMetroComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userTypeMetroComboBox.LostFocus
        userCategory = userTypeMetroComboBox.SelectedItem

        count = count + 1
    End Sub

    Private Sub genderMetroComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles genderMetroComboBox.LostFocus
        'storing gender in a variable
        gender = genderMetroComboBox.SelectedItem

        count = count + 1
    End Sub

    Private Sub passwordMetroTextBox_Click(sender As Object, e As EventArgs) Handles passwordMetroTextBox.LostFocus
        'storing password in variable
        password = passwordMetroTextBox.Text
        Dim validater As New formValidation
        If validater.validatePassword(password) = True Then
            passwordValidateLabel.Text = "correct"
            passwordValidateLabel.ForeColor = Color.Green
            count = count + 1
        ElseIf validater.validatePassword(password) = False Then
            passwordValidateLabel.Text = "incorrect"
            passwordValidateLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub cPasswordMetroTextBox_Click(sender As Object, e As EventArgs) Handles cPasswordMetroTextBox.TextChanged
        'storing the cPassword in a variable
        cPassword = cPasswordMetroTextBox.Text
        Dim validater As New formValidation
        If validater.checkMatchingPassword(password, cPassword) = True Then
            cPasswordValidateLabel.Text = "Correct, passwords match"
            cPasswordValidateLabel.ForeColor = Color.Green
            count = count + 1
            'activate signUp button
            If count = 6 Or count > 6 Then
                signUpMetroButton.Enabled = True
            End If


        ElseIf validater.checkMatchingPassword(password, cPassword) = False Then
            cPasswordValidateLabel.Text = "Passwords do not match"
            cPasswordValidateLabel.ForeColor = Color.Red
        End If



    End Sub
    'end validation



    Private Sub signInMetroButton_Click(sender As Object, e As EventArgs) Handles signUpMetroButton.Click

        'creating email hash
        Dim hasher As New hashingClass
        'calling generateHash method through hasher object
        Dim hash As String = (hasher.generateHash(email)).Substring(10, 15)

        'computing user type
        Dim usertype As Integer
        If userCategory = "Teacher" Then
            usertype = 2
        ElseIf userCategory = "Student" Then
            usertype = 1
        ElseIf userCategory = "Mentor" Then
            usertype = 3

        End If

        Dim salt = BCrypt.Net.BCrypt.GenerateSalt(12)
        Dim hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt)
        Dim hashedCPassword = BCrypt.Net.BCrypt.HashPassword(cPassword, salt)

        If password = cPassword Then
            'connecting to database
            Dim dbConnect As New databaseConnection
            dbConnect.sqlLiteConnection("dawatico_dawati.db")

            Try
                Dim strSQL As String = " INSERT into users (fname,lname,email,hash,password,gender,user_type)
                VALUES ('" & Fname & "','" & lname & "','" & email & "','" & hash & "','" & hashedPassword & "','" & gender & "','" & usertype & "');"
                dbConnect.insertSqlite(strSQL)
                Dim sqlCommand As New MySqlCommand(strSQL, dbConnect.conn)
                'sqlCommand.CommandText = strSQL
                'sqlCommand.ExecuteNonQuery()
                MessageBox.Show("Welcome to Dawati. You will log in as soon as your account is confirmed")
                Close()
                'close connection
                'dbConnect.closeDbConnection()
                'close
                dbConnect.closeSqlite()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show(" Passwords do not match")

        End If

    End Sub
    Private Sub closeMetroButton_Click(sender As Object, e As EventArgs) Handles closeMetroButton.Click
        Me.Close()
    End Sub


End Class