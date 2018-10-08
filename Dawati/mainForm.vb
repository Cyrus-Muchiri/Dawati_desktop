'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologie
'date : 10/09/2018
'Class for database connection
Imports MySql.Data.MySqlClient
Imports System.Threading.Thread
Imports System.Net


Imports System.IO

' enumeration for user type, visible through the project

Public Class mainForm
    'variable to store whether videos or ebooks the user chose to click
    Public subject As String ' stores subject
    Public evaluationSubject ' stores subject for evaluation
    Public learningMaterial As String 'stores video or ebook
    Public Shared learningMaterialType As String = "videos" ' stores either value ebook or video
    Public url As String
    Private fname As String
    Private evaluation As New evaluationForm 'evaluationForm object
    Public Sub initialize()
        videosMetroPanel.Visible = True
        ebooksMetroPanel.Visible = False
        profilePanel.Visible = False
        evaluationMetroPanel.Visible = False
        aboutPanel.Visible = False



        'Me.BackColor = Color.FromArgb()


        'variables for profile pic, last name first name and status
        Dim prof_pic As String
        Dim lname As String
        'Dim fname As String
        Dim userStatus As String

        'database object
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("dawatico_dawati.db")
        Try
            Dim email As String = signInForm.email
            Dim strSQL As String = "SELECT fname, lname, prof_img from users WHERE email='" & email & "' ;"

            'REMOTE CONNECTION, NOT USED NOW
            'Dim sqlCommand As New MySqlCommand(strSQL, dbConnect.conn)
            'Dim reader As MySqlDataReader
            'sqlCommand.CommandText = strSQL
            'reader = sqlCommand.ExecuteReader

            dbConnect.selectSqlite(strSQL)
            If dbConnect.reader.Read Then
                prof_pic = dbConnect.reader("prof_img")
                fname = dbConnect.reader("fname")
                lname = dbConnect.reader("lname")


            End If

            dbConnect.closeSqlite()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'loading image from file manager

        'This was used to get profile image from remote server, not useful now
        'Dim request As WebRequest
        'request = WebRequest.Create("http://www.dawati.co.ke/profile_pictures/" & prof_pic & "")
        'Dim response As Stream = request.GetResponse.GetResponseStream

        'change before deployment

        avatarPictureBox.Image = Image.FromFile("assets\profile_pictures\" & prof_pic & "")
        avatarPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        emailMetroLabel.Text = signInForm.email
        fnameMetroLabel.Text = fname
        LnameMetroLabel.Text = lname

        'checks internet conection, if present syncs
        Dim loading_object = New loading
        loading.checkConnection()

        'encrypts files, if there are any decrypted
        encrypt()


    End Sub

    'Private Function createDirectory()
    '    'check whether directory exists
    '    Dim exists As Boolean = IO.Directory.Exists("assets\")
    '    If exists = False Then
    '        My.Computer.FileSystem.CreateDirectory("assets\dec")
    '        My.Computer.FileSystem.CreateDirectory("assets\enc")
    '        My.Computer.FileSystem.CreateDirectory("assets\dec")
    '        My.Computer.FileSystem.CreateDirectory("assets\enc")
    '        My.Computer.FileSystem.CreateDirectory("assets\profilePictures")
    '        ' Dim dirInfo As IO.DirectoryInfo = New IO.DirectoryInfo("C:\dawati")


    '    End If

    'End Function
    Public Function encrypt()
        Dim encrypter As New folderEnc
        'looping through all video files

        Try
            For Each videoDir As String In Directory.GetFiles("assets\videos\decrypted")
                'Dim dir As String = "c:\ProgramData\dawati\videos\power.mkv"
                Dim originalFileName As String = videoDir.Substring(24)
                Dim filenameNoExtension As String = System.IO.Path.GetFileNameWithoutExtension(originalFileName)
                Dim outfilePath = "assets\videos\encrypted\" & filenameNoExtension & ""
                Dim password = "1234567890"

                'calling encryptor
                encrypter.EncryptFile(password, videoDir, outfilePath)

                'deleting the files
                My.Computer.FileSystem.DeleteFile(videoDir)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'looping through all ebook fils

        Try
            For Each ebookDir As String In Directory.GetFiles("assets\ebooks\decrypted")
                'Dim dir As String = "c:\ProgramData\dawati\videos\power.mkv"
                Dim originalFileName As String = ebookDir.Substring(24)

                Dim filenameNoExtension As String = System.IO.Path.GetFileNameWithoutExtension(originalFileName)
                Dim outfilePath = "assets\ebooks\encrypted\" & filenameNoExtension & ""
                Dim password = "1234567890"
                encrypter.EncryptFile(password, ebookDir, outfilePath)
                My.Computer.FileSystem.DeleteFile(ebookDir)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Function


    Public Function decryptVideo(ByVal path As String)
        Dim decrypter As New folderEnc
        'looping through all video files
        Try
            Dim videosPath = path
            Dim originalFileName As String = videosPath.Substring(24)

            'Dim filenameNoExtension As String = System.IO.Path.GetFileNameWithoutExtension(originalFileName)
            Dim outfilePath = "assets\videos\decrypted\" & originalFileName & ".m4v"
            url = outfilePath
            Dim password = "1234567890"
            decrypter.DecryptFile(password, videosPath, outfilePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'looping through all ebook files
    End Function
    Public Function decryptEbook(ByVal path As String)
        Dim decrypter As New folderEnc

        Try
            Dim ebooksPath = path

            Dim originalFileName As String = ebooksPath.Substring(24)
            'Dim filenameNoExtension As String = System.IO.Path.GetFileNameWithoutExtension(originalFileName)
            Dim outfilePath = "assets\ebooks\decrypted\" & originalFileName & ".pdf"
            Dim password = "1234567890"
            decrypter.DecryptFile(password, ebooksPath, outfilePath)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Private Sub videosMetroTile_Click(sender As Object, e As EventArgs) Handles videosMetroTile.Click
        videosMetroPanel.Visible = True
        learningMaterialType = "videos"
        ebooksMetroPanel.Visible = False
        profilePanel.Visible = False
        evaluationMetroPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    Private Sub ebooksMetroTile_Click(sender As Object, e As EventArgs) Handles ebooksMetroTile.Click
        ebooksMetroPanel.Visible = True
        learningMaterialType = "ebooks"
        videosMetroPanel.Visible = False
        profilePanel.Visible = False
        evaluationMetroPanel.Visible = False
        aboutPanel.Visible = False
    End Sub
    Private Sub evaluationsMetroTile_Click(sender As Object, e As EventArgs) Handles evaluationsMetroTile.Click
        ebooksMetroPanel.Visible = False
        aboutPanel.Visible = False
        videosMetroPanel.Visible = False
        profilePanel.Visible = False
        evaluationMetroPanel.Visible = True
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles profileMetroTile.Click
        viewProfile()
        videosMetroPanel.Visible = False
        ebooksMetroPanel.Visible = False
        profilePanel.Visible = True
        evaluationMetroPanel.Visible = False
        aboutPanel.Visible = False

    End Sub
    Private Sub editMetroButton_Click(sender As Object, e As EventArgs) Handles editMetroButton.Click
        fnameMetroTextBox.ReadOnly = False
        lnameMetroTextBox.ReadOnly = False
        emailMetroTextBox.ReadOnly = False
        browseButton.Visible = True
        aboutPanel.Visible = False
        editMetroButton.Visible = False
        updateMetroButton.Visible = True
    End Sub

    Private Sub aboutMetroTile_Click(sender As Object, e As EventArgs) Handles aboutMetroTile.Click
        videosMetroPanel.Visible = False
        ebooksMetroPanel.Visible = False
        profilePanel.Visible = False
        evaluationMetroPanel.Visible = False
        aboutPanel.Visible = True
    End Sub

    'Videos MetroTiles OnClick
    '--------------------------
    Private Sub mathsVideosMetroTile_Click(sender As Object, e As EventArgs) Handles mathsVideosMetroTile.Click
        subject = "Mathematics"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishVideosMetroTile_Click(sender As Object, e As EventArgs) Handles englishVideosMetroTile.Click
        subject = "english"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsVideosMetroTile_Click(sender As Object, e As EventArgs) Handles physicsVideosMetroTile.Click

        subject = "physics"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub socialVideosMetroTile_Click(sender As Object, e As EventArgs) Handles socialVideosMetroTile.Click
        subject = "social"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyVideosMetroTile_Click(sender As Object, e As EventArgs) Handles biologyVideosMetroTile.Click
        subject = "biology"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub chemistryVideosMetroTile_Click(sender As Object, e As EventArgs) Handles chemistryVideosMetroTile.Click
        subject = "chemistry"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub
    'End Videos MetroTile Click
    '----------------------------
    'Videos PictureBoxes on Click
    '--------------------------


    Private Sub mathVideosPictureBox_Click(sender As Object, e As EventArgs) Handles mathVideosPictureBox.Click
        subject = "Mathematics"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishVideosPictureBox_Click(sender As Object, e As EventArgs) Handles englishVideosPictureBox.Click
        subject = "english"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsVideosPictureBox_Click(sender As Object, e As EventArgs) Handles physicsVideosPictureBox.Click

        subject = "physics"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyVideosPictureBox_Click(sender As Object, e As EventArgs) Handles biologyVideosPictureBox.Click
        subject = "biology"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub chemistryVideosPictureBox_Click(sender As Object, e As EventArgs) Handles chemistryVideosPictureBox.Click
        subject = "chemistry"
        learningMaterial = "videos"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub
    'End videos pictureBoxes click
    '--------------------------------



    'Ebooks MetroTiles on Click
    '-------------------------
    Private Sub chemistryEbookMetroTile_Click(sender As Object, e As EventArgs) Handles chemistryEbookMetroTile.Click
        subject = "chemistry"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub mathsEbooksMetroTile_Click(sender As Object, e As EventArgs) Handles mathsEbooksMetroTile.Click
        subject = "Mathematics"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishEbooksMetroTile_Click(sender As Object, e As EventArgs) Handles englishEbooksMetroTile.Click
        subject = "english"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsEbookMetroTile_Click(sender As Object, e As EventArgs) Handles physicsEbookMetroTile.Click
        subject = "physics"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub socialEbookMetroTile_Click(sender As Object, e As EventArgs) Handles socialEbookMetroTile.Click
        subject = "social"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyEbookMetroTile_Click(sender As Object, e As EventArgs) Handles biologyEbookMetroTile.Click
        subject = "biology"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub
    'Ebooks PictureBoxes on click
    '----------------------------
    Private Sub mathsEbooksPictureBox_Click(sender As Object, e As EventArgs) Handles mathsEbooksPictureBox.Click
        subject = "Mathematics"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub englishEbooksPictureBox_Click(sender As Object, e As EventArgs) Handles englishEbooksPictureBox.Click
        subject = "english"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub physicsEbooksPictureBox_Click(sender As Object, e As EventArgs) Handles physicsEbooksPictureBox.Click
        subject = "physics"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub biologyEbooksPictureBox_Click(sender As Object, e As EventArgs) Handles biologyEbooksPictureBox.Click
        subject = "biology"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    Private Sub chemistryEbooksPictureBox_Click(sender As Object, e As EventArgs) Handles chemistryEbooksPictureBox.Click
        subject = "chemistry"
        learningMaterial = "eBook"
        selectStudyLevel.initialize(subject, learningMaterial)
        selectStudyLevel.Show()
    End Sub

    'View profile panel
    '--------------------
    Private Sub viewProfile()
        Dim prof_image As String
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("dawatico_dawati.db")
        Dim strSql As String = "select fname, lname, email, prof_img, gender,user_type from users where fname = '" & fname & "'"
        dbConnect.selectSqlite(strSql)
        While dbConnect.reader.Read
            fnameMetroTextBox.Text = dbConnect.reader("fname").ToString
            lnameMetroTextBox.Text = dbConnect.reader("lname").ToString
            genderMetroComboBox.SelectedItem = dbConnect.reader("gender").ToString
            userTypeMetroTextBox.Text = "Student"
            emailMetroTextBox.Text = dbConnect.reader("email").ToString
            prof_image = dbConnect.reader("prof_img").ToString
            profilemagePictureBox.Image = Image.FromFile("assets\profile_pictures\" & prof_image & "")

        End While
    End Sub

    'End Profile
    '----------

    ' begin evaluation tiles and pictureboxes
    '------------------------------------------

    Private Sub mathsEvalMetroTile_Click(sender As Object, e As EventArgs) Handles mathsEvalMetroTile.Click

        evaluationForm.databaseReader("Mathematics")
        evaluationForm.Show()
    End Sub

    Private Sub engEvalMetroTile_Click(sender As Object, e As EventArgs) Handles engEvalMetroTile.Click
        evaluationForm.databaseReader("English")
        evaluationForm.Show()
    End Sub

    Private Sub phyEvalMetroTile_Click(sender As Object, e As EventArgs) Handles phyEvalMetroTile.Click
        evaluationForm.databaseReader("Physics")
        evaluationForm.Show()
        'evaluationSubject = "Physics"
    End Sub

    Private Sub chemistryEvalMetroTile_Click(sender As Object, e As EventArgs) Handles chemistryEvalMetroTile.Click
        evaluationForm.databaseReader("Chemistry")
        evaluationForm.Show()
    End Sub

    Private Sub biologyEvalMetroTile_Click(sender As Object, e As EventArgs) Handles biologyEvalMetroTile.Click
        evaluationForm.databaseReader("Biology")
        evaluationForm.Show()
    End Sub




    'Evaluations Picture Boxes on Click
    '----------------------------------

    Private Sub mathsPictureBox_Click(sender As Object, e As EventArgs) Handles mathsPictureBox.Click

        evaluationForm.Show()
        evaluationForm.databaseReader("Mathematics")
    End Sub

    Private Sub englishPictureBox_Click(sender As Object, e As EventArgs) Handles englishPictureBox.Click
        evaluationForm.databaseReader("English")
        evaluationForm.Show()
    End Sub

    Private Sub physicsPictureBox_Click(sender As Object, e As EventArgs) Handles physicsPictureBox.Click
        evaluationForm.databaseReader("Physics")
        evaluationForm.Show()
    End Sub

    Private Sub chemistryPictureBox_Click(sender As Object, e As EventArgs) Handles chemistryPictureBox.Click
        evaluationForm.databaseReader("Chemistry")
        evaluationForm.Show()
    End Sub

    Private Sub biologyPictureBox_Click(sender As Object, e As EventArgs) Handles biologyPictureBox.Click
        evaluationForm.databaseReader("Biology")
        evaluationForm.Show()
    End Sub
    'End PictureBoxes Click for evaluations
    '------------------------------------
    'Exit Button
    '-------------

    Private Sub exitMetroButton_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click

        Close()
        Application.Exit()
    End Sub




    Private Sub logoutMetroTile_Click(sender As Object, e As EventArgs) Handles logoutMetroTile.Click
        Close()
    End Sub
    'updates content
    Private Sub updateContentMetroTile_Click(sender As Object, e As EventArgs) Handles updateContentMetroTile.Click
        Dim dialogReslt As DialogResult
        dialogReslt = MessageBox.Show("Your content will be updated on the background. Click OK to continue", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If dialogReslt = DialogResult.OK Then
            'start
            BackgroundWorker1.RunWorkerAsync()

        Else

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        System.Threading.Thread.Sleep(10000)
        loading.updateContent()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object,
                                                     ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Finished downloading your content")
    End Sub

    Private Sub mainForm_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub


    'End exit
    '---------





End Class