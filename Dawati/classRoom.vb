'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 13/09/2018
'Class for sign in form
Imports System.IO

Public Class classRoom
    Private studyLevel As String 'instance variable to store level of study
    Private multimediaType As String 'stores the type of multimedia content
    Private multimediaSeries As String ' stores series< dipicte in database as subject
    Public Sub initialize(ByVal subject As String, ByVal learningMaterial As String, ByVal studyLevel As String)

        Text = subject
        studyLevelLabel.Text = studyLevel
        subjectLabel.Text = subject

        'select type of multimedia series
        If subject = "Mathematics" And learningMaterial = "videos" Then
            multimediaSeries = "3"
        ElseIf subject = "Mathematics" And learningMaterial = "eBook" Then
            multimediaSeries = "8"
        ElseIf subject = "chemistry" And learningMaterial = "videos" Then
            multimediaSeries = "2"
        ElseIf subject = "chemistry" And learningMaterial = "eBook" Then
            multimediaSeries = "6"
        ElseIf subject = "english" And learningMaterial = "videos" Then
            multimediaSeries = "1"
        ElseIf subject = "english" And learningMaterial = "eBook" Then
            multimediaSeries = "7"
        ElseIf subject = "physics" And learningMaterial = "videos" Then
            multimediaSeries = "12"
        ElseIf subject = "physics" And learningMaterial = "eBook" Then
            multimediaSeries = "9"
        ElseIf subject = "biology" And learningMaterial = "videos" Then
            multimediaSeries = "5"
        ElseIf subject = "biology" And learningMaterial = "eBook" Then
            multimediaSeries = "4"
        ElseIf subject = "social" And learningMaterial = "videos" Then
            multimediaSeries = ""
        ElseIf subject = "social" And learningMaterial = "eBook" Then
            multimediaSeries = ""
        End If

        'get level of study the user chose
        If studyLevel = "Form 1" Then
            Me.studyLevel = "level_001"
        ElseIf studyLevel = "Form 2" Then
            Me.studyLevel = "level_002"
        ElseIf studyLevel = "Form 3" Then
            Me.studyLevel = "level_003"
        ElseIf studyLevel = "Form 4" Then
            Me.studyLevel = "level_004"
        End If

        loadVideos()
        loadPracticals()
        loadExams()



    End Sub
    Private Sub loadVideos()
        multimediaType = "1"
        loadLearningMaterials(studyLevel, multimediaType, classWorkListBox)
    End Sub

    Private Sub loadPracticals()
        multimediaType = "2"
        loadLearningMaterials(studyLevel, multimediaType, labListBox)

    End Sub
    Private Sub loadExams()
        multimediaType = "3"
        loadLearningMaterials(studyLevel, multimediaType, examsListBox)


    End Sub

    ' gets all readig materials With respect To the params passed
    Private Sub loadLearningMaterials(ByVal studyLevel As String, ByVal multmediaType As String, ByVal listBox As ListBox)
        'the parameters are only visible here despite similar names with the instance variables
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("multimedia.db")
        Dim strSql As String
        strSql = "Select file_type,file_name,multimedia_type,study_level FROM multimedia_content where study_level='" & studyLevel & "'
        AND multimedia_type= '" & multimediaType & "' AND multimedia_series= '" & multimediaSeries & "';"
        'Dim sqlCommand As New MySqlCommand(strSql, dbConnect.conn)
        'Dim reader As MySqlDataReader
        'sqlCommand.CommandText = strSql
        'reader = sqlCommand.ExecuteReader

        dbConnect.selectSqlite(strSql)

        While dbConnect.reader.Read
            listBox.Items.Add(dbConnect.reader("file_name"))
            ebookViewer.ebookPlayListBox.Items.Add(dbConnect.reader("file_name"))
            videoPlayer.playListListBox.Items.Add(dbConnect.reader("file_name"))
        End While
        dbConnect.closeSqlite()
    End Sub
    'get the selected videos and call player
    Public Sub getSelectedVideo(ByVal listBox As ListBox)

        'videos in file are encrypted so we have to ecrypt first.

        Dim selectedItem As String = listBox.SelectedItem
        'string to decrypt , order is reverse, substring then reverse.
        Dim urlToSubstring As String = StrReverse("assets\videos\encrypted\" & selectedItem & "")
        'removes the file extension by substringing while in reverse
        Dim partialString As String = urlToSubstring.Substring(4)
        'revesing back to get orignal string
        Dim urlToDecrypt = StrReverse(partialString)
        mainForm.decryptVideo(urlToDecrypt)
        Dim videoUrl As String = "assets\videos\decrypted\" & selectedItem & ""
        playVideo(videoUrl)
    End Sub
    'get the selected videos and call player
    Public Sub getSelectedEbook(ByVal listBox As ListBox)
        'videos in file are encrypted so we have to decrypt first.

        Dim selectedItem As String = listBox.SelectedItem
        'string to decrypt , order is reverse, substring then reverse.
        'Dim urlToSubstring As String = StrReverse("assets\ebooks\encrypted\" & selectedItem & "")
        'removes the file extension by substringing while in reverse
        'Dim partialString As String = urlToSubstring.Substring(4)
        ''revesing back to get orignal string
        Dim urlToDecrypt = "assets\ebooks\encrypted\" & selectedItem & ""
        mainForm.decryptEbook(urlToDecrypt)
        Dim ebookUrl As String = "assets\ebooks\decrypted\" & selectedItem & ".pdf"
        MessageBox.Show(ebookUrl)
        playEbook(ebookUrl)
    End Sub
    Private Sub playVideo(ByVal url As String)
        videoPlayer.initialize(url)
        'MessageBox.Show(url)
        videoPlayer.Show()
    End Sub
    Private Sub playEbook(ByVal url As String)
        ebookViewer.Show()
        ebookViewer.initialize(url)

    End Sub


    'do not change the names of the selected tab string
    Public Sub viewMetroButton_Click(sender As Object, e As EventArgs) Handles viewMetroButton.Click
        ' Dim multimediaSeries As String 'this is a local one
        If mainForm.learningMaterialType = "videos" Then
            Dim listbox As ListBox
            Dim selectedTab As String = classRoomMetroTabControl.SelectedTab.Text
            If selectedTab = "                                    Lab practicals                                          |" Then
                listbox = labListBox
                getSelectedVideo(listbox)
                'videoPlayer.fillListBox()


            ElseIf selectedTab = "                              Class Work                                           |" Then
                listbox = classWorkListBox
                getSelectedVideo(listbox)
                ' videoPlayer.fillListBox()

                ' MessageBox.Show("true")
            ElseIf selectedTab = "                                     Exams                           " Then
                listbox = examsListBox
                getSelectedVideo(listbox)
                'videoPlayer.fillListBox()

            Else
                'MessageBox.Show(selectedTab)
            End If
        ElseIf mainForm.learningMaterialType = "ebooks" Then
            Dim listbox As ListBox
            Dim selectedTab As String = classRoomMetroTabControl.SelectedTab.Text
            If selectedTab = "                                    Lab practicals                                          |" Then
                listbox = labListBox
                getSelectedEbook(listbox)
                'videoPlayer.fillListBox()


            ElseIf selectedTab = "                              Class Work                                           |" Then
                listbox = classWorkListBox
                getSelectedEbook(listbox)
                ' videoPlayer.fillListBox()

                ' MessageBox.Show("true")
            ElseIf selectedTab = "                                     Exams                           " Then
                listbox = examsListBox
                getSelectedEbook(listbox)
                'videoPlayer.fillListBox()

            Else
                'MessageBox.Show(selectedTab)
            End If
        End If

    End Sub


    Private Sub exitMetroButton_Click(sender As Object, e As EventArgs) Handles exitMetroButton.Click
        Close()
    End Sub


End Class