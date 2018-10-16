'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 06/09/2018
'Class for database connection
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class databaseConnection
    Public conn As New MySqlConnection
    Public myConnectionString As String
    Public sqliteConnection As SQLiteConnection
    Public sqliteConnectionString As String
    Public reader As SQLiteDataReader
    Public MySqlReader As MySqlDataReader
    Public sqliteCommand As New SQLiteCommand
    'sqllite connection for offline database

    'creates connection
    Public Sub sqlLiteConnection(ByVal database As String)
        Dim dbLocation As String = database
        sqliteConnectionString = "Data Source=" & dbLocation & "; version=3;"
        sqliteConnection = New SQLiteConnection(sqliteConnectionString)
        sqliteConnection.Open()


    End Sub

    ' used for all insert statements
    Public Sub insertSqlite(ByVal strSql As String)

        Try
            sqliteCommand = New SQLiteCommand(strSql, sqliteConnection)
            sqliteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    ' used for all select statements
    Public Sub selectSqlite(ByVal strsql As String)
        Dim sqliteCommand As New SQLiteCommand(strsql, sqliteConnection)
        'Dim reader As SQLiteDataReader
        reader = sqliteCommand.ExecuteReader()
    End Sub
    'used for all update statements
    Public Sub closeSqlite()
        sqliteConnection.Close()

    End Sub

    'Connection to remote server

    Public Sub dbConnection()

        ' myConnectionString = " SERVER=127.0.0.1; database=dawatico_dawati; uid=root; pwd=''; SslMode= none; charset=UTF8 "
        myConnectionString = "  SERVER=192.185.17.39; database=dawatico_dawati; uid=dawatico_dawati; pwd='@dawati2016'; SslMode= none; charset=UTF8 "

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            ' MessageBox.Show("Success")


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub insertMySql(ByVal strSql As String)
        Try
            Dim sqlCommand As New MySqlCommand(strSql, conn)
            sqlCommand.CommandText = strSql
            sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub selectMySql(ByVal strSql As String)
        Try
            Dim sqlCommand As New MySqlCommand(strSql, conn)

            sqlCommand.CommandText = strSql
            MySqlReader = sqlCommand.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub closeDbConnection()
        conn.Close()
    End Sub

End Class
