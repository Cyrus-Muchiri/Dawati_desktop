'author :Cyrus Muchiri< cyrusmuchirichomba@gmail.com > for Carrel technologies
'date : 06/09/2018
'hashing

Imports System.Text
Imports System.Security.Cryptography
Public Class hashingClass

    Public Function generateHash(input As String) As String

        Using hasher As MD5 = MD5.Create()
            Dim byteSource As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sBuilder As New StringBuilder()
            For n As Integer = 0 To byteSource.Length - 1
                sBuilder.Append(byteSource(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using
    End Function

End Class
