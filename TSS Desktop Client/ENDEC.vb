Option Strict On
Option Explicit On 

Imports System.Text

Public Class ENDEC

    Public Function encryptString(ByVal value As String) As String
        Try
            Dim _e As New ASCIIEncoding
            Return Convert.ToBase64String(_e.GetBytes(value))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function decryptString(ByVal value As String) As String
        Try
            Dim _e As New ASCIIEncoding
            Return _e.GetString(Convert.FromBase64String(value))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
