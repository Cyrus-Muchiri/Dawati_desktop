Public Class evaluationForm

    Public rowCount As Integer = 0

    Public Sub initialize()



    End Sub
    Public Sub databaseReader()
        Dim dbConnect As New databaseConnection
        dbConnect.sqlLiteConnection("Evaluations.db")
        Dim selectsql As String = "select exam_name,hours,minutes from exams"
        dbConnect.selectSqlite(selectsql)

        While dbConnect.reader.Read

            evaluationsListBox.Items.Add(dbConnect.reader("exam_name"))
        End While
        dbConnect.closeSqlite()
    End Sub


    Public Sub trueOrFalseQuestions()
        'initialize components
        Dim varTest = New System.Windows.Forms.Label()

    End Sub

    'single select questions
    Private Sub singleSelectQuestion()

    End Sub

    'multiple select questions
    Private Sub multipleSelectQuestion()

    End Sub
    'open ended questions
    Public Sub openEndedQuestion()

    End Sub


End Class