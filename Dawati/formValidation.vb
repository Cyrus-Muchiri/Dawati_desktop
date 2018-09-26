'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 08/09/2018
'Class for validation
Imports System.Text.RegularExpressions

Public Class formValidation
    'validation of input fields
    Public Function validateEmail(ByVal email As String) As Boolean
        Dim emailRegx As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        If String.IsNullOrEmpty(email) = False Then
            Return emailRegx.IsMatch(email)
        Else
            Return False
        End If

    End Function

    Public Function validateNames(ByVal name As String) As Boolean

        Dim nameRegx As Regex = New Regex("[a-z]+") 'stores regular expression for name
        If String.IsNullOrEmpty(name) = False Then
            Return nameRegx.IsMatch(name)
        Else
            Return False
        End If

    End Function

    Public Function validatePassword(ByVal password As String) As Boolean
        Dim passwordRegx As Regex = New Regex("[0-9]+")
        Try
            If String.IsNullOrEmpty(password) = False Then
                Return passwordRegx.IsMatch(password)
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Public Function checkMatchingPassword(ByVal password As String, ByVal cPassword As String) As Boolean
        If password = cPassword Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
